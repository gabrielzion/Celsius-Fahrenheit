namespace Celsius_Fahrenheit
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblConverter = new System.Windows.Forms.Label();
            this.lblConvertido = new System.Windows.Forms.Label();
            this.cboTipoConversao = new System.Windows.Forms.ComboBox();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.txtConvertido = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor";
            // 
            // lblConverter
            // 
            this.lblConverter.AutoSize = true;
            this.lblConverter.Location = new System.Drawing.Point(165, 100);
            this.lblConverter.Name = "lblConverter";
            this.lblConverter.Size = new System.Drawing.Size(103, 13);
            this.lblConverter.TabIndex = 1;
            this.lblConverter.Text = "Valor para converter";
            // 
            // lblConvertido
            // 
            this.lblConvertido.AutoSize = true;
            this.lblConvertido.Location = new System.Drawing.Point(165, 211);
            this.lblConvertido.Name = "lblConvertido";
            this.lblConvertido.Size = new System.Drawing.Size(84, 13);
            this.lblConvertido.TabIndex = 2;
            this.lblConvertido.Text = "Valor convertido";
            // 
            // cboTipoConversao
            // 
            this.cboTipoConversao.FormattingEnabled = true;
            this.cboTipoConversao.Items.AddRange(new object[] {
            "Celsius --> Fahrenheit",
            "Fahrenheit --> Celsius"});
            this.cboTipoConversao.Location = new System.Drawing.Point(168, 156);
            this.cboTipoConversao.Name = "cboTipoConversao";
            this.cboTipoConversao.Size = new System.Drawing.Size(121, 21);
            this.cboTipoConversao.TabIndex = 3;
            this.cboTipoConversao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(412, 93);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(100, 20);
            this.txtOriginal.TabIndex = 4;
            this.txtOriginal.TextChanged += new System.EventHandler(this.txtOriginal_TextChanged);
            // 
            // txtConvertido
            // 
            this.txtConvertido.Location = new System.Drawing.Point(412, 208);
            this.txtConvertido.Name = "txtConvertido";
            this.txtConvertido.Size = new System.Drawing.Size(100, 20);
            this.txtConvertido.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtConvertido);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.cboTipoConversao);
            this.Controls.Add(this.lblConvertido);
            this.Controls.Add(this.lblConverter);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConverter;
        private System.Windows.Forms.Label lblConvertido;
        private System.Windows.Forms.ComboBox cboTipoConversao;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.TextBox txtConvertido;
        private System.Windows.Forms.Button button1;
    }
}

