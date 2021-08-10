
namespace Csharp1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.dt_pk_fecha = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rd_php = new System.Windows.Forms.RadioButton();
            this.rd_java = new System.Windows.Forms.RadioButton();
            this.rd_python = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_spanish = new System.Windows.Forms.RadioButton();
            this.rd_english = new System.Windows.Forms.RadioButton();
            this.rd_french = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Controls.Add(this.tab3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1254, 619);
            this.tabControl1.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.btn_enviar);
            this.tab1.Controls.Add(this.maskedTextBox1);
            this.tab1.Controls.Add(this.groupBox2);
            this.tab1.Controls.Add(this.comboBox1);
            this.tab1.Controls.Add(this.dt_pk_fecha);
            this.tab1.Controls.Add(this.txt_apellido);
            this.tab1.Controls.Add(this.txt_nombre);
            this.tab1.Controls.Add(this.groupBox1);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.label4);
            this.tab1.Controls.Add(this.label6);
            this.tab1.Controls.Add(this.label5);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Controls.Add(this.label1);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(1246, 593);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Pestaña 1";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(1246, 593);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Pestaña 2";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // tab3
            // 
            this.tab3.Location = new System.Drawing.Point(4, 22);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(1246, 593);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "Pestaña 3";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1240, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título Pestaña 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha de Nacimiento:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(727, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Apellido:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_python);
            this.groupBox1.Controls.Add(this.rd_java);
            this.groupBox1.Controls.Add(this.rd_php);
            this.groupBox1.Location = new System.Drawing.Point(623, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 223);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lenguaje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Provincia:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nombre
            // 
            this.txt_nombre.CausesValidation = false;
            this.txt_nombre.Location = new System.Drawing.Point(209, 101);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(317, 31);
            this.txt_nombre.TabIndex = 3;
            // 
            // txt_apellido
            // 
            this.txt_apellido.CausesValidation = false;
            this.txt_apellido.Location = new System.Drawing.Point(828, 101);
            this.txt_apellido.Multiline = true;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(317, 31);
            this.txt_apellido.TabIndex = 3;
            // 
            // dt_pk_fecha
            // 
            this.dt_pk_fecha.Location = new System.Drawing.Point(337, 240);
            this.dt_pk_fecha.MaxDate = new System.DateTime(2021, 8, 9, 21, 5, 15, 0);
            this.dt_pk_fecha.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dt_pk_fecha.Name = "dt_pk_fecha";
            this.dt_pk_fecha.Size = new System.Drawing.Size(200, 20);
            this.dt_pk_fecha.TabIndex = 4;
            this.dt_pk_fecha.Value = new System.DateTime(2021, 8, 9, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Buenos Aires",
            "Córdoba",
            "Santa Fe",
            "La Pampa",
            "Jujuy",
            "Salta",
            "Tucumán",
            "Santa Cruz"});
            this.comboBox1.Location = new System.Drawing.Point(223, 342);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // rd_php
            // 
            this.rd_php.AutoSize = true;
            this.rd_php.Location = new System.Drawing.Point(78, 52);
            this.rd_php.Name = "rd_php";
            this.rd_php.Size = new System.Drawing.Size(47, 17);
            this.rd_php.TabIndex = 6;
            this.rd_php.TabStop = true;
            this.rd_php.Text = "PHP";
            this.rd_php.UseVisualStyleBackColor = true;
            // 
            // rd_java
            // 
            this.rd_java.AutoSize = true;
            this.rd_java.Location = new System.Drawing.Point(78, 98);
            this.rd_java.Name = "rd_java";
            this.rd_java.Size = new System.Drawing.Size(48, 17);
            this.rd_java.TabIndex = 6;
            this.rd_java.TabStop = true;
            this.rd_java.Text = "Java";
            this.rd_java.UseVisualStyleBackColor = true;
            // 
            // rd_python
            // 
            this.rd_python.AutoSize = true;
            this.rd_python.Location = new System.Drawing.Point(78, 147);
            this.rd_python.Name = "rd_python";
            this.rd_python.Size = new System.Drawing.Size(58, 17);
            this.rd_python.TabIndex = 6;
            this.rd_python.TabStop = true;
            this.rd_python.Text = "Python";
            this.rd_python.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rd_french);
            this.groupBox2.Controls.Add(this.rd_english);
            this.groupBox2.Controls.Add(this.rd_spanish);
            this.groupBox2.Location = new System.Drawing.Point(879, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 223);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Idioma";
            // 
            // rd_spanish
            // 
            this.rd_spanish.AutoSize = true;
            this.rd_spanish.Location = new System.Drawing.Point(20, 52);
            this.rd_spanish.Name = "rd_spanish";
            this.rd_spanish.Size = new System.Drawing.Size(63, 17);
            this.rd_spanish.TabIndex = 0;
            this.rd_spanish.TabStop = true;
            this.rd_spanish.Text = "Español";
            this.rd_spanish.UseVisualStyleBackColor = true;
            // 
            // rd_english
            // 
            this.rd_english.AutoSize = true;
            this.rd_english.Location = new System.Drawing.Point(20, 98);
            this.rd_english.Name = "rd_english";
            this.rd_english.Size = new System.Drawing.Size(53, 17);
            this.rd_english.TabIndex = 0;
            this.rd_english.TabStop = true;
            this.rd_english.Text = "Inglés";
            this.rd_english.UseVisualStyleBackColor = true;
            // 
            // rd_french
            // 
            this.rd_french.AutoSize = true;
            this.rd_french.Location = new System.Drawing.Point(20, 147);
            this.rd_french.Name = "rd_french";
            this.rd_french.Size = new System.Drawing.Size(63, 17);
            this.rd_french.TabIndex = 0;
            this.rd_french.TabStop = true;
            this.rd_french.Text = "Francés";
            this.rd_french.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Teléfono:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(228, 457);
            this.maskedTextBox1.Mask = "(99) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(103, 20);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_enviar.Location = new System.Drawing.Point(866, 505);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(279, 47);
            this.btn_enviar.TabIndex = 8;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 619);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_pk_fecha;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rd_python;
        private System.Windows.Forms.RadioButton rd_java;
        private System.Windows.Forms.RadioButton rd_php;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_french;
        private System.Windows.Forms.RadioButton rd_english;
        private System.Windows.Forms.RadioButton rd_spanish;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_enviar;
    }
}

