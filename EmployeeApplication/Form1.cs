namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            txtEmployeedID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPosition.Text = "";
        }

        private void bttnFill_Click(object sender, EventArgs e)
        {
            txtEmployeedID.Text = "2052";
            txtFirstName.Text = "Naruto";
            txtLastName.Text = "Uzumaki";
            txtPosition.Text = "Hokage";
        }

        private void bttnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable the submit button to prevent multiple submissions
                bttnSubmit.Enabled = false;

                Employee emp1 = new Employee(Convert.ToInt32(txtEmployeedID.Text), txtFirstName.Text, txtLastName.Text, txtPosition.Text);
                Employee emp2 = new Employee(Convert.ToInt32(txtEmployeedID.Text), txtFirstName.Text, txtLastName.Text);

                string[] addRowsEmp1 = {emp1.encapfirstName, emp1.encaplastName};
                addRowsEmp1 = new string[]{ emp1.encapEmpID.ToString(), emp1.encapfirstName, emp1.encaplastName, emp1.encapPosition };
                
                gridViewData.Rows.Add(addRowsEmp1);
                

                txtEmployeedID.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtPosition.Text = "";
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Try again in Employee ID");
            }
            finally
            {
                // Enable the submit button again after the operation is completed
                bttnSubmit.Enabled = true;
            }



        }
        void showGrid() { //shows the grid upon loading in loader

            gridViewData.Columns.Add("EmployeeID", "Employee ID");
            gridViewData.Columns.Add("FirstName", "First Name");
            gridViewData.Columns.Add("LastName", "last Name");
            gridViewData.Columns.Add("Position", "Position");


        }

        private void frmEmployeeDatabase_Load(object sender, EventArgs e) //loads the grid
        {
            showGrid();
        }
    }

}