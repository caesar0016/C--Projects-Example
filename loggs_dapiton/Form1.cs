using System.Collections;
using System.Data.SqlClient;

namespace loggs_dapiton
{
    public partial class Form1 : Form
    {
        sqlText dbCon = new sqlText();

        public Form1()
        {
            InitializeComponent();
        }


        private void loginBttn_Click(object sender, EventArgs e){

            SqlConnection con = new SqlConnection("Data Source=COLA\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from admin";
            SqlDataReader dr = cmd.ExecuteReader();



            if (dr.Read()){

                
                if (txtUser.Text == (dr["userName"].ToString()) && txtPass.Text == (dr["pass"].ToString()))
                {

                    
                    txtUser.Text = "";
                    txtPass.Text = "";

                    //Product p1 = new Product();
                    //p1.Show();

                    Main m1 = new Main();
                    m1.Show();



                }
                else
                {

                    MessageBox.Show("Login Failed");
                }



            }
            else
            {


                MessageBox.Show("No data found, create account pls");

            }






            dbCon.disc();


            }

        private void txtFill_Click(object sender, EventArgs e)
        {
            txtUser.Text = "user";
            txtPass.Text = "admin";
        }
    }
    }