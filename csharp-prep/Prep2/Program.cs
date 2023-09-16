using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage. ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string letter = "null";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }       
        
        else if (grade >= 70)
        {
            letter = "C";
        }          
        
        else if (grade >= 60)
        {
            letter = "D";
        }    
        
        else
        {
            letter = "F";
        }    

        Console.WriteLine($"Your letter grade is {letter}");

            if (grade >= 70)
            {
                Console.WriteLine("Congratulation! You have successfully passed this class.");
            }  

            else
            {
                Console.WriteLine("Unfortunately, you have not met the requirements to pass this class. You may try again in the future.");
            }      

    }
}