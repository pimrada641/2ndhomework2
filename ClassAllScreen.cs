using System;
public class Screen
{
    static public void mainmenuscreen()
    {
        Console.WriteLine("Welcome to registration new user school application.\n" +
            "-----------------------------------\n" +
            "1. Register new student.\n" +
            "2. Register new Teacher.\n" +
            "3. Get List Persons.\n"+
            "4. Delete person in list.");
    }
    static public void headtotalstudentscreen()
    {
        Console.WriteLine("Register new student.\n" +
            "--------------------");
    }

    static public void headtotalteacherscreen()
    {
        Console.WriteLine("Register new teacher.\n" +
        "--------------------");
    }
    static public void personListscreen()
    {
        Console.WriteLine("List Persons\n"+
        "------------");
    }
    static public void deletepersonscreen()
    {
        Console.WriteLine("Delete person in list\n" +
        "---------------");
    }
}
