using System;



namespace project1
{
    class Person
    {
        protected int age;
        public void Display()
        {
            Console.WriteLine("Hello");
        }
       public void SetAge(int n)
        {
            age = n;
            Console.WriteLine("My age is:{0} years old", age);
        }


    }
    class Student : Person
    {
        public void ShowAge()
        {
            Console.WriteLine(age);
        }
    }
    class Teacher : Person
    {
        private string subject;
        public void Explain()
        {
            
            Console.WriteLine("Explanation begins");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Display();
            p.SetAge(21);

            Student s = new Student();
            //s.setAge(21);
            s.Display();
            s.ShowAge();

            Teacher T = new Teacher();
            T.Display();
            T.Explain();
        }
    }
}
