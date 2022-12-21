using System;
namespace Program;
class Department{
    string Name;
    float Compenstation;
    public Department(string name,float compenstation){
        Name=name;
        Compenstation=compenstation;
    }
    public double GetSalary(double salary , int workingDay){
        return (salary * workingDay) + (salary * workingDay) * (Compenstation/100);
    }
}
class Employee{
    string FirstName;
    string LastName;
    double Salary;
    Department Department;
    public Employee(string firstname , string lastname ,double salary, Department department){
        FirstName=firstname;
        LastName=lastname;
        Salary=salary;
        Department=department;
    }
    public double GetSalary(int workingDays){
        return Department.GetSalary(Salary,workingDays);
    }
}
class Database{
    int dep_index=0;
    int emp_index=0;
    Department[] Departments= new Department[10];
    Employee[] Employees= new Employee[10];
    public void AddDepartment(Department department){
    Departments[dep_index++]=department;
    }
    public void AddEmployee(Employee employee){
    Employees[emp_index++]=employee;
    }
}
class Main_class{
    public static void Main(){
        Console.WriteLine("enter the first name employee name :");
        string firstname=Console.ReadLine();
        Console.WriteLine("entert the last name employee :");
        string lastname=Console.ReadLine();
        Console.WriteLine("enter the employee salary :");
        double salary=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the department name : ");
        string departmentName=Console.ReadLine();
        Console.WriteLine("enter the compensation :");
        float compenstation=Convert.ToSingle(Console.ReadLine());
        Department department=new Department(departmentName,compenstation);
        Employee employee=new Employee(firstname,lastname,salary,department);
        Database database=new Database();
        database.AddDepartment(department);
        database.AddEmployee(employee);
        Console.WriteLine("enter the working days:");
        int workingDays=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("the salary is "+employee.GetSalary(workingDays));
    }
}