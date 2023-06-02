using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loggs_dapiton
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        sqlText dbCn = new sqlText();

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            string add = "insert into product (productName, productDesc, quantity) values('" + txtProductName.Text + "', '" + txtDesc.Text + "', '" + Convert.ToInt32(txtQuantity.Text) + "')";
            dbCn.connect();
            dbCn.UID(add);
            dbCn.disc();
            MessageBox.Show("Success Saved");
            
        }
    }
}
