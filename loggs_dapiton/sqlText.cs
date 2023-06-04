using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace loggs_dapiton
{
    internal class sqlText
    {
        public SqlConnection cn = new SqlConnection();
        
        public void connect() {


            try {

                string cnDapiton = "Data Source=COLA\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True";
                cn.Close();
                cn.ConnectionString = cnDapiton;
                cn.Open();
               

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            
            }

           
        }//end of connect method

        

        public void disc() {
            
            cn.Dispose();
        
        }//end of disc

        public void UID(string query) {

            try {

                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Close();
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            
            }

        }//end of Cmdquery

        public void gridView(DataGridView dataGridView, string query) { //needs dataGrid name, query and tbl name

            cn.Close();
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            dataGridView.DataSource = dt;
            cn.Close();

        
        }


    }
}
