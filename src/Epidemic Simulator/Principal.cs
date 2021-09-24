using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epidemic_Simulator
{
    public partial class Principal : Form
    {
        List<Individuo> individuos = new List<Individuo>();
        List<Hogar> hogares = new List<Hogar>();


        Graphics g;
        Graphics H;
        public Principal()
        {
            InitializeComponent();
            g = scene.CreateGraphics();
            H = scene.CreateGraphics();

        }

        void EmpezarSimulacion()
        {
            Graphics g = scene.CreateGraphics();

            individuos.Clear();
            for (int i = 0; i < 36; i++)
                hogares.Add(new Hogar(g, i));

            individuos.Clear();
            for (int j = 0; j < nudPopulation.Value; j++)
            {
                Individuo i = new Individuo(g);
                if (cbDistanciamientoSocial.Checked == true)
                {
                    if (StaticRandom.Instance.Next(0, 100) < nudDistanciamiento.Value)
                        i.DistanciamientoSocial = true;
                }
                if (cbCuarentena.Checked == true)
                {
                    if (StaticRandom.Instance.Next(0, 100) < nudCuarentena.Value)
                        i.cuarentena = true;
                }
                if (cbHigiene.Checked == true)
                {
                    if (StaticRandom.Instance.Next(0, 100) < nudHigiene.Value)
                        i.Higiene = true;
                }
                if (cbAsintomatico.Checked == true)
                {
                    if (StaticRandom.Instance.Next(0, 100) < nudAsintomatico.Value)
                        i.asintomatico = true;
                }

                i.hogar = hogares[StaticRandom.Instance.Next(0, 36)];

                individuos.Add(i);
            }
            for (int j = 0; j < nudInfectedPopulation.Value; j++)
                individuos[j].estado = Estado.Enfermo;


           
        }
        ulong time = 0;
        void MostrarHora()
        {
            lblTime.Text = time.ToString();
               //years.ToString() + " Years, " +
               //months.ToString() + " Months, " +
               //days.ToString() + " Days, " +
               //hours.ToString() + " Hours, " +
               //minutes.ToString() + " Minutes";
        }

        int sano = 0, enfermo = 0, muerto = 0, curado = 0, poblacion = 0;
        int SANO = 0, ENFERMO = 1, MUERTO = 0, CURADO = 0, POBLACION = 0;
        void Proceso()
        {
            while (true)
            {
                try
                {
                    sano = 0; enfermo = 0; muerto = 0; curado = 0; poblacion = 0;
                    time++;
                    foreach (Individuo i in individuos)
                    {
                        i.Mover(H, (int)nudCuarentena.Value, (int)nudDistanciamiento.Value);

                        foreach (Individuo j in individuos)
                        {
                            if (j != null)
                                if (j.posicion.Near(i.posicion, (float)nudProximidad.Value))
                                {
                                    if (j.estado == Estado.Enfermo && i.estado == Estado.Sano)
                                    {
                                        if (i.Higiene == false)
                                        {
                                            if (StaticRandom.Instance.Next(0, 100) < nudTasaContagio.Value)
                                                i.estado = Estado.Enfermo;
                                        }
                                        else
                                        {
                                            if (StaticRandom.Instance.Next(0, 100) < nudTasaContagio.Value && StaticRandom.Instance.Next(0, 100) % 10 == 0)
                                                i.estado = Estado.Enfermo;
                                        }
                                    }

                                }
                        }

                        if (i.estado == Estado.Enfermo)
                            i.dias_enfermo++;

                        if (i.dias_enfermo >= nudDiasEnfermo.Value)
                        {
                            if (i.asintomatico == false)
                            {
                                if (StaticRandom.Instance.Next(0, 100) < nudTasaMortalidad.Value)
                                    i.estado = Estado.Muerto;
                                else
                                    i.estado = Estado.Curado;
                            }
                            else
                                i.estado = Estado.Curado;
                            
                            i.dias_enfermo = 0;
                        }

                        if (i.estado == Estado.Sano)
                            sano++;
                        else if (i.estado == Estado.Enfermo)
                            enfermo++;
                        else if (i.estado == Estado.Muerto)
                            muerto++;
                        else if (i.estado == Estado.Curado)
                            curado++;
                    }

                    //Grafica general
                    Graphics G = grafica.CreateGraphics();
                    poblacion = sano + enfermo + muerto + curado;


                    this.SANO = sano;
                    CURADO = curado;
                    ENFERMO = enfermo;
                    MUERTO = muerto;
                    POBLACION = poblacion;

                    float SANO = G.VisibleClipBounds.Bottom * (sano / (float)poblacion);
                    float INFE = G.VisibleClipBounds.Bottom * (enfermo / (float)poblacion);
                    float MUER = G.VisibleClipBounds.Bottom * (muerto / (float)poblacion);
                    float CURA = G.VisibleClipBounds.Bottom * (curado / (float)poblacion);

                    G.DrawLine(new Pen(Color.FromArgb(0, 120, 215)), time % G.VisibleClipBounds.Right, 0, time % G.VisibleClipBounds.Right, SANO);
                    G.DrawLine(new Pen(Brushes.Firebrick), time % G.VisibleClipBounds.Right, SANO, time % G.VisibleClipBounds.Right, SANO + INFE);
                    G.DrawLine(new Pen(Brushes.Black), time % G.VisibleClipBounds.Right, SANO + INFE, time % G.VisibleClipBounds.Right, SANO + INFE + MUER);
                    G.DrawLine(new Pen(Brushes.DarkOliveGreen), time % G.VisibleClipBounds.Right, SANO + INFE + MUER, time % G.VisibleClipBounds.Right, SANO + INFE + MUER + CURA);

                    //Grafica de enfermos
                    G = enfermos.CreateGraphics();
                    G.DrawLine(new Pen(Color.FromArgb(28, 0, 28)), time % G.VisibleClipBounds.Right, 0, time % G.VisibleClipBounds.Right, G.VisibleClipBounds.Bottom);
                    G.DrawLine(new Pen(Brushes.Firebrick), time % G.VisibleClipBounds.Right, G.VisibleClipBounds.Bottom, time % G.VisibleClipBounds.Right, G.VisibleClipBounds.Bottom - G.VisibleClipBounds.Bottom * (enfermo / (float)poblacion));



                    //if (enfermo == 0)
                    //    break;

                    if (proceso == false)
                    { 
                        proceso = true; 
                        break; 
                    }

                    if (kill == true)
                    {  
                        kill = false; 
                        break; 
                    }
                }
                catch { }
            }
        }

        void GraficarMapa()
        {
            while (true)
            {
                try
                {
                    BufferedGraphicsContext espacioBuffer = BufferedGraphicsManager.Current;
                    BufferedGraphics buffer = espacioBuffer.Allocate(g, scene.ClientRectangle);
                    buffer.Graphics.Clear(Color.FromArgb(50, 50, 50));
                    foreach (Individuo i in individuos)
                        if (i != null)
                            i.Dibujar(buffer.Graphics, (int)nudProximidad.Value, cbViewProximidad.Checked);

                    if (cbCuarentena.Checked)
                        foreach (Hogar h in hogares)
                            if (h != null)
                                h.Dibujar(buffer.Graphics);
                    buffer.Render(g);
                }
                catch { }
            }
        }

        private void cbDistanciamientoSocial_CheckedChanged(object sender, EventArgs e)
        {
            nudDistanciamiento.Enabled = !nudDistanciamiento.Enabled;
            if (nudDistanciamiento.Enabled)
                nudDistanciamiento.Value = 60;
            else
                nudDistanciamiento.Value = 0;
        }

        private void cbCuarentena_CheckedChanged(object sender, EventArgs e)
        {
            nudCuarentena.Enabled = !nudCuarentena.Enabled;
            if (nudCuarentena.Enabled)
                nudCuarentena.Value = 100;
            else
                nudCuarentena.Value = 0;
        }

        private void cbHigiene_CheckedChanged(object sender, EventArgs e)
        {
            nudHigiene.Enabled = !nudHigiene.Enabled;
        }

        private void cbAsintomatico_CheckedChanged(object sender, EventArgs e)
        {
            nudAsintomatico.Enabled = !nudAsintomatico.Enabled;
        }

        private void nudPopulation_ValueChanged(object sender, EventArgs e)
        {
            nudInfectedPopulation.Maximum = nudPopulation.Value;
            lblSanos.Text = nudPopulation.Value.ToString();
        }

        private void nudInfectedPopulation_ValueChanged(object sender, EventArgs e)
        {
            lblInfectados.Text = nudInfectedPopulation.Value.ToString();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        int time_graph = 0;

        Task T;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCCPOBzJTlf1u-UMRGMyDXVQ");
        }

        private void scene_Resize(object sender, EventArgs e)
        {
            Graphics g = scene.CreateGraphics();
            foreach (Hogar h in hogares)
                h.Resize(g);
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            MostrarHora();
            g = scene.CreateGraphics();
            H = scene.CreateGraphics();
            time_graph++;


            lblCurados.Text = CURADO.ToString();
            lblInfectados.Text = ENFERMO.ToString();
            lblMuertos.Text = MUERTO.ToString();
            lblSanos.Text = SANO.ToString();
        }
        #region Herramientas
        
        bool kill = false;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (lblInfectados.Text == "0")
                btnRestart_Click(null, null);
            proceso = true;
            clock.Enabled = true;

            T = new Task(Proceso);
            T.Start();
            btnStart.Enabled = false;
            btnPause.Enabled = true;
        }    
            

        
        bool proceso;
        private void btnPause_Click(object sender, EventArgs e)
        {
            proceso = false;
            btnStart.Enabled = true;
            btnPause.Enabled = false;
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            EmpezarSimulacion();
            //clock_Tick(null, null);
            time = 0; time_graph = 0;
            MostrarHora();


            grafica.CreateGraphics().Clear(Color.FromArgb(28, 28, 28));
            enfermos.CreateGraphics().Clear(Color.FromArgb(28, 28, 28));
            scene.CreateGraphics().Clear(Color.FromArgb(50, 50, 50));
        }
       
        private void Principal_Load(object sender, EventArgs e)
        {
            EmpezarSimulacion();
            MostrarHora();

            Task T1 = new Task(GraficarMapa);
            T1.Start();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void scene_DoubleClick(object sender, EventArgs e)
        {
            clock.Enabled = !clock.Enabled;

        }
        #endregion
    }
}
