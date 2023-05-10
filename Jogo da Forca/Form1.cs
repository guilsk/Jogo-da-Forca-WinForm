namespace Jogo_da_Forca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AtivaForca();
            SelecionaPalavra();
        }

        char[] palavraSecreta = null;

        private void SelecionaPalavra()
        {
            Random random = new Random();
            int n = random.Next(palavra.Length);
            palavraSecreta = palavra[n].ToCharArray();
            for (int i = 0; i < palavraSecreta.Length; i++)
            {
                if (i == 0)
                    lb_palavra.Text = "_";
                else
                    lb_palavra.Text += " _";
            }
        }

        int erros = 0;

        string[] palavra = { "ABACATE", "ABACAXI", "ACEROLA", "ACAI", "ARACA", "ABACATE", "BACABA", "BACURI", "BANANA", "CAJA", "CAJU",
                "CARAMBOLA", "CUPUACU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MACA", "MANGABA", "MANGA", "MARACUJA", "MURICI",
                "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA"};

        private void tb_input_letra_KeyPress(object sender, KeyPressEventArgs e)
        {
            string x = lb_palavra.Text.Replace(" ", "");
            string y = null;
            char[] p = x.ToCharArray();

            if (tb_input_letra.Text != "")
            {
                if (e.KeyChar == (char)13)
                {
                    if (ConfereLetras())
                    {
                        for (int i = 0; i < palavraSecreta.Length; i++)
                        {
                            if (tb_input_letra.Text == palavraSecreta[i].ToString())
                            {
                                p[i] = palavraSecreta[i];

                            }
                        }
                        for (int j = 0; j < p.Length; j++)
                            y += p[j].ToString();
                        for (int i = 0; i < palavraSecreta.Length; i++)
                        {
                            if (y[i] == '_' && i == 0)
                                lb_palavra.Text = "_";
                            else if (y[i] == '_')
                                lb_palavra.Text += " _";
                            else if (y[i] != '_' && i == 0)
                                lb_palavra.Text = y[i].ToString();
                            else if (y[i] != '_')
                                lb_palavra.Text += " " + y[i].ToString();

                            if (y == lb_palavra.Text.Replace(" ", "") && !y.Contains('_'))
                                GanhouPerdeu(true);
                        }
                    }
                    else
                    {
                        erros++;
                        AtivaForca();
                    }

                }
                if (!char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;


            tb_input_letra.Text = "";
        }

        private void AtivaForca()
        {
            if (erros == 0) lb_boneco.Text = "//=====\\\\\r\n||        |\r\n||       \r\n||       \r\n||       \r\n||\r\n|| \r\n";
            else if (erros == 1) lb_boneco.Text = "//=====\\\\\r\n||        |\r\n||       O\r\n||       \r\n||       \r\n||\r\n|| \r\n";
            else if (erros == 2) lb_boneco.Text = "//=====\\\\\r\n||        |\r\n||       O\r\n||        |\r\n||       \r\n||\r\n|| \r\n";
            else if (erros == 3) lb_boneco.Text = "//=====\\\\\r\n||        |\r\n||       O\r\n||       /|\\\r\n||       \r\n||\r\n|| \r\n";
            else if (erros == 4) lb_boneco.Text = "//=====\\\\\r\n||        |\r\n||       O\r\n||       /|\\\r\n||       /\r\n||\r\n|| \r\n";
            else if (erros == 5)
            {
                lb_boneco.Text = "//=====\\\\\r\n||        |\r\n||       O\r\n||       /|\\\r\n||       / \\\r\n||\r\n|| \r\n";
                GanhouPerdeu(false);
            }
        }

        private void GanhouPerdeu(bool x)
        {
            if (x) MessageBox.Show("Parabéns você ganhou!");
            else MessageBox.Show("Que pena, deu forca...");
            Close();
        }

        private bool ConfereLetras()
        {
            foreach (char c in palavraSecreta)
                if (c.ToString() == tb_input_letra.Text)
                    return true;
            return false;
        }
    }
}