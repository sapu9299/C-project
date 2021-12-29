using System;

namespace my_trial
{
    class Person
    {
        protected int age;
       public void SetAge(int n)
        {
            age = n;
        }
       public void Display()
        {
            Console.WriteLine("Hello");
        }
    }
    class Student :Person
    {
        void GoToClasses()
        {
            Console.WriteLine("I'm going to class");
        }
        public  void ShowAge()
        {
            Console.WriteLine("My age is:{0} years old",age);
        }

    }
    class Teacher : Person
    {
        private string subject;
        public void  Explain()
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

            Student s = new Student();
            s.SetAge(21);
            s.Display();
            s.ShowAge();

            Teacher t = new Teacher();
            t.SetAge(30);
            t.Display();
            
            t.Explain();
        }
    }
}
