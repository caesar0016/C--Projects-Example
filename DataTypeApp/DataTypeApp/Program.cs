namespace DataTypeApp
{
    internal class DataTypeProgram
    {
        static void Main(string[] args)
        {
            string usrName;
            int age;          
            char usrSex;
            bool isPassed;
            double usrAve;
            const int NUMBER_ADD = 594;
            const string ADDRESS = "Santol Balagtas Bulacan";
            const char MIDDLE_INT = 'C';


            Console.Write("Enter name: ");
            usrName = Console.ReadLine();

            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter sex: ");
            usrSex = Convert.ToChar(Console.ReadLine());

            Console.Write("Are you passed in last sem? (True or False): ");
            isPassed = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter your average grade: ");
            usrAve = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Name          : "+usrName);
            Console.WriteLine("Age           : "+age);          
            Console.WriteLine("Sex           : "+usrSex);
            Console.WriteLine("Passed        : "+isPassed);
            Console.WriteLine("Average grade : "+usrAve);

            Console.WriteLine();
            Console.WriteLine("Constant value");
            Console.WriteLine("Address        :"+ NUMBER_ADD+" "+ADDRESS);
            Console.WriteLine("Middle Initial :"+ MIDDLE_INT);

            Console.WriteLine("Press any enter key to exit...");
            Console.ReadKey();  
        }
    }
}