//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPConcept
//{
//   public class Employee
//    {
//        public string CompanyName;
//        public int EmpID;
//        public string EmpName;
//        public double GrossPay;
//        double TaxDeducation = 0.05;
//        double netSalary;

//        public Employee(string ECompanyname, string EName, int EID, double EGrosspay)
//        {
//            this.CompanyName = ECompanyname;
//            this.EmpID = EID;
//            this.EmpName = EName;
//            this.GrossPay = EGrosspay;
                
//        }
//        void CalculateSalary()
//        {
//            if (GrossPay >= 22000)
//            {
//                netSalary = GrossPay - (TaxDeducation*GrossPay);
//                Console.WriteLine("Your salary is  " + netSalary);
//            }
//            else
//            {
//                Console.WriteLine("Your salary is : "+GrossPay);
//            }
//        }
//        public void ShowEmployeeDetails()
//        {
//            this.CalculateSalary();
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Employee Nitish = new Employee("Axa business service","Nitish Mehta",
//                280880, 25000);
//            Nitish.ShowEmployeeDetails();
//            Console.ReadLine();

//        }
//    }
//}
