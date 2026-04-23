using System.Windows.Forms;

namespace Project_CIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double total = 0;
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double total = 0;


            if (checkBox5.Checked)
                total += 10.00;
            if (checkBox6.Checked)
                total += 30.00;
            if (checkBox7.Checked)
                total += 19.00;
            if (checkBox6.Checked)
                total += 30.00;
            if (checkBox7.Checked)
                total += 19.00;
            if (checkBox8.Checked)
                total += 10.00;

            label2.Text = "Total: $" + total.ToString("0.00");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Thank you for placing your order");

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You owe us " + total.ToString("0.00"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

