using System;
using homework2;

class CreateNewUser
{
    public static Student CreateNewStudent()
    {
        return new Student(InputName(), InputAddress(), InputCitizenID(), StudentID());
    }
    public static Teacher CreateNewTeacher()
    {
        return new Teacher(InputName(), InputAddress(), InputCitizenID(), EmployeeID());
    }
    static string InputName()
    {
        Console.Write("Name: ");

        return Console.ReadLine();
    }
    static string InputAddress()
    {
        Console.Write("Address: ");

        return Console.ReadLine();
    }
    static string InputCitizenID()
    {
        Console.Write("CitizenID: ");

        return Console.ReadLine();
    }
    static string StudentID()
    {
        Console.Write("StudentID: ");

        return Console.ReadLine();
    }
    static string EmployeeID()
    {
        Console.Write("EmployeeID: ");

        return Console.ReadLine();
    }
}
