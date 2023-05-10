namespace Jogo_da_Forca
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
            panel1 = new Panel();
            label2 = new Label();
            tb_input_letra = new TextBox();
            lb_palavra = new Label();
            lb_boneco = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tb_input_letra);
            panel1.Controls.Add(lb_palavra);
            panel1.Controls.Add(lb_boneco);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 426);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 354);
            label2.Name = "label2";
            label2.Size = new Size(301, 45);
            label2.TabIndex = 3;
            label2.Text = "Digite sua tentativa:";
            // 
            // tb_input_letra
            // 
            tb_input_letra.BackColor = SystemColors.GrayText;
            tb_input_letra.CharacterCasing = CharacterCasing.Upper;
            tb_input_letra.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            tb_input_letra.Location = new Point(307, 349);
            tb_input_letra.Name = "tb_input_letra";
            tb_input_letra.Size = new Size(32, 50);
            tb_input_letra.TabIndex = 2;
            tb_input_letra.KeyPress += tb_input_letra_KeyPress;
            // 
            // lb_palavra
            // 
            lb_palavra.AutoSize = true;
            lb_palavra.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lb_palavra.Location = new Point(39, 270);
            lb_palavra.Name = "lb_palavra";
            lb_palavra.Size = new Size(137, 45);
            lb_palavra.TabIndex = 1;
            lb_palavra.Text = "_________";
            // 
            // lb_boneco
            // 
            lb_boneco.AutoSize = true;
            lb_boneco.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lb_boneco.Location = new Point(3, 0);
            lb_boneco.Name = "lb_boneco";
            lb_boneco.Size = new Size(192, 315);
            lb_boneco.TabIndex = 0;
            lb_boneco.Text = "//==\\\\\r\n||        |\r\n||       O\r\n||       /|\\\r\n||       / \\\r\n||\r\n|| ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(376, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Jogo da Forca";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lb_palavra;
        private Label lb_boneco;
        private Label label2;
        private TextBox tb_input_letra;
    }
}