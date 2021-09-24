using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epidemic_Simulator
{
    public enum Estado { Sano, Enfermo, Curado, Muerto};
    public static class StaticRandom
    {
        private static int seed;

        private static ThreadLocal<Random> threadLocal = new ThreadLocal<Random>
            (() => new Random(Interlocked.Increment(ref seed)));

        static StaticRandom()
        {
            seed = Environment.TickCount;
        }

        public static Random Instance { get { return threadLocal.Value; } }
    }

    public class Coordenadas
    {
        public float x { get; set; }
        public float y { get; set; }
        public Coordenadas(Graphics g)
        {
            Random j = new Random();
            x = StaticRandom.Instance.Next(10, (int)g.VisibleClipBounds.Right - 10);
            y = StaticRandom.Instance.Next(10, (int)g.VisibleClipBounds.Bottom - 10);
        }
        public override bool Equals(object obj)
        {
            float sensibilidad = 10.0f;
            return Math.Abs(x - ((Coordenadas)obj).x) <= sensibilidad && Math.Abs(y - ((Coordenadas)obj).y) <= sensibilidad;
        }
        public bool Near(object obj, float sensibilidad)
        {
            return Math.Abs(x - ((Coordenadas)obj).x) <= sensibilidad && Math.Abs(y - ((Coordenadas)obj).y) <= sensibilidad;
        }
    }
    public class Hogar
    {
        public Coordenadas cord { get; set; }
        public int ancho { get; set; }
        public int alto { get; set; }
        double n;
        public Hogar(Graphics g, int n)
        {
            
            this.n = n;
            Resize(g);
        }
        public void Resize(Graphics g)
        {
            if (n < 10)
            {
                cord = new Coordenadas(g);
                cord.x = (int)((10* n + 1) * (g.VisibleClipBounds.Right) / 100);
                cord.y = (int)((1) * (g.VisibleClipBounds.Bottom) / 100);

                ancho = (int)((8) * (g.VisibleClipBounds.Right) / 100);
                alto = (int)((8) * (g.VisibleClipBounds.Bottom) / 100);

            }
            else if (n < 26)
            {
                if (n % 2 == 0)
                {
                    cord = new Coordenadas(g);
                    cord.x = (int)((1) * (g.VisibleClipBounds.Right) / 100);
                    cord.y = (int)((((n / 2) - 4) * 10) * (g.VisibleClipBounds.Bottom) / 100);

                    ancho = (int)((8) * (g.VisibleClipBounds.Right) / 100);
                    alto = (int)((8) * (g.VisibleClipBounds.Bottom) / 100);
                }
                else
                {
                    cord = new Coordenadas(g);
                    cord.x = (int)((91) * (g.VisibleClipBounds.Right) / 100);
                    cord.y = (int)(((((n-1) / 2) - 4) * 10) * (g.VisibleClipBounds.Bottom) / 100);

                    ancho = (int)((8) * (g.VisibleClipBounds.Right) / 100);
                    alto = (int)((8) * (g.VisibleClipBounds.Bottom) / 100);
                }
            }
            else
            {
                cord = new Coordenadas(g);
                cord.x = (int)((10 * (n - 26) + 1) * (g.VisibleClipBounds.Right) / 100);
                cord.y = (int)((91) * (g.VisibleClipBounds.Bottom) / 100);

                ancho = (int)((8) * (g.VisibleClipBounds.Right) / 100);
                alto = (int)((8) * (g.VisibleClipBounds.Bottom) / 100);
            }




        }
        public void Dibujar(Graphics g)
        {
           if (cord != null)
            g.DrawRectangle(Pens.Lime, cord.x, cord.y, ancho, alto);
        }
    }
    public class Individuo
    {
        public Coordenadas posicion { get; set; }
        public Coordenadas destino { get; set; }
        public Hogar hogar { get; set; }
        public Estado estado { get; set; }
        public bool asintomatico { get; set; }
        public bool Higiene { get; set; }
        public bool cuarentena { get; set; }
        public bool DistanciamientoSocial { get; set; }

        public int dias_enfermo { get; set; }

        int T = 5; //Tamaño
        int V = 9; //Velocidad
        float dx;
        float dy;
        public Individuo(Graphics g)
        {

            estado = (Estado.Sano);// (StaticRandom.Instance.Next(0, 4));
            posicion = destino = new Coordenadas(g);
        }
        public void Mover(Graphics g, int cuarentena, int distanciamiento)
        {
            if (estado != Estado.Muerto)
            {
                if (posicion.Equals(destino))
                {
                    destino = new Coordenadas(g);

                    if (cuarentena != 0)
                        if (StaticRandom.Instance.Next(0, 99) < cuarentena)
                        {
                            destino.x = StaticRandom.Instance.Next((int)hogar.cord.x, (int)hogar.cord.x + hogar.ancho);
                            destino.y = StaticRandom.Instance.Next((int)hogar.cord.y, (int)hogar.cord.y + hogar.alto);

                        }


                    int simbX = 0;
                    int simbY = 0;

                    if (destino.x < posicion.x)
                    { dx = posicion.x - destino.x; simbX = -1; }
                    else if (destino.x > posicion.x)
                    { dx = destino.x - posicion.x; simbX = 1; }
                    else
                        dx = 0;

                    if (destino.y < posicion.y)
                    { dy = posicion.y - destino.y; simbY = -1; }
                    else if (destino.y > posicion.y)
                    { dy = destino.y - posicion.y; simbY = 1; }
                    else
                        dy = 0;

                    double ang = Math.Atan2(dy, dx);

                    dy = (float)(V * simbY * Math.Sin(ang));
                    dx = (float)(V * simbX * Math.Cos(ang));
                }
                posicion.x += dx;
                posicion.y += dy;
            }
        }
        public void Dibujar(Graphics g, int i, bool ver_proximidad)
        {
            //g.FillEllipse(Brushes.Red, destino.x - (T / 2), destino.y - (T / 2), T, T);

            if (estado != Estado.Muerto)
            {
                if (estado == Estado.Enfermo)
                    g.FillEllipse(Brushes.Firebrick, posicion.x - (T / 2), posicion.y - (T / 2), T, T);
                else if(estado == Estado.Curado)
                    g.FillEllipse(Brushes.DarkOliveGreen, posicion.x - (T / 2), posicion.y - (T / 2), T, T);
                else
                    g.FillEllipse(new SolidBrush(Color.FromArgb(0, 120, 215)), posicion.x - (T / 2), posicion.y - (T / 2), T, T);

                if (ver_proximidad)
                    g.DrawRectangle(Pens.Red, posicion.x - i, posicion.y - i, 2 * i, 2 * i);

                if (asintomatico)
                    g.DrawEllipse(Pens.White, posicion.x - (T / 2), posicion.y - (T / 2), T, T);

            }
            else
                g.FillEllipse(Brushes.Black, posicion.x - (T / 2), posicion.y - (T / 2), T, T);

            //g.DrawString(i.ToString(), new Font("Arial", 10), Brushes.White, posicion.x - (T / 2), posicion.y - (T / 2));
        }
    }
}
