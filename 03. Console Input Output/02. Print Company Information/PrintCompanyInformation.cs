using System;

class PrintCompanyInformation
{
    static void Main()
    {

        Console.WriteLine("Enter Company name: ");
        string companyName = Console.ReadLine();


        Console.WriteLine("Enter Company address: ");
        string companyAddress = Console.ReadLine();
        
        Console.WriteLine("Enter Phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.WriteLine("Fax number: ");
        string faxNumber = Console.ReadLine();


        Console.WriteLine("Web site: ");
        string webSite = Console.ReadLine();
        Console.WriteLine("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.WriteLine("Manager age: ");
        string managerAge = (Console.ReadLine());
        Console.WriteLine("Manager phone:");
        string managerPhone = Console.ReadLine();              
        
        Console.WriteLine();
        Console.WriteLine();



        Console.WriteLine("Company name: {0}\nCompany address: {1}\nPhone number: {2}\nFax number: {3}\nWeb site: {4}\nManager first name: {5}\nManager last name: {6}\nManager age: {7}\nManager phone: {8}", companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerAge, managerPhone);





    }
}

