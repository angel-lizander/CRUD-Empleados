namespace CRUD_Empleados.Vistas
{
    partial class Actualizar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.txtapellido);
            this.groupBox1.Controls.Add(this.txtcedula);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleados";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(209, 195);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(128, 195);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(68, 72);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(184, 20);
            this.txtapellido.TabIndex = 8;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(68, 103);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(184, 20);
            this.txtcedula.TabIndex = 7;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(68, 132);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(184, 20);
            this.txtdireccion.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(68, 36);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(184, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtidempleado
            // 
            this.txtidempleado.Location = new System.Drawing.Point(205, 39);
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.Size = new System.Drawing.Size(100, 20);
            this.txtidempleado.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(31, 42);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(148, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Introduzca el ID del empleado";
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 357);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtidempleado);
            this.Controls.Add(this.groupBox1);
            this.Name = "Actualizar";
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.Actualizar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidempleado;
        private System.Windows.Forms.Label label;
    }
}