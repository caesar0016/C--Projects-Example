

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


                studentInfo s1 = new studentInfo(Convert.ToInt32(txtStudentId.Text), txtFirstName.Text,txtLastName.Text);
                studentInfo s2 = new studentInfo(Convert.ToInt32(txtStudentId.Text), txtFirstName.Text);

                if (txtLastName.Text.Equals(null))
                {
                    txtLastName.Text = " ";
                    listStudentID.Items.Add(s2.IDStudent);
                    listFirst01Name.Items.Add(s2.fName);


                }
                else {

                    listStudentID.Items.Add(s1.IDStudent);
                    listLastName.Items.Add(s1.lName);
                    listFirst01Name.Items.Add(s1.fName);
                }

                

                txtStudentId.Text = "";
                txtLastName.Text = "";
                txtFirstName.Text = "";

            }
            catch (Exception ex) //handles Exepction
            {

                MessageBox.Show("Invalid Input... Pls Try Again");
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