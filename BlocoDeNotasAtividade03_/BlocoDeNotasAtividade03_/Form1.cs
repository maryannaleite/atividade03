namespace BlocoDeNotasAtividade03_
{
    public partial class Form1 : Form
    {
        string filename { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var result = ofd.ShowDialog(this);
            filename = ofd.FileName;
            if (result == DialogResult.OK)
            {
                string text = File.ReadAllText(filename);
                textBox1.Text = text;
                label1.Text = filename;
            }
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filename, textBox1.Text);
        }

        private string encript(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                result += (char)(c + 4);
            }
            return result;
        }
        private string dencript(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                result += (char)(c - 4);
            }
            return result;
        }

        private void buttonEncript_Click(object sender, EventArgs e)
        {
            textBox1.Text = encript(textBox1.Text);
        }

        private void buttonDencript_Click(object sender, EventArgs e)
        {
            textBox1.Text = dencript(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filename))
            { 
                SaveFileDialog sfd = new SaveFileDialog();
                var result = sfd.ShowDialog(this); 
                if (result != DialogResult.OK) return; 

                filename = sfd.FileName; 
                if (!File.Exists(filename)) File.Create(filename); 
            }
            File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Arquivo salvo com sucesso.");
        }
    }
}

