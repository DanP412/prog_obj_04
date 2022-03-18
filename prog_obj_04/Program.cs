using System;

namespace prog_obj_04
{
    class Program
    {
        static void Main(string[] args)
        {
           Person Student  = new Person ("Jan", 17,"LAB_04", "Kowalski");
           
        }
    }


    public class Person
    {
        string name;
        int age;
        string surrname;
        string group;

        public Person(string name1, int age1)
        {
            name = name1;
            age = age1;
        }

        public Person()
        {
            
        }

        public Person(Person copy)
        {
            this.name = copy.name;
            this.age = copy.age;
        }

      

        public class Teacher: Person
        {
            public Teacher(string imie, string nazw, int age, string gru)
            {
                this.name = imie;
                this.surrname = nazw;
                this.age = age;
                this.group = gru;

            }
           
        }
         class Student : Person
        {
            
           

            public Student(string imie, string nazw, int age, string gru)
            {
                this.name = imie;
                this.age = age;
                this.surrname = nazw;
                this.group = gru;
                
                
                
            }
        }
    }
   


}
