using System;

class Aula12 {
    static void Main() 
    {
        int grade;
        string nameStudent;
        
        Console.WriteLine("What is name of student ?");
        nameStudent = Console.ReadLine();

        Console.WriteLine("What is a score of student ? ");
        string input = Console.ReadLine();

        grade = int.Parse(input);

        if(grade <= 60)
        {
            Console.WriteLine("The student {0} is reject !", nameStudent);
        } else {
            Console.WriteLine("The student {0} is accept !", nameStudent);
        }

    }
}