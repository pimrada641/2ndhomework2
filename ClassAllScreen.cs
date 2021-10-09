using System;
public class Screen
{
    static public void mainmenuscreen() //เมธอดแสดงหน้า main menu
    {
        Console.WriteLine("Welcome to registration new user school application.\n" +
            "-----------------------------------\n" +
            "1. Register new student.\n" +
            "2. Register new Teacher.\n" +
            "3. Get List Persons.\n"+
            "4. Delete person in list.");
    }
    static public void headtotalstudentscreen() //เมธอดแสดงหน้า Register new student
    {
        Console.WriteLine("Register new student.\n" +
            "--------------------");
    }

    static public void headtotalteacherscreen() //เมธอดแสดงหน้า Register new teacher
    {
        Console.WriteLine("Register new teacher.\n" +
        "--------------------");
    }
    static public void personListscreen() //เมธอดแสดงหน้า List Persons
    {
        Console.WriteLine("List Persons\n"+
        "------------");
    }
    static public void deletepersonscreen() //เมธอดแสดงหน้า Delete person in list
    {
        Console.WriteLine("Delete person in list\n" +
        "---------------");
    }
}
