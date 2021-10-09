using System;
using homework2;

class CreateNewUser
{
    public static Student CreateNewStudent() //ฟังก์ชั่นสร้างรายชื่อนักเรียนใหม่โดยรับและส่งค่าจากฟังก์ชั่นต่างๆ 
    {
        return new Student(InputName(), InputAddress(), InputCitizenID(), StudentID());
    }
    public static Teacher CreateNewTeacher() //ฟังก์ชั่นสร้างรายชื่ออาจารย์ใหม่โดยรับและส่งค่าจากฟังก์ชั่นต่างๆ 
    {
        return new Teacher(InputName(), InputAddress(), InputCitizenID(), EmployeeID());
    }
    static string InputName() //ฟังก์ชั่นรับและส่งค่าชื่อ
    {
        Console.Write("Name: ");

        return Console.ReadLine();
    }
    static string InputAddress() //ฟังก์ชั่นรับและส่งค่าที่อยู่
    {
        Console.Write("Address: ");

        return Console.ReadLine();
    }
    static string InputCitizenID() //ฟังก์ชั่นรับและส่งค่าเลขบัตรประชาชน
    {
        Console.Write("CitizenID: ");

        return Console.ReadLine();
    }
    static string StudentID() //ฟังก์ชั่นรับและส่งค่ารหัสนักเรียน
    {
        Console.Write("StudentID: ");

        return Console.ReadLine();
    }
    static string EmployeeID() //ฟังก์ชั่นรับและส่งค่ารหัสพนักงาน
    {
        Console.Write("EmployeeID: ");

        return Console.ReadLine();
    }
}
