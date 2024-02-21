using System;


namespace Ncit_lab_asal1
{
    class Employee
    {
        int eid;
        string name;
        double salary;
        string department;

        public Employee(int eid, string name, double salary, string department) 
        {
            this.eid = eid;
            this.name = name;
            this.salary = salary;
            this.department = department;
        }   
        public object this[int idx]
        {
           get
            {
                if (idx == 0)
                    return this.eid;
                else if (idx == 1)
                    return this.name;
                else if (idx == 2)
                    return this.salary;
                else if (idx == 3)
                    return this.department;

                else
                    return "invalid index";
            }
            set
            {
                if (idx == 0)
                    this.eid = (int)value;
                else if (idx == 1)
                    this.name = (string)value;
                else if (idx == 2)
                    this.salary = (double)value;
                else if (idx == 3)
                    this.department = (string)value;

                else
                    Console.WriteLine("invalid index");

            }
        }
    }
 

    internal class IndexerTest
    {

        static void Main(string[] args)
        {
            Employee emp1;
             emp1 =  new Employee(202, "asal", 120000.54, "IT");
            emp1[2] = 177.4;
            Console.WriteLine("Name = " + emp1[1]);
        }
    }
}
