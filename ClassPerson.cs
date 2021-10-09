public class Person
{
    public string name;
    public string address;
    public string citizenID;

    public Person(string name, string address, string citizenID)
    {
        this.name = name;
        this.address = address;
        this.citizenID = citizenID;
    }

    public string Getname()
    {
        return this.name;
    }
}
class Student : Person
{
    private string studentID;

    public Student(string name,string address, string citizenID, string studentID) : base(name, address, citizenID)
    {
        this.studentID = studentID;
    }
}
class Teacher : Person
{
    private string employeeID;

    public Teacher(string name, string address, string citizenID, string employeeID) : base(name, address, citizenID)
    {
        this.employeeID = employeeID;
    }
}