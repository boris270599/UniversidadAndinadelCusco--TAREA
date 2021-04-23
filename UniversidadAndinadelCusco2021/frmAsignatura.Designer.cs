
namespace UniversidadAndinadelCusco2021
{
    partial class frmAsignatura
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
            this.btncursos = new System.Windows.Forms.Button();
            this.btndictar = new System.Windows.Forms.Button();
            this.btnescribir = new System.Windows.Forms.Button();
            this.btnleer = new System.Windows.Forms.Button();
            this.txthoras = new System.Windows.Forms.TextBox();
            this.txtcapacidad = new System.Windows.Forms.TextBox();
            this.txtnombredocente = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncursos
            // 
            this.btncursos.Location = new System.Drawing.Point(162, 163);
            this.btncursos.Name = "btncursos";
            this.btncursos.Size = new System.Drawing.Size(75, 23);
            this.btncursos.TabIndex = 23;
            this.btncursos.Text = "Cursos";
            this.btncursos.UseVisualStyleBackColor = true;
            this.btncursos.Click += new System.EventHandler(this.btncursos_Click);
            // 
            // btndictar
            // 
            this.btndictar.Location = new System.Drawing.Point(56, 163);
            this.btndictar.Name = "btndictar";
            this.btndictar.Size = new System.Drawing.Size(75, 23);
            this.btndictar.TabIndex = 22;
            this.btndictar.Text = "Dictar";
            this.btndictar.UseVisualStyleBackColor = true;
            this.btndictar.Click += new System.EventHandler(this.btndictar_Click);
            // 
            // btnescribir
            // 
            this.btnescribir.Location = new System.Drawing.Point(289, 79);
            this.btnescribir.Name = "btnescribir";
            this.btnescribir.Size = new System.Drawing.Size(75, 23);
            this.btnescribir.TabIndex = 21;
            this.btnescribir.Text = "Escribir";
            this.btnescribir.UseVisualStyleBackColor = true;
            this.btnescribir.Click += new System.EventHandler(this.btnescribir_Click);
            // 
            // btnleer
            // 
            this.btnleer.Location = new System.Drawing.Point(289, 35);
            this.btnleer.Name = "btnleer";
            this.btnleer.Size = new System.Drawing.Size(75, 23);
            this.btnleer.TabIndex = 20;
            this.btnleer.Text = "Leer";
            this.btnleer.UseVisualStyleBackColor = true;
            this.btnleer.Click += new System.EventHandler(this.btnleer_Click);
            // 
            // txthoras
            // 
            this.txthoras.Location = new System.Drawing.Point(138, 99);
            this.txthoras.Name = "txthoras";
            this.txthoras.Size = new System.Drawing.Size(100, 20);
            this.txthoras.TabIndex = 19;
            // 
            // txtcapacidad
            // 
            this.txtcapacidad.Location = new System.Drawing.Point(138, 72);
            this.txtcapacidad.Name = "txtcapacidad";
            this.txtcapacidad.Size = new System.Drawing.Size(100, 20);
            this.txtcapacidad.TabIndex = 18;
            // 
            // txtnombredocente
            // 
            this.txtnombredocente.Location = new System.Drawing.Point(138, 45);
            this.txtnombredocente.Name = "txtnombredocente";
            this.txtnombredocente.Size = new System.Drawing.Size(100, 20);
            this.txtnombredocente.TabIndex = 17;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(138, 18);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Horas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Capacidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre Docente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // frmAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 232);
            this.Controls.Add(this.btncursos);
            this.Controls.Add(this.btndictar);
            this.Controls.Add(this.btnescribir);
            this.Controls.Add(this.btnleer);
            this.Controls.Add(this.txthoras);
            this.Controls.Add(this.txtcapacidad);
            this.Controls.Add(this.txtnombredocente);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAsignatura";
            this.Text = "frmAsignatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncursos;
        private System.Windows.Forms.Button btndictar;
        private System.Windows.Forms.Button btnescribir;
        private System.Windows.Forms.Button btnleer;
        private System.Windows.Forms.TextBox txthoras;
        private System.Windows.Forms.TextBox txtcapacidad;
        private System.Windows.Forms.TextBox txtnombredocente;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}