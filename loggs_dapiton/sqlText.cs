using System.Data.SqlClient;


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




    }
}
