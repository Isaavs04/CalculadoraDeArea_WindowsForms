namespace CalculoDeArea
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnQuadrado = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnTrapezio = new System.Windows.Forms.Button();
            this.btnLosango = new System.Windows.Forms.Button();
            this.btnRetangulo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAuxiliar = new System.Windows.Forms.Label();
            this.txtVal3 = new System.Windows.Forms.TextBox();
            this.labelNumeroDiv = new System.Windows.Forms.Label();
            this.labelDivisao = new System.Windows.Forms.Label();
            this.labelSinal1 = new System.Windows.Forms.Label();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.txtMed3 = new System.Windows.Forms.TextBox();
            this.txtMed2 = new System.Windows.Forms.TextBox();
            this.txtMed1 = new System.Windows.Forms.TextBox();
            this.picboxImg = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTipoForma = new System.Windows.Forms.Label();
            this.labelAviso = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImg)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnSair.Location = new System.Drawing.Point(667, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(109, 30);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.btnQuadrado);
            this.panel1.Controls.Add(this.btnTriangulo);
            this.panel1.Controls.Add(this.btnCirculo);
            this.panel1.Controls.Add(this.btnTrapezio);
            this.panel1.Controls.Add(this.btnLosango);
            this.panel1.Controls.Add(this.btnRetangulo);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 99);
            this.panel1.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.AliceBlue;
            this.panel8.Location = new System.Drawing.Point(0, 89);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(801, 10);
            this.panel8.TabIndex = 9;
            // 
            // btnQuadrado
            // 
            this.btnQuadrado.BackColor = System.Drawing.Color.Transparent;
            this.btnQuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuadrado.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuadrado.Image = ((System.Drawing.Image)(resources.GetObject("btnQuadrado.Image")));
            this.btnQuadrado.Location = new System.Drawing.Point(659, 3);
            this.btnQuadrado.Name = "btnQuadrado";
            this.btnQuadrado.Size = new System.Drawing.Size(140, 96);
            this.btnQuadrado.TabIndex = 5;
            this.btnQuadrado.UseVisualStyleBackColor = false;
            this.btnQuadrado.Click += new System.EventHandler(this.btnQuadrado_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.BackColor = System.Drawing.Color.Transparent;
            this.btnTriangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriangulo.ForeColor = System.Drawing.Color.Transparent;
            this.btnTriangulo.Image = ((System.Drawing.Image)(resources.GetObject("btnTriangulo.Image")));
            this.btnTriangulo.Location = new System.Drawing.Point(527, 3);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(134, 96);
            this.btnTriangulo.TabIndex = 4;
            this.btnTriangulo.UseVisualStyleBackColor = false;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.BackColor = System.Drawing.Color.Transparent;
            this.btnCirculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCirculo.ForeColor = System.Drawing.Color.Transparent;
            this.btnCirculo.Image = ((System.Drawing.Image)(resources.GetObject("btnCirculo.Image")));
            this.btnCirculo.Location = new System.Drawing.Point(401, 3);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(128, 96);
            this.btnCirculo.TabIndex = 3;
            this.btnCirculo.UseVisualStyleBackColor = false;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnTrapezio
            // 
            this.btnTrapezio.BackColor = System.Drawing.Color.Transparent;
            this.btnTrapezio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrapezio.ForeColor = System.Drawing.Color.Transparent;
            this.btnTrapezio.Image = ((System.Drawing.Image)(resources.GetObject("btnTrapezio.Image")));
            this.btnTrapezio.Location = new System.Drawing.Point(272, 3);
            this.btnTrapezio.Name = "btnTrapezio";
            this.btnTrapezio.Size = new System.Drawing.Size(130, 96);
            this.btnTrapezio.TabIndex = 2;
            this.btnTrapezio.UseVisualStyleBackColor = false;
            this.btnTrapezio.Click += new System.EventHandler(this.btnTrapezio_Click);
            // 
            // btnLosango
            // 
            this.btnLosango.BackColor = System.Drawing.Color.Transparent;
            this.btnLosango.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLosango.ForeColor = System.Drawing.Color.Transparent;
            this.btnLosango.Image = ((System.Drawing.Image)(resources.GetObject("btnLosango.Image")));
            this.btnLosango.Location = new System.Drawing.Point(136, 3);
            this.btnLosango.Name = "btnLosango";
            this.btnLosango.Size = new System.Drawing.Size(138, 96);
            this.btnLosango.TabIndex = 1;
            this.btnLosango.UseVisualStyleBackColor = false;
            this.btnLosango.Click += new System.EventHandler(this.btnLosango_Click);
            // 
            // btnRetangulo
            // 
            this.btnRetangulo.BackColor = System.Drawing.Color.Transparent;
            this.btnRetangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetangulo.ForeColor = System.Drawing.Color.Transparent;
            this.btnRetangulo.Image = ((System.Drawing.Image)(resources.GetObject("btnRetangulo.Image")));
            this.btnRetangulo.Location = new System.Drawing.Point(0, 3);
            this.btnRetangulo.Name = "btnRetangulo";
            this.btnRetangulo.Size = new System.Drawing.Size(138, 96);
            this.btnRetangulo.TabIndex = 0;
            this.btnRetangulo.UseVisualStyleBackColor = false;
            this.btnRetangulo.Click += new System.EventHandler(this.btnRetangulo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.labelAuxiliar);
            this.panel2.Controls.Add(this.txtVal3);
            this.panel2.Controls.Add(this.labelNumeroDiv);
            this.panel2.Controls.Add(this.labelDivisao);
            this.panel2.Controls.Add(this.labelSinal1);
            this.panel2.Controls.Add(this.txtVal2);
            this.panel2.Controls.Add(this.txtVal1);
            this.panel2.Controls.Add(this.txtMed3);
            this.panel2.Controls.Add(this.txtMed2);
            this.panel2.Controls.Add(this.txtMed1);
            this.panel2.Controls.Add(this.picboxImg);
            this.panel2.Location = new System.Drawing.Point(24, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 312);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "(";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Visible = false;
            // 
            // labelAuxiliar
            // 
            this.labelAuxiliar.AutoSize = true;
            this.labelAuxiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuxiliar.Location = new System.Drawing.Point(233, 226);
            this.labelAuxiliar.Name = "labelAuxiliar";
            this.labelAuxiliar.Size = new System.Drawing.Size(22, 16);
            this.labelAuxiliar.TabIndex = 10;
            this.labelAuxiliar.Text = ") X";
            this.labelAuxiliar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelAuxiliar.Visible = false;
            // 
            // txtVal3
            // 
            this.txtVal3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtVal3.Location = new System.Drawing.Point(260, 225);
            this.txtVal3.Name = "txtVal3";
            this.txtVal3.ReadOnly = true;
            this.txtVal3.Size = new System.Drawing.Size(60, 19);
            this.txtVal3.TabIndex = 9;
            this.txtVal3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVal3.Visible = false;
            // 
            // labelNumeroDiv
            // 
            this.labelNumeroDiv.AutoSize = true;
            this.labelNumeroDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDiv.Location = new System.Drawing.Point(147, 264);
            this.labelNumeroDiv.Name = "labelNumeroDiv";
            this.labelNumeroDiv.Size = new System.Drawing.Size(18, 20);
            this.labelNumeroDiv.TabIndex = 8;
            this.labelNumeroDiv.Text = "2";
            this.labelNumeroDiv.Visible = false;
            // 
            // labelDivisao
            // 
            this.labelDivisao.AutoSize = true;
            this.labelDivisao.Location = new System.Drawing.Point(18, 247);
            this.labelDivisao.Name = "labelDivisao";
            this.labelDivisao.Size = new System.Drawing.Size(286, 13);
            this.labelDivisao.TabIndex = 7;
            this.labelDivisao.Text = "---------------------------------------------------------------------------------" +
    "------------";
            this.labelDivisao.Visible = false;
            // 
            // labelSinal1
            // 
            this.labelSinal1.AutoSize = true;
            this.labelSinal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinal1.Location = new System.Drawing.Point(105, 225);
            this.labelSinal1.Name = "labelSinal1";
            this.labelSinal1.Size = new System.Drawing.Size(44, 16);
            this.labelSinal1.TabIndex = 6;
            this.labelSinal1.Text = "label4";
            this.labelSinal1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSinal1.Visible = false;
            // 
            // txtVal2
            // 
            this.txtVal2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtVal2.Location = new System.Drawing.Point(155, 224);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.ReadOnly = true;
            this.txtVal2.Size = new System.Drawing.Size(72, 19);
            this.txtVal2.TabIndex = 5;
            this.txtVal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVal2.Visible = false;
            // 
            // txtVal1
            // 
            this.txtVal1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtVal1.Location = new System.Drawing.Point(27, 224);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.ReadOnly = true;
            this.txtVal1.Size = new System.Drawing.Size(72, 19);
            this.txtVal1.TabIndex = 4;
            this.txtVal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVal1.Visible = false;
            // 
            // txtMed3
            // 
            this.txtMed3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMed3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMed3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtMed3.Location = new System.Drawing.Point(207, 134);
            this.txtMed3.Name = "txtMed3";
            this.txtMed3.ReadOnly = true;
            this.txtMed3.Size = new System.Drawing.Size(80, 22);
            this.txtMed3.TabIndex = 3;
            this.txtMed3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMed3.Visible = false;
            // 
            // txtMed2
            // 
            this.txtMed2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMed2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtMed2.Location = new System.Drawing.Point(108, 171);
            this.txtMed2.Name = "txtMed2";
            this.txtMed2.ReadOnly = true;
            this.txtMed2.Size = new System.Drawing.Size(80, 22);
            this.txtMed2.TabIndex = 2;
            this.txtMed2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMed2.Visible = false;
            // 
            // txtMed1
            // 
            this.txtMed1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMed1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtMed1.Location = new System.Drawing.Point(207, 81);
            this.txtMed1.Name = "txtMed1";
            this.txtMed1.ReadOnly = true;
            this.txtMed1.Size = new System.Drawing.Size(80, 22);
            this.txtMed1.TabIndex = 1;
            this.txtMed1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMed1.Visible = false;
            // 
            // picboxImg
            // 
            this.picboxImg.Image = global::CalculoDeArea.Properties.Resources.triangulo;
            this.picboxImg.Location = new System.Drawing.Point(31, 41);
            this.picboxImg.Name = "picboxImg";
            this.picboxImg.Size = new System.Drawing.Size(219, 124);
            this.picboxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxImg.TabIndex = 0;
            this.picboxImg.TabStop = false;
            this.picboxImg.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.labelTipoForma);
            this.panel3.Controls.Add(this.labelAviso);
            this.panel3.Controls.Add(this.btnResultado);
            this.panel3.Controls.Add(this.txtResultado);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(389, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 284);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // labelTipoForma
            // 
            this.labelTipoForma.AutoSize = true;
            this.labelTipoForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoForma.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelTipoForma.Location = new System.Drawing.Point(3, 9);
            this.labelTipoForma.Name = "labelTipoForma";
            this.labelTipoForma.Size = new System.Drawing.Size(381, 24);
            this.labelTipoForma.TabIndex = 8;
            this.labelTipoForma.Text = "-Pressione a forma que deseja calcular-";
            this.labelTipoForma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAviso.ForeColor = System.Drawing.Color.Red;
            this.labelAviso.Location = new System.Drawing.Point(19, 194);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(342, 20);
            this.labelAviso.TabIndex = 7;
            this.labelAviso.Text = "Todos os números devem ser maiores que 0";
            this.labelAviso.Visible = false;
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.SeaGreen;
            this.btnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnResultado.Location = new System.Drawing.Point(12, 226);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(155, 33);
            this.btnResultado.TabIndex = 5;
            this.btnResultado.Text = "Exibir resultado";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtResultado.Location = new System.Drawing.Point(173, 225);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(192, 31);
            this.txtResultado.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(18, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox3.Location = new System.Drawing.Point(173, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 31);
            this.textBox3.TabIndex = 2;
            this.textBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox2.Location = new System.Drawing.Point(173, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 31);
            this.textBox2.TabIndex = 1;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.Location = new System.Drawing.Point(173, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnLimpar.Location = new System.Drawing.Point(388, 415);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(272, 28);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Location = new System.Drawing.Point(18, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(353, 316);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Location = new System.Drawing.Point(384, 115);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(393, 287);
            this.panel5.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnTrapezio;
        private System.Windows.Forms.Button btnLosango;
        private System.Windows.Forms.Button btnRetangulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnQuadrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtMed3;
        private System.Windows.Forms.TextBox txtMed2;
        private System.Windows.Forms.TextBox txtMed1;
        private System.Windows.Forms.PictureBox picboxImg;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.Label labelSinal1;
        private System.Windows.Forms.Label labelDivisao;
        private System.Windows.Forms.Label labelNumeroDiv;
        private System.Windows.Forms.TextBox txtVal3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAuxiliar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label labelAviso;
        private System.Windows.Forms.Label labelTipoForma;
    }
}

