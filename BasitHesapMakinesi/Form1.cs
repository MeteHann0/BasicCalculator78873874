namespace BasitHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int pos = richTextBox1.SelectionStart;
            richTextBox1.Text = richTextBox1.Text.Insert(pos, "( )");
            richTextBox1.SelectionStart = pos + 1;
        }


        private void button15_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(richTextBox1.Text);
            double y = x / 100;
            richTextBox1.Text = y.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a = 7;
            richTextBox1.Text = richTextBox1.Text + a.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int b = 8;
            richTextBox1.Text = richTextBox1.Text + b.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int c = 9;
            richTextBox1.Text = richTextBox1.Text + c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int d = 4;
            richTextBox1.Text = richTextBox1.Text + d.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int f = 5;
            richTextBox1.Text = richTextBox1.Text + f.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int g = 6;
            richTextBox1.Text = richTextBox1.Text + g.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int h = 1;
            richTextBox1.Text = richTextBox1.Text + h.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 2;
            richTextBox1.Text = richTextBox1.Text + i.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int j = 3;
            richTextBox1.Text = richTextBox1.Text + j.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int k = 0;
            richTextBox1.Text = richTextBox1.Text + k.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string divide = "÷";
            richTextBox1.Text = richTextBox1.Text + divide;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string multiply = "×";
            richTextBox1.Text = richTextBox1.Text + multiply;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            string subtract = "-";
            richTextBox1.Text = richTextBox1.Text + subtract;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            string sum = "+";
            richTextBox1.Text = richTextBox1.Text + sum;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string dot = ".";
            richTextBox1.Text = richTextBox1.Text + dot;
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            string expression = richTextBox1.Text;


            expression = expression.Replace("×", "*");
            expression = expression.Replace("÷", "/");

            try
            {
                var result = new System.Data.DataTable().Compute(expression, null);
                richTextBox1.Text = result.ToString();
            }
            catch
            {
                richTextBox1.Text = "Error!";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            buttonEqual_Click(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}
