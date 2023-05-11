using System.Data;
using System.Data.SqlClient;

namespace nothingToPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void regButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=COLA\\SQLEXPRESS;Initial Catalog=person;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("insert into product_tbl values (@productCode, @name, @color, @location )", con); //@mean it points the actual variable name in sql

            con.Open();

            cmd.Parameters.AddWithValue("@productCode", int.Parse(codeBox.Text));
            cmd.Parameters.AddWithValue("@name", nameBox.Text); //nameBox pass the variable to the @name in sql same with the others
            cmd.Parameters.AddWithValue("@color", colorBox.Text);
            cmd.Parameters.AddWithValue("@location", locationBox.Text);
            
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Insert Success");

        }

        private void updateBttn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=COLA\\SQLEXPRESS;Initial Catalog=person;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("update product_tbl set nameBox = @name, colorBox = @color, locationBox = @location where codeBox = @productCode");

            
            cmd.Parameters.AddWithValue("@name", nameBox.Text);
            cmd.Parameters.AddWithValue("@color", colorBox.Text);
            cmd.Parameters.AddWithValue("@location", locationBox.Text);

            con.Close();

            MessageBox.Show("Update Success");
        }

        private void srchBttn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=COLA\\SQLEXPRESS;Initial Catalog=person;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from product_tbl", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;







        }
    }
}