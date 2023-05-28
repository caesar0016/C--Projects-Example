using System;


namespace studentInfoApp
{
    internal class studentInfo
    {
        private string firstName;
        private string lastName;
        private int studentID;

        public studentInfo(int userID, string firstName, string lastName){ //overloading constructor

            IDStudent = userID;
            fName = firstName;
            lName = lastName;

        }

        public studentInfo() { //default constructor

            IDStudent = this.IDStudent;
            fName = this.firstName;
            lName = this.lastName;


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
