

namespace studentInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnSubmit_Click(object sender, EventArgs e)
        {
            try
            {


                studentInfo s1 = new studentInfo(Convert.ToInt32(txtStudentId.Text), txtLastName.Text, txtFirstName.Text);

                string name = "Hello, World";


                listStudentID.Items.Add(s1.IDStudent);
                listFirstName.Items.Add(s1.fName);
                listLastName.Items.Add(s1.lName);

                txtStudentId.Text = "";
                txtLastName.Text = "";
                txtFirstName.Text = "";

            }
            catch (Exception) //handles Exepction
            {

                MessageBox.Show("Input Invalid Pls try Again");
                txtStudentId.Text = "";
                txtLastName.Text = "";
                txtFirstName.Text = "";



            }
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            txtStudentId.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
        }
    }
}