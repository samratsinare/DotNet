using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee();
            Employee e2 = new Employee("rahul");
            Employee e3 = new Employee("rahul", 500000);
            Employee e4 = new Employee("", 50000, 12);


            Console.WriteLine(e2.EmpNumber);
            Console.WriteLine(e3.EmpNumber);
            Console.WriteLine(e4.EmpNumber);

            Console.ReadLine();

            e2.GetSalary();

        }
    }

    class Employee
    {

        #region Data Members
        string Name;
        static int EmpNo = 1; // auto generated
        decimal Basic;
        public decimal DA, HRA, Gross_Salary;
        short DeptNo;
        #endregion


        #region SetterGetters


        // Name
        public string EmpName
        {
            set
            {
                if (value != null)
                {
                    Name = value;
                }
                else
                {
                    //throw new ArgumentException("value");
                    Console.WriteLine("u hve enterd wrong Name");
                }
            }

            get
            {
                return Name;
            }
        }

        //EmpNo
        // auto increment EmpNo

        //public Employee()
        //{
        //    EmpNo++;
        //}

        public int EmpNumber
        {
            set
            {
                if (value >= 0)
                {
                    EmpNo = value;

                }
            }
            get
            {
                return EmpNo++;
            }

        }


        // Basic
        public decimal BasicSalary
        {
            set
            {
                if ((50000 <= value) && (100000 >= value))
                {
                    Basic = value;
                }
            }
            get
            {
                return Basic;
            }

        }

        //Dept
        public short DeptNumber
        {
            set
            {
                if (value > 10)
                {
                    DeptNo = value;
                }
                else
                {
                    Console.WriteLine("u hve enterd wrong dept number");
                }
            }
            get
            {
                return DeptNo;

            }
        }


        #endregion






        #region construc
        public Employee()
        {

        }
        public Employee(string Name, decimal Basic, short DeptNo)
        {
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }
        public Employee(string Name, decimal Basic)
        {

            this.Name = Name;
            this.Basic = Basic;
        }

        public Employee(string Name)
        {

            this.Name = Name;

        }
        #endregion


        #region Methods
        public void GetSalary()
        {

            DA = ((Basic * 40) / 100);
            HRA = ((Basic * 20) / 100);
            Gross_Salary = Basic + DA + HRA;

            Console.WriteLine("Gross Salary : " + Gross_Salary);

        }
        #endregion


    }
}
