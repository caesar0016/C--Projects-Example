using System.Collections;
using System.Data.SqlClient;

namespace loggs_dapiton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void loginBttn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=COLA\\SQLEXPRESS;Initial Catalog=person;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();

            cmd.Connection = con;
            cmd.CommandText = "select * from loggs";
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                if (userBox.Text.Equals(dr["userName"].ToString()) && passBox.Text.Equals(dr["password01"].ToString()))
                {

                    //  MessageBox.Show("You did it my boii");


                    string userNameString = dr["userName"].ToString();
                    comboUser.Items.Add(userNameString);



                }
                else
                {
                    MessageBox.Show("Its okay mahhh bro...");
                }
            }
            con.Close();
        }



    }
}