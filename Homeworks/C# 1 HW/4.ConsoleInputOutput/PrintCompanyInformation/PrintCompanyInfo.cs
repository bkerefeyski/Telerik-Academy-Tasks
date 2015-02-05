//Problem 2. Print Company Information
//A company has name, address, phone number, fax number, web site and manager. The manager 
//has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Title = "Company";
        Console.Write("Enter Company name:");
        string companyName = Console.ReadLine();
        Console.Write("Enter Company address:");
        string companyAdress = Console.ReadLine();
        Console.Write("Enter phone number:");
        uint phoneNumber;
        string str = Console.ReadLine();
        bool parseSuccess = UInt32.TryParse(str, out phoneNumber);
        while (parseSuccess == false)
        {
            Console.Write("Invalid Number, Please try again:");
            str = Console.ReadLine();
            parseSuccess = UInt32.TryParse(str, out phoneNumber);
        }

        Console.Write("Enter Fax number:");
        uint faxNumber;
        string faxStr = Console.ReadLine();
        parseSuccess = UInt32.TryParse(str, out faxNumber);
        while (parseSuccess == false)
        {
            Console.Write("Invalid Number, Please try again:");
            faxStr = Console.ReadLine();
            parseSuccess = UInt32.TryParse(str, out faxNumber);
        }

        Console.Write("Enter Web site:");
        string webSite = Console.ReadLine();
        Console.Write("Enter Manger first name:");
        string managerName = Console.ReadLine();
        Console.Write("Enter Manager last name:");
        string managerFamily = Console.ReadLine();

        Console.Write("Enter Manager age:");
        byte managerAge;
        string ageStr = Console.ReadLine();
        bool parseSuccessAge = Byte.TryParse(ageStr, out managerAge);
        while (parseSuccessAge == false)
        {
            Console.Write("Invalid Number, Please try again:");
            ageStr = Console.ReadLine();
            parseSuccessAge = Byte.TryParse(ageStr, out managerAge);
        }

        Console.Write("Enter Manager phone:");
        uint managerPhone;
        str = Console.ReadLine();
        parseSuccess = UInt32.TryParse(str, out managerPhone);
        while (parseSuccess == false)
        {
            Console.Write("Invalid Number, Please try again:");
            str = Console.ReadLine();
            parseSuccess = UInt32.TryParse(str, out managerPhone);
        }

        string companyInfo = new string('-', 25);
        string company = "COMPANY INFO";
        string managerInfo = "Manager Info";
        Console.WriteLine(companyInfo);
        Console.WriteLine(company);
        Console.WriteLine(companyInfo);

        Console.WriteLine("{0}\n\rAddress:{1}\n\rTel. {2}\n\rFax. {3}\n\rWeb site: {4}", 
            companyName, companyAdress, phoneNumber,faxNumber, webSite);

        Console.WriteLine(companyInfo);
        Console.WriteLine(managerInfo);
        Console.WriteLine(companyInfo);

        Console.WriteLine("Manager first name {0}\n\rManager last name: {1}\n\rAge: {2}\n\rPhone: {3}", managerName, 
            managerFamily, managerAge, managerPhone);
    }
}