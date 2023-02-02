namespace cs_proj001;
class Program
{
    static void Main(string[] args)
    {
     
        int [] num1  = {1, 2, 4, 5, 7, 13, 56};

        int tryAgain = 0;

        do{

        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();
        
        try{
        Console.Write("Press [1] to try again: ");
        tryAgain = Convert.ToInt16(Console.ReadLine());
        

        }catch(Exception e){
            Console.WriteLine(e.Message);
        }

        

        }while(tryAgain==1);

        Console.WriteLine("You got out I guess");

    








    }

}
