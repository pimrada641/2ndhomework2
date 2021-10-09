using System;

namespace homework2
{
    public enum Menu //กำหนดค่าคงที่ที่แทนตัวเลือกเพื่อไปยังแต่ละเมนู
    {
        RegisterNewStudent = 1,RegisterNewTeacher = 2,GetListPersons = 3,DeletePersonInList = 4
    }
    class Program
    {
        static PersonList personList; //กำหนดลิสต์โดยอ้างอิงคุณสมบัติจากใน Class Person List

        static int selectmenu; //สร้างตัวแปรค่าเมนูที่ผู้ใช้กรอกเป็น static เพื่อให้ใช้ได้ทุกเมธอด
        static void Main(string[] args)
        {
            Program.personList = new PersonList(); //สร้างลิสต์ใหม่ในคลาสนี้โดยอิงคุณสมบัติจาก Class Person List
            PrintMenuScreen(); //ไปสู่เมธอด main menu
        }
        static void PrintMenuScreen() //เมธอด main menu
        {
            Console.Clear(); //ลบข้อความทั้งหมดบนหน้าจอ
            Screen.mainmenuscreen(); //เรียกใช้เมธอดเพื่อแสดงหน้า main menu ที่เก็บไว้ใน class Screen
            selectMenu((Menu)inputSelectMenu(selectmenu)); //ส่งค่าที่ผู้ใช้ input ในฟังก์ชั่น inputScelectMenu เปลี่ยนเป็นประเภท Menu และส่งไปในฟังก์ชั่น selectMenu
        }
        static int inputSelectMenu(int valueselectmenu) //ฟังก์ชั่น inputScelectMenu สำหรับให้ผู้ใช้ใส่ค่าเพื่อเลือกเมนู
        {
            Console.Write("Please Select Memu: "); //แสดงผลข้อความ
            return selectmenu = int.Parse(Console.ReadLine()); //รับค่าเพื่อเลือกเมนูที่ต้องการและส่งกลับไป
        }
        static void selectMenu(Menu menu) //ฟังก์ชั่น selectMenu จะแยกว่าผู้ใช้ต้องการไปที่เมนูใด
        {
            int total; //กำหนดค่าจำนวนคนที่ผู้ใช้ต้องการกรอกข้อมูล
            if (menu == Menu.RegisterNewStudent) //เงื่อนไข ถ้าผู้ใช้เลือก 1 หรือ RegisterNewStudent
            {
                Console.Clear(); //ลบข้อความทั้งหมดบนหน้าจอ
                Screen.headtotalstudentscreen(); //เรียกใช้เมธอดเพื่อแสดงข้อความ head ของหน้า register student ที่เก็บไว้ใน class Screen
                Console.Write("Input Total new Student: "); //แสดงผลข้อความ
                total = int.Parse(Console.ReadLine()); //รับค่าจำนวนคนจากผู้ใช้

                for (int i = 1; i<=total; i++) //ลูปรับข้อมูลตามจำนวนคนที่ผู้ใช้กรอก
                {
                    Console.Clear(); //ลบข้อความทั้งหมดบนหน้าจอ
                    Screen.headtotalstudentscreen(); //เรียกใช้เมธอดเพื่อแสดงข้อความ head ของหน้า register student ที่เก็บไว้ใน class Screen
                    Student student = CreateNewUser.CreateNewStudent(); //สร้างลิสต์ไปเก็บไว้ใน class Student โดยเรียกใช้เมธอด CreateNewStudent ใน class CreateNewUser ในการสร้างและเก็บข้อมูลของแต่ละคน
   
                    Program.personList.AddNewPerson(student); //เพิ่มลิสต์ด้านบนลงใน personList
                }  
                InputExit(); //เรียกใช้เมธอดเพื่อรับค่าจากผู้ใช้ว่าต้องการจบการทำงานนี้หรือยัง
            }
            else if (menu == Menu.RegisterNewTeacher) //เงื่อนไข ถ้าผู้ใช้เลือก 2 หรือ RegisterNewTeacher
            {
                Console.Clear(); //ลบข้อความทั้งหมดบนหน้าจอ
                Screen.headtotalteacherscreen(); //เรียกใช้เมธอดเพื่อแสดงข้อความ head ของหน้า register teacher ที่เก็บไว้ใน class Screen
                Console.Write("Input Total new Teacher: "); //แสดงผลข้อความ 
                total = int.Parse(Console.ReadLine()); //รับค่าจำนวนคนจากผู้ใช้

                for (int i = 1; i <= total; i++) //ลูปรับข้อมูลตามจำนวนคนที่ผู้ใช้กรอก
                {
                    Console.Clear(); //ลบข้อความทั้งหมดบนหน้าจอ
                    Screen.headtotalteacherscreen(); //เรียกใช้เมธอดเพื่อแสดงข้อความ head ของหน้า register teacher ที่เก็บไว้ใน class Screen
                    Teacher teacher = CreateNewUser.CreateNewTeacher(); //สร้างลิสต์ไปเก็บไว้ใน class Teacher โดยเรียกใช้เมธอด CreateNewTeacher ใน class CreateNewUser ในการสร้างและเก็บข้อมูลของแต่ละคน

                    Program.personList.AddNewPerson(teacher); //เพิ่มลิสต์ด้านบนลงใน personList
                }
                InputExit(); //เรียกใช้เมธอดเพื่อรับค่าจากผู้ใช้ว่าต้องการจบการทำงานนี้หรือยัง
            }
            else if (menu == Menu.GetListPersons)  //เงื่อนไข ถ้าผู้ใช้เลือก 3 หรือ GetListPersons
            {
                Console.Clear(); //ลบข้อความทั้งหมดบนหน้าจอ
                Screen.personListscreen(); //เรียกใช้เมธอดเพื่อแสดงหน้า personList ที่เก็บไว้ใน class Screen
                Program.personList.FetchPersonList(); //เรียกใช้เมธอดเพื่อแสดงลิสต์ของนักเรียนและคุณครูที่เก็บไว้ใน class personList
                InputExit(); //เรียกใช้เมธอดเพื่อรับค่าจากผู้ใช้ว่าต้องการจบการทำงานนี้หรือยัง
            }
            else if (menu == Menu.DeletePersonInList)
            {
                Console.Clear(); //ลบข้อความทั้งหมดบนหน้าจอ
                Screen.deletepersonscreen(); //เรียกใช้เมธอดเพื่อแสดงหน้าลบผู้ใช้ที่เก็บไว้ใน class Screen
                Program.personList.FetchPersonList(); //เรียกใช้เมธอดเพื่อแสดงลิสต์ของนักเรียนและคุณครูที่เก็บไว้ใน class personList
                Console.Write("delete number : "); //แสดงผลข้อความ
                Program.personList.RemovePerson(); //เรียกใช้เมธอดเพื่อรับค่าจากผู้ใช้และลบลำดับในลิสต์ที่ผู้ใช้เลือก

                InputExit(); //เรียกใช้เมธอดเพื่อรับค่าจากผู้ใช้ว่าต้องการจบการทำงานนี้หรือยัง
            }
            else
            {   
                Console.WriteLine("\nMenu Incorrect Please try again."); //แสดงผลข้อความว่าให้ใส่อีกครั้ง
                inputSelectMenu(selectmenu); //กลับไปฟังก์ชั่นรับค่าเพื่อเลือกเมนูใหม่
            }
        }
        static void InputExit() //เมธอดใส่ค่า exit เพื่อจบการทำงานนั้นๆ
        {
            string input = ""; //กำหนดค่าเริ่มต้นของ input

            while(input != "exit") //ลูปเมื่อผู้ใช้ยังไม่ใส่ว่า exit
            {
                Console.Write("Input: "); //แสดงผลข้อความ
                input = Console.ReadLine(); //รับค่าจากผู้ใช้ จนกว่าผู้ใช้จะใส่ว่า exit
            }
            PrintMenuScreen(); //เมื่อหลุดจากลูป กลับไปหน้า Main menu
        }
        

    }
}
