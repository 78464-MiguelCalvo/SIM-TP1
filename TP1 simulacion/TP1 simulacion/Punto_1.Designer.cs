
namespace TP1_simulacion
{
    partial class Punto_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.dgTabla = new System.Windows.Forms.DataGridView();
            this.Iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.labbb = new System.Windows.Forms.Label();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMultiplicativo = new System.Windows.Forms.RadioButton();
            this.btnMixto = new System.Windows.Forms.RadioButton();
            this.btonVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabla)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(739, 460);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 30;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click_1);
            // 
            // dgTabla
            // 
            this.dgTabla.AllowUserToAddRows = false;
            this.dgTabla.AllowUserToDeleteRows = false;
            this.dgTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteracion,
            this.Rand});
            this.dgTabla.Location = new System.Drawing.Point(14, 140);
            this.dgTabla.Name = "dgTabla";
            this.dgTabla.Size = new System.Drawing.Size(649, 343);
            this.dgTabla.TabIndex = 29;
            // 
            // Iteracion
            // 
            this.Iteracion.HeaderText = "Iteracion";
            this.Iteracion.Name = "Iteracion";
            // 
            // Rand
            // 
            this.Rand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rand.HeaderText = "Rand";
            this.Rand.Name = "Rand";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(345, 101);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(91, 23);
            this.btnBorrar.TabIndex = 28;
            this.btnBorrar.Text = "Borrar todo";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(225, 101);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(91, 23);
            this.btnGenerar.TabIndex = 27;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.txtM);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtA);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtC);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtG);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtK);
            this.panel2.Controls.Add(this.labbb);
            this.panel2.Controls.Add(this.txtX0);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(225, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 61);
            this.panel2.TabIndex = 32;
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(444, 18);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(36, 20);
            this.txtM.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "m";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(363, 20);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(36, 20);
            this.txtA.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "a";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(290, 20);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(36, 20);
            this.txtC.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "c";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(217, 20);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(36, 20);
            this.txtG.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "g";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(136, 20);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(36, 20);
            this.txtK.TabIndex = 13;
            // 
            // labbb
            // 
            this.labbb.AutoSize = true;
            this.labbb.Location = new System.Drawing.Point(117, 23);
            this.labbb.Name = "labbb";
            this.labbb.Size = new System.Drawing.Size(13, 13);
            this.labbb.TabIndex = 12;
            this.labbb.Text = "k";
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(61, 21);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(36, 20);
            this.txtX0.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnMultiplicativo);
            this.panel1.Controls.Add(this.btnMixto);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 61);
            this.panel1.TabIndex = 31;
            // 
            // btnMultiplicativo
            // 
            this.btnMultiplicativo.AutoSize = true;
            this.btnMultiplicativo.Location = new System.Drawing.Point(96, 21);
            this.btnMultiplicativo.Name = "btnMultiplicativo";
            this.btnMultiplicativo.Size = new System.Drawing.Size(86, 17);
            this.btnMultiplicativo.TabIndex = 2;
            this.btnMultiplicativo.TabStop = true;
            this.btnMultiplicativo.Text = "Multiplicativo";
            this.btnMultiplicativo.UseVisualStyleBackColor = true;
            this.btnMultiplicativo.CheckedChanged += new System.EventHandler(this.btnMultiplicativo_CheckedChanged_1);
            // 
            // btnMixto
            // 
            this.btnMixto.AutoSize = true;
            this.btnMixto.Location = new System.Drawing.Point(25, 21);
            this.btnMixto.Name = "btnMixto";
            this.btnMixto.Size = new System.Drawing.Size(50, 17);
            this.btnMixto.TabIndex = 1;
            this.btnMixto.TabStop = true;
            this.btnMixto.Text = "Mixto";
            this.btnMixto.UseVisualStyleBackColor = true;
            this.btnMixto.CheckedChanged += new System.EventHandler(this.btnMixto_CheckedChanged_1);
            // 
            // btonVolver
            // 
            this.btonVolver.Location = new System.Drawing.Point(14, 489);
            this.btonVolver.Name = "btonVolver";
            this.btonVolver.Size = new System.Drawing.Size(103, 27);
            this.btonVolver.TabIndex = 33;
            this.btonVolver.Text = "Volver al menu";
            this.btonVolver.UseVisualStyleBackColor = true;
            this.btonVolver.Click += new System.EventHandler(this.btonVolver_Click);
            // 
            // Punto_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 520);
            this.Controls.Add(this.btonVolver);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.dgTabla);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGenerar);
            this.Name = "Punto_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto_1";
            this.Load += new System.EventHandler(this.Punto_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTabla)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.DataGridView dgTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rand;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label labbb;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton btnMultiplicativo;
        private System.Windows.Forms.RadioButton btnMixto;
        private System.Windows.Forms.Button btonVolver;
    }
}