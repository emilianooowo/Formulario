namespace Formulario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.TB_Apellido = new System.Windows.Forms.TextBox();
            this.TB_Edad = new System.Windows.Forms.TextBox();
            this.TB_Estatura = new System.Windows.Forms.TextBox();
            this.TB_Telefono = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.RDB_Hombre = new System.Windows.Forms.RadioButton();
            this.RDB_Mujer = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GENERO = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estatura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(121, 27);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(127, 22);
            this.TB_Nombre.TabIndex = 5;
            // 
            // TB_Apellido
            // 
            this.TB_Apellido.Location = new System.Drawing.Point(121, 67);
            this.TB_Apellido.Name = "TB_Apellido";
            this.TB_Apellido.Size = new System.Drawing.Size(127, 22);
            this.TB_Apellido.TabIndex = 6;
            // 
            // TB_Edad
            // 
            this.TB_Edad.Location = new System.Drawing.Point(121, 107);
            this.TB_Edad.Name = "TB_Edad";
            this.TB_Edad.Size = new System.Drawing.Size(127, 22);
            this.TB_Edad.TabIndex = 7;
            // 
            // TB_Estatura
            // 
            this.TB_Estatura.Location = new System.Drawing.Point(121, 150);
            this.TB_Estatura.Name = "TB_Estatura";
            this.TB_Estatura.Size = new System.Drawing.Size(127, 22);
            this.TB_Estatura.TabIndex = 8;
            // 
            // TB_Telefono
            // 
            this.TB_Telefono.Location = new System.Drawing.Point(121, 190);
            this.TB_Telefono.Name = "TB_Telefono";
            this.TB_Telefono.Size = new System.Drawing.Size(127, 22);
            this.TB_Telefono.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(40, 317);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 30);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(171, 317);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(77, 30);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // RDB_Hombre
            // 
            this.RDB_Hombre.AutoSize = true;
            this.RDB_Hombre.Location = new System.Drawing.Point(8, 23);
            this.RDB_Hombre.Name = "RDB_Hombre";
            this.RDB_Hombre.Size = new System.Drawing.Size(77, 20);
            this.RDB_Hombre.TabIndex = 12;
            this.RDB_Hombre.TabStop = true;
            this.RDB_Hombre.Text = "Hombre";
            this.RDB_Hombre.UseVisualStyleBackColor = true;
            // 
            // RDB_Mujer
            // 
            this.RDB_Mujer.AutoSize = true;
            this.RDB_Mujer.Location = new System.Drawing.Point(131, 23);
            this.RDB_Mujer.Name = "RDB_Mujer";
            this.RDB_Mujer.Size = new System.Drawing.Size(61, 20);
            this.RDB_Mujer.TabIndex = 13;
            this.RDB_Mujer.TabStop = true;
            this.RDB_Mujer.Text = "Mujer";
            this.RDB_Mujer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GENERO);
            this.panel1.Controls.Add(this.RDB_Mujer);
            this.panel1.Controls.Add(this.RDB_Hombre);
            this.panel1.Location = new System.Drawing.Point(40, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 72);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GENERO
            // 
            this.GENERO.AutoSize = true;
            this.GENERO.Location = new System.Drawing.Point(0, 0);
            this.GENERO.Name = "GENERO";
            this.GENERO.Size = new System.Drawing.Size(52, 16);
            this.GENERO.TabIndex = 14;
            this.GENERO.Text = "Genero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 361);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.TB_Telefono);
            this.Controls.Add(this.TB_Estatura);
            this.Controls.Add(this.TB_Edad);
            this.Controls.Add(this.TB_Apellido);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.TextBox TB_Apellido;
        private System.Windows.Forms.TextBox TB_Edad;
        private System.Windows.Forms.TextBox TB_Estatura;
        private System.Windows.Forms.TextBox TB_Telefono;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.RadioButton RDB_Hombre;
        private System.Windows.Forms.RadioButton RDB_Mujer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label GENERO;
    }
}

