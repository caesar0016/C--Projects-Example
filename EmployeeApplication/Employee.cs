using System;


namespace EmployeeApplication
{
    internal class Employee
    {
        private int empID = 0;
        private string firstName, lastName, position;

        public int encapEmpID {

            get{ return empID; }
            set { empID = value; }
        
        
        }

        public string encapfirstName
        {
            get { return firstName; }
            set { firstName = value; }        
        }

        public string encaplastName
        {
            get { return lastName; }
            set { lastName = value; }
        
        }
        public string encapPosition
        {
            get { return position;}
            set { position = value; }
        
        
        }

        public Employee() {



        }

        public Employee(int empID, string firstName, string lastName, string position) //did not "this" method because I replace it with setters and getters
        {
            this.empID = empID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;

        }
        public Employee(int empID, string firstName, string lastName) //does not required to input position 
        {
            this.empID = empID;
            this.firstName = firstName;
            this.lastName = lastName;


        }
        public Employee(string firstName, string lastName) //does not required to input position 
        {

            this.firstName = firstName;
            this.lastName = lastName;


        }

    }
}
