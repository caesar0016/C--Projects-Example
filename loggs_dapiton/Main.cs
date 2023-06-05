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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void bttnCategory_click(object sender, EventArgs e)
        {
            Category c1 = new Category();
            c1.Show();
            this.Hide();
        }

        private void bttnProduct_Click(object sender, EventArgs e)
        {
            
          //  this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product p1 = new Product();
            p1.TopLevel = false;
            panel3.Controls.Add(p1);
            p1.BringToFront();
            p1.Show();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category c1 = new Category();
            c1.TopLevel = false;
            panel3.Controls.Add(c1);
            c1.BringToFront();
            c1.Show();
        }
    }
}
