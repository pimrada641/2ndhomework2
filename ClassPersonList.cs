using System.Collections.Generic;
using System;

class PersonList
{
	private List<Person> personlist;
	public PersonList()
    {
        this.personlist = new List<Person>();
    }
    public void AddNewPerson(Person person)
    {
        this.personlist.Add(person);
    }

    public void RemovePerson()
    {
        int i = int.Parse(Console.ReadLine());
        this.personlist.RemoveAt(i-1);
    }

    public void FetchPersonList()
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
