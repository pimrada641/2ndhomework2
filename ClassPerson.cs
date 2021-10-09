public class Person
{
    public string name; //กำหนดตัวแปรชื่อ
    public string address; //กำหนดตัวแปรที่อยู่
    public string citizenID; //กำหนดตัวแปรเลขบัตรประชาชน

    public Person(string name, string address, string citizenID) //Constructor รับข้อมูลชื่อ ที่อยู่ เลขบัตรประชาชน
    {
        this.name = name;
        this.address = address;
        this.citizenID = citizenID;
    }

    public string Getname() //เมธอดแสดงผลชื่อ
    {
        return this.name;
    }
}
class Student : Person //Class Student ที่สืบทอดมาจาก class Person
{
    private string studentID; //กำหนดตัวแปรรหัสนักเรียนเป็นส่วนตัว

    public Student(string name,string address, string citizenID, string studentID) : base(name, address, citizenID) //Constructor รับค่าชื่อ ที่อยู่ เลขบัตรประชาชนตาม Class Person และค่ารหัสนักเรียนจากในคลาสนี้
    {
        this.studentID = studentID; 
    }
}
class Teacher : Person //Class Teacher ที่สืบทอดมาจาก class Person
{
    private string employeeID; //กำหนดตัวแปรรหัสพนักงานเป็นส่วนตัว

    public Teacher(string name, string address, string citizenID, string employeeID) : base(name, address, citizenID) //Constructor รับค่าชื่อ ที่อยู่ เลขบัตรประชาชนตาม Class Person และค่ารหัสพนักงานจากในคลาสนี้
    {
        this.employeeID = employeeID;
    }
}
