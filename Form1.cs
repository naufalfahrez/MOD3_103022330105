namespace _103022330105_Naufal_Fahreza
{
    public partial class Form1 : Form
    {
        int hasil  =  0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = $"{hasil}";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
            hasil += 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
            hasil += 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
            hasil += 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
            hasil += 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
            hasil += 7;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
            hasil += 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
            hasil += 3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
            hasil += 6;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
            hasil += 8;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
            hasil += 9;
        }
    }
}
