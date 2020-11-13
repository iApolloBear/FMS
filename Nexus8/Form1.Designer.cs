namespace Nexus8
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.radioArchivo = new System.Windows.Forms.RadioButton();
            this.radioLine = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.labelLine = new System.Windows.Forms.Label();
            this.textLine = new System.Windows.Forms.TextBox();
            this.buttonArch = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Entrada";
            // 
            // radioArchivo
            // 
            this.radioArchivo.AutoSize = true;
            this.radioArchivo.Location = new System.Drawing.Point(23, 45);
            this.radioArchivo.Name = "radioArchivo";
            this.radioArchivo.Size = new System.Drawing.Size(61, 17);
            this.radioArchivo.TabIndex = 1;
            this.radioArchivo.TabStop = true;
            this.radioArchivo.Text = "Archivo";
            this.radioArchivo.UseVisualStyleBackColor = true;
            this.radioArchivo.CheckedChanged += new System.EventHandler(this.radioArchivo_CheckedChanged);
            // 
            // radioLine
            // 
            this.radioLine.AutoSize = true;
            this.radioLine.Location = new System.Drawing.Point(124, 45);
            this.radioLine.Name = "radioLine";
            this.radioLine.Size = new System.Drawing.Size(103, 17);
            this.radioLine.TabIndex = 2;
            this.radioLine.TabStop = true;
            this.radioLine.Text = "Linea de Prueba";
            this.radioLine.UseVisualStyleBackColor = true;
            this.radioLine.CheckedChanged += new System.EventHandler(this.radioLine_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mostrar FSM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Location = new System.Drawing.Point(20, 127);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(33, 13);
            this.labelLine.TabIndex = 4;
            this.labelLine.Text = "Linea";
            this.labelLine.Visible = false;
            // 
            // textLine
            // 
            this.textLine.Location = new System.Drawing.Point(79, 124);
            this.textLine.Name = "textLine";
            this.textLine.Size = new System.Drawing.Size(100, 20);
            this.textLine.TabIndex = 5;
            this.textLine.Visible = false;
            // 
            // buttonArch
            // 
            this.buttonArch.Location = new System.Drawing.Point(67, 122);
            this.buttonArch.Name = "buttonArch";
            this.buttonArch.Size = new System.Drawing.Size(75, 23);
            this.buttonArch.TabIndex = 6;
            this.buttonArch.Text = "Abrir Archivo";
            this.buttonArch.UseVisualStyleBackColor = true;
            this.buttonArch.Visible = false;
            this.buttonArch.Click += new System.EventHandler(this.buttonArch_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(245, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(423, 433);
            this.listBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Caracteres Validos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "0";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(690, 15);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(336, 498);
            this.listBox2.TabIndex = 10;
            this.listBox2.Visible = false;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Estados Finales:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "0";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(48, 165);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(112, 35);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "Encontrar Patrones";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(245, 15);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(439, 498);
            this.listBox3.TabIndex = 14;
            this.listBox3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 533);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonArch);
            this.Controls.Add(this.textLine);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioLine);
            this.Controls.Add(this.radioArchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioArchivo;
        private System.Windows.Forms.RadioButton radioLine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.TextBox textLine;
        private System.Windows.Forms.Button buttonArch;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ListBox listBox3;

    }
}

