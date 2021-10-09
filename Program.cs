using System;

namespace homework2
{
    public enum Menu //กำหนดค่าคงที่ที่แทนตัวเลือกเพื่อไปยังแต่ละเมนู
    {
        RegisterNewStudent = 1,RegisterNewTeacher = 2,GetListPersons = 3,DeletePersonInList = 4
    }
    class Program
    {
        static PersonList personList; //สร้างลิสต์โดยอิงจากค่าใน Class Person List

        static int selectmenu;
        static void Main(string[] args)
        {
            Program.personList = new PersonList();
            PrintMenuScreen();
        }
        static void PrintMenuScreen()
        {
            Console.Clear();
            Screen.mainmenuscreen();
            selectMenu((Menu)inputSelectMenu(selectmenu));
        }
        static int inputSelectMenu(int valueselectmenu)
        {
            Console.Write("Please Select Memu: ");
            return selectmenu = int.Parse(Console.ReadLine());
        }
        static void selectMenu(Menu menu)
        {
            int total;
            if (menu == Menu.RegisterNewStudent)
            {
                Console.Clear();
                Screen.headtotalstudentscreen();
                Console.Write("Input Total new Student: ");
                total = int.Parse(Console.ReadLine());  

                for (int i = 1; i<=total; i++)
                {
                    Console.Clear();
                    Screen.headtotalstudentscreen();
                    Student student = CreateNewUser.CreateNewStudent();
   
                    Program.personList.AddNewPerson(student);
                }  
                InputExit();
            }
            else if (menu == Menu.RegisterNewTeacher)
            {
                Console.Clear();
                Screen.headtotalteacherscreen();
                Console.Write("Input Total new Teacher: ");
                total = int.Parse(Console.ReadLine());

                for (int i = 1; i <= total; i++)
                {
                    Console.Clear();
                    Screen.headtotalteacherscreen();
                    Teacher teacher = CreateNewUser.CreateNewTeacher();

                    Program.personList.AddNewPerson(teacher); 
                }
                InputExit();
            }
            else if (menu == Menu.GetListPersons)
            {
                Console.Clear();
                Screen.personListscreen();
                Program.personList.FetchPersonList();
                InputExit();
            }
            else if (menu == Menu.DeletePersonInList)
            {
                Console.Clear();
                Screen.deletepersonscreen();
                Program.personList.FetchPersonList();
                Console.Write("delete number : "); 
                Program.personList.RemovePerson();

                InputExit();
            }
            else
            {   
                Console.WriteLine("\nMenu Incorrect Please try again.");
                inputSelectMenu(selectmenu);
            }
        }
        static void InputExit()
        {
            string input = "";

            while(input != "exit")
            {
                Console.Write("Input: ");
                input = Console.ReadLine();
            }
            PrintMenuScreen();
        }
        

    }
}
