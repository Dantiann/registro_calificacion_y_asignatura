namespace NotasForm1
{
    partial class frmEstudiantes
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
            this.lblCalificaciones = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtAsignatura = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.IstEstudiantes = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCalificaciones
            // 
            this.lblCalificaciones.AutoSize = true;
            this.lblCalificaciones.Font = new System.Drawing.Font("Cascadia Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificaciones.ForeColor = System.Drawing.Color.Teal;
            this.lblCalificaciones.Location = new System.Drawing.Point(269, 18);
            this.lblCalificaciones.Name = "lblCalificaciones";
            this.lblCalificaciones.Size = new System.Drawing.Size(300, 45);
            this.lblCalificaciones.TabIndex = 0;
            this.lblCalificaciones.Text = "CALIFICACIONES";
            this.lblCalificaciones.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.Color.Teal;
            this.lblNombres.Location = new System.Drawing.Point(12, 95);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(96, 27);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.Teal;
            this.lblApellidos.Location = new System.Drawing.Point(12, 138);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(120, 27);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignatura.ForeColor = System.Drawing.Color.Teal;
            this.lblAsignatura.Location = new System.Drawing.Point(12, 182);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(132, 27);
            this.lblAsignatura.TabIndex = 3;
            this.lblAsignatura.Text = "Asignatura";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota1.ForeColor = System.Drawing.Color.Teal;
            this.lblNota1.Location = new System.Drawing.Point(12, 230);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(84, 27);
            this.lblNota1.TabIndex = 4;
            this.lblNota1.Text = "Nota 1";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota2.ForeColor = System.Drawing.Color.Teal;
            this.lblNota2.Location = new System.Drawing.Point(12, 280);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(84, 27);
            this.lblNota2.TabIndex = 5;
            this.lblNota2.Text = "Nota 2";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota3.ForeColor = System.Drawing.Color.Teal;
            this.lblNota3.Location = new System.Drawing.Point(12, 327);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(84, 27);
            this.lblNota3.TabIndex = 6;
            this.lblNota3.Text = "Nota 3";
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.Azure;
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.DarkRed;
            this.txtNombres.Location = new System.Drawing.Point(147, 88);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(333, 24);
            this.txtNombres.TabIndex = 7;
            this.txtNombres.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.Azure;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.DarkRed;
            this.txtApellidos.Location = new System.Drawing.Point(147, 131);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(333, 24);
            this.txtApellidos.TabIndex = 8;
            this.txtApellidos.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAsignatura
            // 
            this.txtAsignatura.BackColor = System.Drawing.Color.Azure;
            this.txtAsignatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAsignatura.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsignatura.ForeColor = System.Drawing.Color.DarkRed;
            this.txtAsignatura.Location = new System.Drawing.Point(147, 175);
            this.txtAsignatura.Name = "txtAsignatura";
            this.txtAsignatura.Size = new System.Drawing.Size(333, 24);
            this.txtAsignatura.TabIndex = 9;
            this.txtAsignatura.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNota1
            // 
            this.txtNota1.BackColor = System.Drawing.Color.Azure;
            this.txtNota1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNota1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota1.ForeColor = System.Drawing.Color.DarkRed;
            this.txtNota1.Location = new System.Drawing.Point(147, 226);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(333, 24);
            this.txtNota1.TabIndex = 10;
            this.txtNota1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtNota2
            // 
            this.txtNota2.BackColor = System.Drawing.Color.Azure;
            this.txtNota2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNota2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota2.ForeColor = System.Drawing.Color.DarkRed;
            this.txtNota2.Location = new System.Drawing.Point(147, 273);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(333, 24);
            this.txtNota2.TabIndex = 11;
            this.txtNota2.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtNota3
            // 
            this.txtNota3.BackColor = System.Drawing.Color.Azure;
            this.txtNota3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNota3.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota3.ForeColor = System.Drawing.Color.DarkRed;
            this.txtNota3.Location = new System.Drawing.Point(147, 320);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(333, 24);
            this.txtNota3.TabIndex = 12;
            this.txtNota3.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // IstEstudiantes
            // 
            this.IstEstudiantes.BackColor = System.Drawing.Color.Azure;
            this.IstEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IstEstudiantes.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IstEstudiantes.ForeColor = System.Drawing.Color.Teal;
            this.IstEstudiantes.FormattingEnabled = true;
            this.IstEstudiantes.ItemHeight = 27;
            this.IstEstudiantes.Location = new System.Drawing.Point(502, 84);
            this.IstEstudiantes.Name = "IstEstudiantes";
            this.IstEstudiantes.Size = new System.Drawing.Size(582, 270);
            this.IstEstudiantes.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(219, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1141, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IstEstudiantes);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtAsignatura);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.lblAsignatura);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblCalificaciones);
            this.Name = "frmEstudiantes";
            this.Text = "Estudiantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalificaciones;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtAsignatura;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.ListBox IstEstudiantes;
        private System.Windows.Forms.Button button1;
    }
}

