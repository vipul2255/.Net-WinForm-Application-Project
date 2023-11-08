namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Int32 ans = 0;
        string st = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(st))
                st += textBox1.Text.ToString();
            else
                st += " + " + textBox1.Text.ToString();
            ans += Convert.ToInt32(textBox1.Text);
            label2.Text = st;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(st))
                st += textBox1.Text.ToString();
            else
                st += " - " + textBox1.Text.ToString();
            ans -= Convert.ToInt32(textBox1.Text);
            label2.Text = st;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(st))
                st += textBox1.Text.ToString();
            else
                st += " * " + textBox1.Text.ToString();
            if(ans!=0)
                ans *= Convert.ToInt32(textBox1.Text);
            else
                
            label2.Text = st;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(st))
                st += textBox1.Text.ToString();
            else
                st += " / " + textBox1.Text.ToString();
            if(textBox1.Text == null)
                MessageBox.Show("Invalid division");
            else
            {
                ans /= Convert.ToInt32(textBox1.Text);
                label2.Text = st;
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = ans.ToString();
            int ind = st.Length-2;
            // st = st.Remove(ind, 2);
            st += " = " + ans.ToString();
            label2.Text = st;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ans = 0;
            st = "";
            label2.Text = st;
            label3.Text = "Answer";
        }
    }
}