using System;


namespace studentInfoApp
{
    internal class studentInfo
    {
        private string firstName;
        private string lastName;
        private int studentID;

        public studentInfo()
        { //default constructor




        }
        public studentInfo(int student_ID , string firstName)
        {

            this.studentID = student_ID;
            this.firstName = firstName;

        }
        public studentInfo(int userID, string firstName, string lastName){ //overloading constructor

            this.studentID = userID;
            this.firstName = firstName;
            this.lastName = lastName;

        }


        public string fName{  //encapsulation for firstName

            get { return firstName; }
            set { firstName = value; }

        }
        public string lName //encapsulation for lastName
        {
            get { return lastName; }
            set { lastName = value; }

        }
        public int IDStudent  //encapsulation for student ID
        {

            get { return studentID; }
            set { studentID = value; }

         }
  
    }
}
