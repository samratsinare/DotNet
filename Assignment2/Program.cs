using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{

    
    public abstract class Employee
    {

         public Employee(string name="no",short deptno=0,decimal Basic=2000)
        {

            this.EmpName = name;
            this.DeptNumber = deptno;
            this.Basic = Basic;
            
        }

        public decimal basic;
        public abstract decimal Basic
        {
            get;
            set;
        }
        public static int lastempNo = 0;
        public string name;

          public string EmpName
        {

            set
            {
                if(value!=null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Invalid name");
                }

            }

            get
            {

                return name;

            }

        }

        public int empno;
        public  int Empno
        {
            set
            {
                empno = value;

            }
            get
            {
                return empno;
            }
        }

        public short deptno;

         public short DeptNumber
        {
            set
            {
                 if(value>=0)
                {
                    deptno = value;
                }

                 else
                {
                    Console.WriteLine("wrong number");
                }

            }

            get
            {
                return deptno;
            }
        }
        public abstract decimal CalcNetSalary(decimal basic);

    }


    public class Manager : Employee
    {

        public Manager(string name = "no", short deptno = 0, decimal Basic = 2000 , string design="Manager"):base(name,deptno,Basic)
        {

            this.Designation = design;

        }

        public string design;

        public string Designation
        {
            set
            {
                 if(value!=null)
                {
                    design = value;
                }
                 else
                {
                    Console.WriteLine("Invalid");

                }

            }

            get
            {
                return design;
            }
        }

         public override decimal Basic
        {
            set
            {
                 
                if(value > 1500 && value < 10000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            get
            {
                return basic;
            }
        }
         
        public override decimal CalcNetSalary(decimal basic)
        {

            decimal DA = ((basic * 40) / 100);
            decimal HRA = ((basic * 20) / 100);
            decimal Gross_Salary = basic + DA + HRA;

            return Gross_Salary;

        }
    }

    public class GeneralManager : Manager
    {
       

        public string perks;

        public GeneralManager(string name = "no", short deptno = 0, decimal Basic = 2000, string design="GM",string perks="none") 
            
            : base(name, deptno, Basic,design)
        {

            this.Perks = perks;

        }


        public string Perks
        {
            set
            {
                perks = value;
            }
            get
            {
                return perks;
            }
        }

    }

     public class CEO : Employee
    {
        public CEO()
        {
            Console.WriteLine("CEO class  construeter");
        }

        public override decimal Basic
        {
            set
            {

                if (value > 1500 && value < 10000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            get
            {
                return basic;
            }
        }

        public override sealed decimal CalcNetSalary(decimal basic)
        {

            decimal DA = ((basic * 40) / 100);
            decimal HRA = ((basic * 20) / 100);
            decimal Gross_Salary = basic + DA + HRA;

            return Gross_Salary;

        }


    }


    class Program
    {
        static void Main(string[] args)
        {

            GeneralManager g1 = new GeneralManager("samrat", 2, 2000, "GM","none");

            Manager m1 = new Manager("samrat", 2, 2000, "M");

            Console.WriteLine( m1.CalcNetSalary(m1.Basic));

          

          

            Console.ReadLine();

        }
    }
}
