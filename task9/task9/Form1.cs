namespace task9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            progressBar1.Value = 0;
            timer1.Interval = 50;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            labelseriya.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            labelfin.Text = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            labelsoyad.Text = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            labelad.Text = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            labelataadi.Text = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            labelcins.Text = textBox6.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            labeldoğumtarixi.Text = textBox7.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            labeldoğumyeri.Text = textBox8.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            labelaile.Text = textBox9.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            labelverilme.Text = textBox10.Text;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            labeletibarli.Text = textBox11.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) ||
                string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text) || string.IsNullOrEmpty(textBox9.Text) ||
                string.IsNullOrEmpty(textBox10.Text) || string.IsNullOrEmpty(textBox11.Text) || string.IsNullOrEmpty(textBox12.Text))
            {
                MessageBox.Show("Bütün xanaları doldurun!", "Xeberdarliq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
            }
            else
            {
                timer1.Stop();

                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text) || string.IsNullOrEmpty(textBox9.Text) || string.IsNullOrEmpty(textBox10.Text) || string.IsNullOrEmpty(textBox11.Text))
                {
                    DialogResult cavab = MessageBox.Show("Melumatlar tam daxil edilmeyib!", "Xeberdarliq", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (cavab == DialogResult.OK)
                    {
                        progressBar1.Visible = false;
                    }
                }
                else
                {
                    DialogResult cavab = MessageBox.Show("Yadda saxlandi", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (cavab == DialogResult.OK)
                    {
                        progressBar1.Visible = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();

            labelseriya.Text = "";
            labelsoyad.Text = "";
            labelad.Text = "";
            labelataadi.Text = "";
            labeldoğumtarixi.Text = "";
            labeldoğumyeri.Text = "";
            labelcins.Text = "";
            labelaile.Text = "";
            labelfin.Text = "";
            labelverilme.Text = "";
            labeletibarli.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG Fayllari|*.png";
            ofd.Title = "Zehmet olmasa yalniz PNG formatinda sekil secin";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }

        }
    }
}
