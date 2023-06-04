using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loggs_dapiton
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        sqlText cn = new sqlText(); 
        private void Category_Load(object sender, EventArgs e)
        {
            
            cn.connect();
            string query = "Select category_ID, category_Name, categoryCode, Description, date_added from categories where archive = 0";

            cn.gridView(gridCategory, query);
        }

        void clear() {
            txtCodeCateg.Text = "";
            txtDescCateg.Text = "";
            txtNameCateg.Text = "";
        
        
        }



        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            cn.connect();
            string query = "Select category_ID, category_Name, categoryCode, Description, date_added from categories where archive = 0";

            cn.gridView(gridCategory, query);
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            cn.connect();
            string save = "Insert into Categories (category_name, categoryCode, Description) values ('" + txtNameCateg.Text +"', '"+ txtCodeCateg.Text+"', '" + txtDescCateg.Text + "')";

            cn.UID(save);
            cn.disc();

            clear();
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            string update = "update Categories set category_name = @CategoryName, categoryCode = @Code, Description = @Description where category_ID = @CategID and archive = 0";

            SqlConnection cnt = new SqlConnection("Data Source=COLA\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
            cnt.Open();
            SqlCommand cmd = new SqlCommand(update, cnt);


            cmd.Parameters.AddWithValue("CategID", Convert.ToInt32(txtCategoryID.Text));
            cmd.Parameters.AddWithValue("CategoryName", txtNameCateg.Text);
            cmd.Parameters.AddWithValue("Code", txtCodeCateg.Text);
            cmd.Parameters.AddWithValue("Description", txtDescCateg.Text);
            cmd.ExecuteNonQuery();
            


            
            cnt.Close();
            MessageBox.Show("Update Success");
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            string update = "update Categories set archive = 1 where category_ID = @CategID";

            SqlConnection cnt = new SqlConnection("Data Source=COLA\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
            cnt.Open();
            SqlCommand cmd = new SqlCommand(update, cnt);


            cmd.Parameters.AddWithValue("CategID", Convert.ToInt32(txtCategoryID.Text));

            cmd.ExecuteNonQuery();




            cnt.Close();
            MessageBox.Show("Delete Success");
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
