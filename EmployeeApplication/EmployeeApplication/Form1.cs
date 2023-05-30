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


                Employee emp1 = new Employee(Convert.ToInt32(txtEmployeedID.Text), txtFirstName.Text, txtLastName.Text, txtPosition.Text);
                Employee emp2 = new Employee(Convert.ToInt32(txtEmployeedID.Text), txtFirstName.Text, txtLastName.Text);

                string[] addRows = { emp1.encapEmpID.ToString(), emp1.encapfirstName, emp1.encaplastName, emp1.encapPosition };


                if (txtPosition.Equals(null || "")) {

                    string[] addRows02 = { emp2.encapEmpID.ToString(), emp2.encapfirstName, emp2.encaplastName };

                    gridViewData.Rows.Add(addRows02);

                }
                gridViewData.Rows.Add(addRows02);


                txtEmployeedID.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtPosition.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Try again in Employee ID");
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