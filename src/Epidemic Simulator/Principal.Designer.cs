namespace Epidemic_Simulator
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.scene = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSanos = new System.Windows.Forms.Label();
            this.lblInfectados = new System.Windows.Forms.Label();
            this.lblCurados = new System.Windows.Forms.Label();
            this.lblMuertos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nudInfectedPopulation = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudPopulation = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudAsintomatico = new System.Windows.Forms.NumericUpDown();
            this.cbAsintomatico = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.nudHigiene = new System.Windows.Forms.NumericUpDown();
            this.nudCuarentena = new System.Windows.Forms.NumericUpDown();
            this.cbHigiene = new System.Windows.Forms.CheckBox();
            this.cbCuarentena = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbViewProximidad = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.nudDiasEnfermo = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.nudProximidad = new System.Windows.Forms.NumericUpDown();
            this.nudTasaMortalidad = new System.Windows.Forms.NumericUpDown();
            this.nudTasaContagio = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grafica = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.enfermos = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nudDistanciamiento = new System.Windows.Forms.NumericUpDown();
            this.cbDistanciamientoSocial = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInfectedPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPopulation)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAsintomatico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigiene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuarentena)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasEnfermo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProximidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTasaMortalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTasaContagio)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistanciamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // clock
            // 
            this.clock.Interval = 1;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // scene
            // 
            this.scene.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.scene.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scene.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.scene.Location = new System.Drawing.Point(16, 15);
            this.scene.Margin = new System.Windows.Forms.Padding(4);
            this.scene.Name = "scene";
            this.scene.Size = new System.Drawing.Size(539, 352);
            this.scene.TabIndex = 0;
            this.scene.DoubleClick += new System.EventHandler(this.scene_DoubleClick);
            this.scene.Resize += new System.EventHandler(this.scene_Resize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Infected:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Healthy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dead:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cured:";
            // 
            // lblSanos
            // 
            this.lblSanos.AutoSize = true;
            this.lblSanos.Location = new System.Drawing.Point(251, 39);
            this.lblSanos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSanos.Name = "lblSanos";
            this.lblSanos.Size = new System.Drawing.Size(40, 17);
            this.lblSanos.TabIndex = 5;
            this.lblSanos.Text = "1000";
            // 
            // lblInfectados
            // 
            this.lblInfectados.AutoSize = true;
            this.lblInfectados.Location = new System.Drawing.Point(251, 55);
            this.lblInfectados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfectados.Name = "lblInfectados";
            this.lblInfectados.Size = new System.Drawing.Size(16, 17);
            this.lblInfectados.TabIndex = 6;
            this.lblInfectados.Text = "1";
            // 
            // lblCurados
            // 
            this.lblCurados.AutoSize = true;
            this.lblCurados.Location = new System.Drawing.Point(251, 71);
            this.lblCurados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurados.Name = "lblCurados";
            this.lblCurados.Size = new System.Drawing.Size(16, 17);
            this.lblCurados.TabIndex = 7;
            this.lblCurados.Text = "0";
            // 
            // lblMuertos
            // 
            this.lblMuertos.AutoSize = true;
            this.lblMuertos.Location = new System.Drawing.Point(251, 87);
            this.lblMuertos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMuertos.Name = "lblMuertos";
            this.lblMuertos.Size = new System.Drawing.Size(16, 17);
            this.lblMuertos.TabIndex = 8;
            this.lblMuertos.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.nudInfectedPopulation);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nudPopulation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMuertos);
            this.groupBox1.Controls.Add(this.lblCurados);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblInfectados);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSanos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(564, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(312, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Population Data";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 65);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Infected population:";
            // 
            // nudInfectedPopulation
            // 
            this.nudInfectedPopulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudInfectedPopulation.Location = new System.Drawing.Point(13, 85);
            this.nudInfectedPopulation.Margin = new System.Windows.Forms.Padding(4);
            this.nudInfectedPopulation.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudInfectedPopulation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInfectedPopulation.Name = "nudInfectedPopulation";
            this.nudInfectedPopulation.Size = new System.Drawing.Size(124, 22);
            this.nudInfectedPopulation.TabIndex = 11;
            this.nudInfectedPopulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudInfectedPopulation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInfectedPopulation.ValueChanged += new System.EventHandler(this.nudInfectedPopulation_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Initial population:";
            // 
            // nudPopulation
            // 
            this.nudPopulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPopulation.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPopulation.Location = new System.Drawing.Point(13, 37);
            this.nudPopulation.Margin = new System.Windows.Forms.Padding(4);
            this.nudPopulation.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPopulation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPopulation.Name = "nudPopulation";
            this.nudPopulation.Size = new System.Drawing.Size(124, 22);
            this.nudPopulation.TabIndex = 9;
            this.nudPopulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPopulation.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPopulation.ValueChanged += new System.EventHandler(this.nudPopulation_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.nudDistanciamiento);
            this.groupBox2.Controls.Add(this.cbDistanciamientoSocial);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nudAsintomatico);
            this.groupBox2.Controls.Add(this.cbAsintomatico);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.nudHigiene);
            this.groupBox2.Controls.Add(this.nudCuarentena);
            this.groupBox2.Controls.Add(this.cbHigiene);
            this.groupBox2.Controls.Add(this.cbCuarentena);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(564, 224);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(312, 144);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Population Settings";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "%";
            // 
            // nudAsintomatico
            // 
            this.nudAsintomatico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAsintomatico.Enabled = false;
            this.nudAsintomatico.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAsintomatico.Location = new System.Drawing.Point(216, 103);
            this.nudAsintomatico.Margin = new System.Windows.Forms.Padding(4);
            this.nudAsintomatico.Name = "nudAsintomatico";
            this.nudAsintomatico.Size = new System.Drawing.Size(72, 22);
            this.nudAsintomatico.TabIndex = 16;
            this.nudAsintomatico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAsintomatico.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cbAsintomatico
            // 
            this.cbAsintomatico.AutoSize = true;
            this.cbAsintomatico.Location = new System.Drawing.Point(8, 104);
            this.cbAsintomatico.Margin = new System.Windows.Forms.Padding(4);
            this.cbAsintomatico.Name = "cbAsintomatico";
            this.cbAsintomatico.Size = new System.Drawing.Size(146, 21);
            this.cbAsintomatico.TabIndex = 15;
            this.cbAsintomatico.Text = "Asymptomatic rate";
            this.cbAsintomatico.UseVisualStyleBackColor = true;
            this.cbAsintomatico.CheckedChanged += new System.EventHandler(this.cbAsintomatico_CheckedChanged);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(289, 81);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 17);
            this.label21.TabIndex = 14;
            this.label21.Text = "%";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(289, 51);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 17);
            this.label20.TabIndex = 13;
            this.label20.Text = "%";
            // 
            // nudHigiene
            // 
            this.nudHigiene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudHigiene.Enabled = false;
            this.nudHigiene.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHigiene.Location = new System.Drawing.Point(216, 76);
            this.nudHigiene.Margin = new System.Windows.Forms.Padding(4);
            this.nudHigiene.Name = "nudHigiene";
            this.nudHigiene.Size = new System.Drawing.Size(72, 22);
            this.nudHigiene.TabIndex = 6;
            this.nudHigiene.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHigiene.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // nudCuarentena
            // 
            this.nudCuarentena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCuarentena.Enabled = false;
            this.nudCuarentena.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCuarentena.Location = new System.Drawing.Point(216, 49);
            this.nudCuarentena.Margin = new System.Windows.Forms.Padding(4);
            this.nudCuarentena.Name = "nudCuarentena";
            this.nudCuarentena.Size = new System.Drawing.Size(72, 22);
            this.nudCuarentena.TabIndex = 5;
            this.nudCuarentena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbHigiene
            // 
            this.cbHigiene.AutoSize = true;
            this.cbHigiene.Location = new System.Drawing.Point(8, 77);
            this.cbHigiene.Margin = new System.Windows.Forms.Padding(4);
            this.cbHigiene.Name = "cbHigiene";
            this.cbHigiene.Size = new System.Drawing.Size(82, 21);
            this.cbHigiene.TabIndex = 3;
            this.cbHigiene.Text = "Hygiene";
            this.cbHigiene.UseVisualStyleBackColor = true;
            this.cbHigiene.CheckedChanged += new System.EventHandler(this.cbHigiene_CheckedChanged);
            // 
            // cbCuarentena
            // 
            this.cbCuarentena.AutoSize = true;
            this.cbCuarentena.Location = new System.Drawing.Point(8, 51);
            this.cbCuarentena.Margin = new System.Windows.Forms.Padding(4);
            this.cbCuarentena.Name = "cbCuarentena";
            this.cbCuarentena.Size = new System.Drawing.Size(101, 21);
            this.cbCuarentena.TabIndex = 2;
            this.cbCuarentena.Text = "Quarantine";
            this.cbCuarentena.UseVisualStyleBackColor = true;
            this.cbCuarentena.CheckedChanged += new System.EventHandler(this.cbCuarentena_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbViewProximidad);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.nudDiasEnfermo);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.nudProximidad);
            this.groupBox3.Controls.Add(this.nudTasaMortalidad);
            this.groupBox3.Controls.Add(this.nudTasaContagio);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(564, 375);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(312, 134);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Disease Settings";
            // 
            // cbViewProximidad
            // 
            this.cbViewProximidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbViewProximidad.AutoSize = true;
            this.cbViewProximidad.Location = new System.Drawing.Point(293, 78);
            this.cbViewProximidad.Margin = new System.Windows.Forms.Padding(4);
            this.cbViewProximidad.Name = "cbViewProximidad";
            this.cbViewProximidad.Size = new System.Drawing.Size(18, 17);
            this.cbViewProximidad.TabIndex = 15;
            this.cbViewProximidad.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 100);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(107, 17);
            this.label25.TabIndex = 19;
            this.label25.Text = "Time Units sick:";
            // 
            // nudDiasEnfermo
            // 
            this.nudDiasEnfermo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDiasEnfermo.Location = new System.Drawing.Point(216, 97);
            this.nudDiasEnfermo.Margin = new System.Windows.Forms.Padding(4);
            this.nudDiasEnfermo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDiasEnfermo.Name = "nudDiasEnfermo";
            this.nudDiasEnfermo.Size = new System.Drawing.Size(72, 22);
            this.nudDiasEnfermo.TabIndex = 18;
            this.nudDiasEnfermo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDiasEnfermo.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Proximity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Contagion rate:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Deathly rate:";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(291, 50);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 17);
            this.label23.TabIndex = 16;
            this.label23.Text = "%";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(291, 26);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 17);
            this.label24.TabIndex = 15;
            this.label24.Text = "%";
            // 
            // nudProximidad
            // 
            this.nudProximidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudProximidad.Location = new System.Drawing.Point(216, 73);
            this.nudProximidad.Margin = new System.Windows.Forms.Padding(4);
            this.nudProximidad.Name = "nudProximidad";
            this.nudProximidad.Size = new System.Drawing.Size(72, 22);
            this.nudProximidad.TabIndex = 9;
            this.nudProximidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudProximidad.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // nudTasaMortalidad
            // 
            this.nudTasaMortalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTasaMortalidad.Location = new System.Drawing.Point(216, 48);
            this.nudTasaMortalidad.Margin = new System.Windows.Forms.Padding(4);
            this.nudTasaMortalidad.Name = "nudTasaMortalidad";
            this.nudTasaMortalidad.Size = new System.Drawing.Size(72, 22);
            this.nudTasaMortalidad.TabIndex = 8;
            this.nudTasaMortalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTasaMortalidad.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudTasaContagio
            // 
            this.nudTasaContagio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTasaContagio.Location = new System.Drawing.Point(216, 23);
            this.nudTasaContagio.Margin = new System.Windows.Forms.Padding(4);
            this.nudTasaContagio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTasaContagio.Name = "nudTasaContagio";
            this.nudTasaContagio.Size = new System.Drawing.Size(72, 22);
            this.nudTasaContagio.TabIndex = 7;
            this.nudTasaContagio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTasaContagio.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Epidemic_Simulator.Properties.Resources.question;
            this.button1.Location = new System.Drawing.Point(143, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 39);
            this.button1.TabIndex = 19;
            this.toolTip1.SetToolTip(this.button1, "Information");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Image = global::Epidemic_Simulator.Properties.Resources.play_button;
            this.btnStart.Location = new System.Drawing.Point(1, 23);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(43, 39);
            this.btnStart.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnStart, "Start");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Enabled = false;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = global::Epidemic_Simulator.Properties.Resources.pause_button;
            this.btnPause.Location = new System.Drawing.Point(52, 23);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(43, 39);
            this.btnPause.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnPause, "Pause");
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Image = global::Epidemic_Simulator.Properties.Resources.reload_button;
            this.btnRestart.Location = new System.Drawing.Point(95, 23);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(43, 39);
            this.btnRestart.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnRestart, "Restart");
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(269, 36);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(16, 17);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "0";
            this.toolTip1.SetToolTip(this.lblTime, "Time");
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(189, 36);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(79, 17);
            this.label26.TabIndex = 15;
            this.label26.Text = "Time Units:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grafica);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 127);
            this.panel1.TabIndex = 18;
            // 
            // grafica
            // 
            this.grafica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grafica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grafica.Location = new System.Drawing.Point(0, 17);
            this.grafica.Margin = new System.Windows.Forms.Padding(4);
            this.grafica.Name = "grafica";
            this.grafica.Size = new System.Drawing.Size(262, 110);
            this.grafica.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "General population;";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 375);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 135);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.enfermos);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(274, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 127);
            this.panel2.TabIndex = 19;
            // 
            // enfermos
            // 
            this.enfermos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enfermos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enfermos.Location = new System.Drawing.Point(0, 17);
            this.enfermos.Margin = new System.Windows.Forms.Padding(4);
            this.enfermos.Name = "enfermos";
            this.enfermos.Size = new System.Drawing.Size(262, 110);
            this.enfermos.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Sick population:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btnStart);
            this.groupBox4.Controls.Add(this.lblTime);
            this.groupBox4.Controls.Add(this.btnPause);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.btnRestart);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(564, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(312, 74);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Simulation Settings";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(564, 517);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 0);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(289, 25);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "%";
            // 
            // nudDistanciamiento
            // 
            this.nudDistanciamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDistanciamiento.Enabled = false;
            this.nudDistanciamiento.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDistanciamiento.Location = new System.Drawing.Point(216, 23);
            this.nudDistanciamiento.Margin = new System.Windows.Forms.Padding(4);
            this.nudDistanciamiento.Name = "nudDistanciamiento";
            this.nudDistanciamiento.Size = new System.Drawing.Size(72, 22);
            this.nudDistanciamiento.TabIndex = 21;
            this.nudDistanciamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbDistanciamientoSocial
            // 
            this.cbDistanciamientoSocial.AutoSize = true;
            this.cbDistanciamientoSocial.Location = new System.Drawing.Point(8, 25);
            this.cbDistanciamientoSocial.Margin = new System.Windows.Forms.Padding(4);
            this.cbDistanciamientoSocial.Name = "cbDistanciamientoSocial";
            this.cbDistanciamientoSocial.Size = new System.Drawing.Size(101, 21);
            this.cbDistanciamientoSocial.TabIndex = 20;
            this.cbDistanciamientoSocial.Text = "Quarantine";
            this.cbDistanciamientoSocial.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(892, 526);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.scene);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(907, 563);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disease simulator";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInfectedPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPopulation)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAsintomatico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigiene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuarentena)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasEnfermo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProximidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTasaMortalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTasaContagio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistanciamiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Panel scene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSanos;
        private System.Windows.Forms.Label lblInfectados;
        private System.Windows.Forms.Label lblCurados;
        private System.Windows.Forms.Label lblMuertos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudHigiene;
        private System.Windows.Forms.NumericUpDown nudCuarentena;
        private System.Windows.Forms.CheckBox cbHigiene;
        private System.Windows.Forms.CheckBox cbCuarentena;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudProximidad;
        private System.Windows.Forms.NumericUpDown nudTasaMortalidad;
        private System.Windows.Forms.NumericUpDown nudTasaContagio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown nudDiasEnfermo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.CheckBox cbViewProximidad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel grafica;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel enfermos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudPopulation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudAsintomatico;
        private System.Windows.Forms.CheckBox cbAsintomatico;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudInfectedPopulation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudDistanciamiento;
        private System.Windows.Forms.CheckBox cbDistanciamientoSocial;
    }
}

