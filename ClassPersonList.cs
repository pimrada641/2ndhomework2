using System.Collections.Generic;
using System;

class PersonList
{
	private List<Person> personlist; //สร้างลิสต์ที่เป็นข้อมูลส่วนตัว
	public PersonList() //Constructor ลิสต์รายชื่อ
    {
        this.personlist = new List<Person>();
    }
    public void AddNewPerson(Person person) //ฟังก์ชั่นเพิ่มรายชื่อ
    {
        this.personlist.Add(person);
    }

    public void RemovePerson() //เมธอดลบรายชื่อในลิสต์ตามที่ผู้ใช้กรอก
    {
        int i = int.Parse(Console.ReadLine());
        this.personlist.RemoveAt(i-1);
    }

    public void FetchPersonList() //เมธอดแสดงรายชื่อทั้งหมดจากในลิสต์
    {
        foreach(Person person in this.personlist)
        {
            if(person is Student)
            {
                Console.WriteLine("Name: {0} \nType: Student\n",person.Getname());
            }
            else if(person is Teacher)
            {
                Console.WriteLine("Name: {0} \nType: Teacher\n", person.Getname());
            }
        }
    }
}
