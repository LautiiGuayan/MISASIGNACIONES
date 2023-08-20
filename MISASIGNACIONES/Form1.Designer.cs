namespace MISASIGNACIONES
{
    partial class Form1
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
            this.L1 = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.PictureBox();
            this.L2 = new System.Windows.Forms.Label();
            this.T1 = new System.Windows.Forms.TextBox();
            this.L3 = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.legajo1 = new System.Windows.Forms.Label();
            this.legajo = new System.Windows.Forms.Label();
            this.consulta = new System.Windows.Forms.Label();
            this.dia = new System.Windows.Forms.Label();
            this.L5 = new System.Windows.Forms.Label();
            this.cerrar = new System.Windows.Forms.Button();
            this.DIA1 = new System.Windows.Forms.Label();
            this.dia2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).BeginInit();
            this.SuspendLayout();
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.Location = new System.Drawing.Point(458, 9);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(325, 37);
            this.L1.TabIndex = 0;
            this.L1.Text = "MIS ASIGNACIONES";
            // 
            // P1
            // 
            this.P1.Image = global::MISASIGNACIONES.Properties.Resources.Sin_título;
            this.P1.Location = new System.Drawing.Point(388, 205);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(437, 234);
            this.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P1.TabIndex = 1;
            this.P1.TabStop = false;
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.Location = new System.Drawing.Point(522, 46);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(172, 29);
            this.L2.TabIndex = 2;
            this.L2.Text = "¡BIENVENIDO!";
            // 
            // T1
            // 
            this.T1.Location = new System.Drawing.Point(475, 118);
            this.T1.Multiline = true;
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(252, 28);
            this.T1.TabIndex = 3;
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L3.Location = new System.Drawing.Point(416, 83);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(386, 16);
            this.L3.TabIndex = 4;
            this.L3.Text = "Consulta tus horarios de trabajo solamente ingresando tu legajo";
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(445, 163);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(301, 36);
            this.B1.TabIndex = 5;
            this.B1.Text = "Ver horarios";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button1_Click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(18, 396);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(167, 43);
            this.B2.TabIndex = 6;
            this.B2.Text = "VOLVER";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Visible = false;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // legajo1
            // 
            this.legajo1.AutoSize = true;
            this.legajo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legajo1.Location = new System.Drawing.Point(12, 37);
            this.legajo1.Name = "legajo1";
            this.legajo1.Size = new System.Drawing.Size(110, 33);
            this.legajo1.TabIndex = 7;
            this.legajo1.Text = "Legajo:";
            this.legajo1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.legajo1.Visible = false;
            // 
            // legajo
            // 
            this.legajo.AutoSize = true;
            this.legajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legajo.Location = new System.Drawing.Point(128, 45);
            this.legajo.Name = "legajo";
            this.legajo.Size = new System.Drawing.Size(0, 24);
            this.legajo.TabIndex = 8;
            this.legajo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // consulta
            // 
            this.consulta.AutoSize = true;
            this.consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consulta.Location = new System.Drawing.Point(14, 75);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(190, 24);
            this.consulta.TabIndex = 9;
            this.consulta.Text = "Fecha de la consulta:";
            this.consulta.Visible = false;
            // 
            // dia
            // 
            this.dia.AutoSize = true;
            this.dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dia.Location = new System.Drawing.Point(210, 75);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(90, 24);
            this.dia.TabIndex = 10;
            this.dia.Text = "20/8/2023";
            this.dia.Visible = false;
            // 
            // L5
            // 
            this.L5.AutoSize = true;
            this.L5.Location = new System.Drawing.Point(15, 101);
            this.L5.Name = "L5";
            this.L5.Size = new System.Drawing.Size(72, 13);
            this.L5.TabIndex = 11;
            this.L5.Text = "asignaciones:";
            this.L5.Visible = false;
            // 
            // cerrar
            // 
            this.cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar.Location = new System.Drawing.Point(191, 396);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(167, 43);
            this.cerrar.TabIndex = 12;
            this.cerrar.Text = "CERRAR";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Visible = false;
            this.cerrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DIA1
            // 
            this.DIA1.AutoSize = true;
            this.DIA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIA1.Location = new System.Drawing.Point(12, 139);
            this.DIA1.Name = "DIA1";
            this.DIA1.Size = new System.Drawing.Size(144, 24);
            this.DIA1.TabIndex = 13;
            this.DIA1.Text = "VIERNES 25/8";
            this.DIA1.Visible = false;
            // 
            // dia2
            // 
            this.dia2.AutoSize = true;
            this.dia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dia2.ForeColor = System.Drawing.Color.Red;
            this.dia2.Location = new System.Drawing.Point(15, 163);
            this.dia2.Name = "dia2";
            this.dia2.Size = new System.Drawing.Size(325, 16);
            this.dia2.TabIndex = 14;
            this.dia2.Text = "De:12:30 A 17:30                 108-BK Buen Pastor";
            this.dia2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(837, 451);
            this.Controls.Add(this.dia2);
            this.Controls.Add(this.DIA1);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.L5);
            this.Controls.Add(this.dia);
            this.Controls.Add(this.consulta);
            this.Controls.Add(this.legajo);
            this.Controls.Add(this.legajo1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.L1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.OrangeRed;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.P1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.PictureBox P1;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.TextBox T1;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Label legajo1;
        private System.Windows.Forms.Label legajo;
        private System.Windows.Forms.Label consulta;
        private System.Windows.Forms.Label dia;
        private System.Windows.Forms.Label L5;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Label DIA1;
        private System.Windows.Forms.Label dia2;
    }
}

