using System;

class Aula08 {
    static void Main() {
        string firstname, lastname, address, phone;
        Console.WriteLine("Inform your firstname:");
        firstname = Console.ReadLine();
        
        Console.WriteLine("The lastname:");
        lastname = Console.ReadLine();

        Console.Write("Informe yuor address:");
        address = Console.ReadLine();

        Console.Write("Inform your phone:");
        phone = Console.ReadLine();


        Console.Write("Firstname: {0} \n Lastname: {1} \n Address: {2} \n Phone: {3}", firstname, lastname, address, phone);

    }
}