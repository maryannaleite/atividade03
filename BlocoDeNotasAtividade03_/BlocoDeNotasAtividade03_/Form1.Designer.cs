namespace BlocoDeNotasAtividade03_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAbrir = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            buttonSalvar = new Button();
            buttonEncriptar = new Button();
            buttonDesecriptar = new Button();
            SuspendLayout();
            // 
            // buttonAbrir
            // 
            buttonAbrir.BackColor = SystemColors.Control;
            buttonAbrir.ForeColor = Color.MediumVioletRed;
            buttonAbrir.Location = new Point(12, 1);
            buttonAbrir.Name = "buttonAbrir";
            buttonAbrir.Size = new Size(77, 36);
            buttonAbrir.TabIndex = 0;
            buttonAbrir.Text = "Abrir";
            buttonAbrir.UseVisualStyleBackColor = false;
            buttonAbrir.Click += buttonAbrir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(364, 12);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 115);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(800, 410);
            textBox1.TabIndex = 3;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = SystemColors.Control;
            buttonSalvar.ForeColor = Color.MediumVioletRed;
            buttonSalvar.Location = new Point(95, 1);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(80, 36);
            buttonSalvar.TabIndex = 4;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonEncriptar
            // 
            buttonEncriptar.ForeColor = Color.MediumVioletRed;
            buttonEncriptar.Location = new Point(181, 1);
            buttonEncriptar.Name = "buttonEncriptar";
            buttonEncriptar.Size = new Size(87, 36);
            buttonEncriptar.TabIndex = 5;
            buttonEncriptar.Text = "Encriptar";
            buttonEncriptar.UseVisualStyleBackColor = true;
            buttonEncriptar.Click += button1_Click;
            // 
            // buttonDesecriptar
            // 
            buttonDesecriptar.ForeColor = Color.MediumVioletRed;
            buttonDesecriptar.Location = new Point(274, 2);
            buttonDesecriptar.Name = "buttonDesecriptar";
            buttonDesecriptar.Size = new Size(84, 35);
            buttonDesecriptar.TabIndex = 6;
            buttonDesecriptar.Text = "Desecriptar";
            buttonDesecriptar.UseVisualStyleBackColor = true;
            buttonDesecriptar.Click += buttonDencript_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDesecriptar);
            Controls.Add(buttonEncriptar);
            Controls.Add(buttonSalvar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(buttonAbrir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAbrir;
        private Label label1;
        private TextBox textBox1;
        private Button buttonSalvar;
        private Button buttonEncriptar;
        private Button buttonDesecriptar;
    }
}
