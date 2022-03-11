using System;

namespace ClassTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Fullname();
            Console.WriteLine("********Please, Enter your group*********");
            student.Group = Console.ReadLine();
            student.Pointer();
            student.StuddentInfo();

        }
    }
    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool isGraduated;

        public void Fullname()
        {
            Console.WriteLine("*******Please, enter your name*********");
            Name = Console.ReadLine();
            Console.WriteLine("*******Please, enter your surname******");
            Surname = Console.ReadLine();
            Console.WriteLine($"{Name} {Surname}");
        }
        public void StuddentInfo()
        {
            if (Point >=51 && Point <=100)
            {
                isGraduated = true;
                Console.WriteLine("The student graduated!");
            }
            else
            {
                isGraduated = false;
                Console.WriteLine("Your faild the exam:(");
            }
            Console.WriteLine($"Name: {Name}  Surname: {Surname} Group: {Group} Point: {Point}");

        }
        public void Pointer()
        {
            Console.WriteLine("********Please, Enter your score*********");
            Point = Convert.ToInt32(Console.ReadLine());
            if (Point > 80 && Point <=100)
            {
                Console.WriteLine("The student can take the second exam!");
            }
            else if(Point>100 || Point<0)
            {
                Console.WriteLine("Please, enter the correct score");
                
            }
            else
            {
                Console.WriteLine("Sorry, the student cannot take the second exam!");
            }
        }
    }
}
