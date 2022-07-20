using System;
namespace inheritance
{
    public class Employee
    {
        private string name;
        private double salary;
        protected double bonus;

        public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;

            }
        }

        public virtual void SetBonus(double bonus)
        {
            this.bonus = bonus;
        }

        public double ToPay()
        {
            return this.Salary + this.bonus;
        }
    }


    public class SalesPerson : Employee
    {
        private int percent;

        public SalesPerson(string name, double salary, int percent): base(name, salary)
        {
            this.percent = percent;
        }

        public override void SetBonus(double bonus)
        {
            if(this.percent > 200)
            {
                this.bonus = bonus * 2;
            }

            if(this.percent > 100)
            {
                this.bonus = bonus * 3;
            }

            this.bonus = bonus;
        }
    }

    public class Manager : Employee
    {
        private int quantity;

        public Manager(string name, double salary, int quantity) : base(name, salary)
        {
            this.quantity = quantity;
        }

        public override void SetBonus(double bonus)
        {
            if (this.quantity > 150)
            {
                this.bonus = bonus + 1000;
            }

            if (this.quantity > 100)
            {
                this.bonus = bonus + 500;
            }

            this.bonus = bonus;
        }
    }

    public class Company
    {
        private Employee[] employees;

        public Company(Employee[] employees)
        {
            this.employees = employees;
        }

        public void GiveEverybodyBonus(double companyBonus)
        {
            foreach (Employee employee in this.employees)
            {
                employee.SetBonus(companyBonus);
            }
        }

        public double TotalToPay()
        {
            double sum = 0;
            foreach(Employee employee in this.employees)
            {
                double employeeIncome = employee.ToPay();
                sum = sum + employeeIncome;
            }

            return sum;
        }

        public string NameMaxSalary()
        {
            Employee employeeWithMaxIncome = this.employees[0];

            for(int i = 1; i < this.employees.Length; i++)
            {
                if(this.employees[i + 1].ToPay() > this.employees[i].ToPay())
                {
                    employeeWithMaxIncome = this.employees[i + 1];
                }
            }

            return employeeWithMaxIncome.Name;
        }
    }
}

