using System.Collections;
using System.Windows.Forms;

namespace dapitonForm01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerBttn_Click(object sender, EventArgs e)
        {
            string gender01 = "";

            if (maleRadio.Checked)
            {

                gender01 = "Male";

            }
            else if (femaleRadio.Checked)                       //Student Name: Gender: Date of Birth: Program: 2. S and P 3. FirstName, middleName, program
            {

                gender01 = "Female";

            }
            else
            {

                gender01 = "N/A";

            }


            string firstName = firstNameBox.Text;
            string middleName = middleNameBox.Text;
            string lastName = lastNameBox.Text;
            string program = programsCombo.SelectedItem.ToString();
            string date = dayCombo.SelectedItem.ToString() + "/" + monthCombo.SelectedItem.ToString() + "/" + yearCombo.SelectedItem.ToString();



            string show01 = message01(firstName, middleName, lastName, gender01, date, program);
            string show02 = message02(firstName, middleName, lastName, program);
            string show03 = message03(firstName, lastName, program);

            MessageBox.Show(show01);
            MessageBox.Show(show02);
            MessageBox.Show(show03);







            //("Student Name: " + firstName + " " + middleName + " " + lastName + 
            //  "\nGender: " + gender + "Date of Birth: " + dayCombo.SelectedItem + "/");

            //return "Name: " + firstN + " " + middleN + " " + lastN + "\nProgram: " + program;




            //MessageBox.Show(show01 + show02 + show03);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList programChoice01 = new ArrayList();

            programChoice01.Add("Bachelor of Fine Arts Major in Sculpture");
            programChoice01.Add("Bachelor of Fine Arts Major in Visual Communication");
            programChoice01.Add("Bachelor of Science in Criminology");
            programChoice01.Add("Bachelor of Science in Information Technology");
            programChoice01.Add("Bachelor of Science in Computer Science");
            //programsCombo.DataSource = programChoice01;


            foreach (string program in programChoice01)
            {

                programsCombo.Items.Add(program);

            }

            ArrayList day01 = new ArrayList();

            for (int i = 0; i < 31; i++)
            {

                day01.Add(i + 1);
                dayCombo.Items.Add(day01[i]);


            }

            ArrayList month01 = new ArrayList();


            month01.Add("January");
            month01.Add("February");
            month01.Add("March");
            month01.Add("April");
            month01.Add("June");
            month01.Add("July");
            month01.Add("August");
            month01.Add("September");
            month01.Add("October");
            month01.Add("November");
            month01.Add("December");

            foreach (string month in month01)
            {

                monthCombo.Items.Add(month);

            }

            ArrayList year01 = new ArrayList();

            for (int i = 1950; i < 2024; i++)
            {

                year01.Add(i);
                yearCombo.Items.Add(year01[i - 1950]);

            }

        }
        public string message01(string firstN, string middleN, string lastN, string gender, string date, string program)
        {
            return "Name: " + firstN + " " + middleN + " " + lastN + "\nGender: " + gender + "\nDate: " + date + "\nProgram: " + program;


        }

        public string message02(string firstN, string middleN, string lastN, string program)
        {
            return "Name: " + firstN + " " + middleN + " " + lastN + "\nProgram: " + program;


        }

        public string message03(string firstN, string middleN, string program)
        {
            return "Name: " + firstN + " " + middleN + " " + "\nProgram: " + program;


        }

    }


}
