namespace DataTypeApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
       


        }

        private void nextForm01_Click(object sender, EventArgs e)
        {
           

            try
            {
                Form2 f1 = new Form2();
                f1.Show();
                short setShort = Convert.ToInt16(getShort.Text);
                int setInt = Convert.ToInt32(getInt.Text);
                long setLong = Convert.ToInt64(getLong.Text);
                double setDouble = Convert.ToDouble(getDouble.Text);
                char setChar = Convert.ToChar(getChar.Text);

                f1.answer01.Text = setShort.ToString();
                f1.answer02.Text = setInt.ToString();
                f1.answer03.Text = setLong.ToString();
                f1.answer04.Text = setDouble.ToString();
                f1.answer05.Text = setChar.ToString();


            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void print01_Click(object sender, EventArgs e)
        {
           

        }

        private void getInt_TextChanged(object sender, EventArgs e)
        {

        }

        private void getDouble_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

//short int long double char