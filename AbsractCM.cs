//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPConcept
//{
//    // crated abstract class
//   public abstract  class person //
//   {
//        public string firstname;
//        public string lastname;
//        public int age;
//        public long phoneNumber;

//        //can't give body for abstact method, abstact method can be create inside 
//        // abstact class only not outside from abstact class.
//        // Inside the abstact class, we can make abstract & non-abstract method both. 
//        public abstract void PrintDetails();
//   }
//    class teacher : person
//    {
//        public string qualification;
//        public int salary;
//        public override void PrintDetails()
//        {
//            string name = this.firstname + "  " + this.lastname;
//            Console.WriteLine("teacher Name is : {0}" , name);
//            Console.WriteLine("teacher age is : {0}", this.age);
//            Console.WriteLine("teacher phone number is : {0}", this.salary);
//            Console.WriteLine("teacher phone number is : {0}", this.qualification);
//        }
//    }
//    class student : person
//    {
//        public int rollNum;
//        public int fees;
//        public override void PrintDetails()
//        {
//            string name = this.firstname + "  " + this.lastname;
//            Console.WriteLine("Student Name is : {0}", name);
//            Console.WriteLine("Student  age is : {0}", this.age);
//            Console.WriteLine("Student  phone number is : {0}", this.rollNum);
//            Console.WriteLine("Student  phone number is : {0}", this.fees);

//        }

//    }
//    class pprogram
//    {
//        public static void Main(string[] args)
//        { 
//        student Nitish = new student();
//            Nitish.firstname = "Nitish";
//            Nitish.lastname = "Mehta";
//            Nitish.age = 24;
//            Nitish.rollNum = 280880;
//            Nitish.phoneNumber = 82526600901;
//            Nitish.fees = 5000;
//            Nitish.PrintDetails();

//            Console.WriteLine(".........................................");
//            teacher Murli = new teacher();
//            Murli.firstname = "Murli";
//            Murli.lastname = "Krishna R";
//            Murli.salary = 80000;
//            Murli.qualification = "Master in Computer Science";
//            Murli.phoneNumber = 9852267614;
//            Murli.PrintDetails();
//            Console.ReadLine();
//        }
//    }
//}
