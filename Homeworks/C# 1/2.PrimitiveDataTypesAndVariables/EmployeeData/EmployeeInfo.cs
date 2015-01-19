//Problem 10. Employee Data
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
//Use descriptive names. Print the data at the console.

using System;

class EmployeeInfo
{
    static void Main()
    {
        string firstName = "firstName";
        string lastName = "lastName";
        ushort age = 29;
        char gender = 'm';
        long iD = 8306112507;
        int employeeNum = 27560000;

        Console.WriteLine(firstName + " " + lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("ID: {0}, Emoloyee number: {1}", iD, employeeNum);
    }
}