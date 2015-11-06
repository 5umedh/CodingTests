
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class SimpleDelegates
    {
        protected delegate int tempFunctionPointer(string strParameter, int intParamater);

        public static void Main()
        {
            DelegateSample tempObj = new DelegateSample();
            tempFunctionPointer funcPointer = tempObj.FirstTestFunction;
            //synchronous
            funcPointer("hello", 1);

            //asynchronous
            funcPointer.BeginInvoke("Hello", 1, null, null);

            Console.ReadKey();
            funcPointer = tempObj.SecondTestFunction;
            funcPointer("hello", 1);
            Console.ReadKey();


            //Func: See documentation below in flavors of delegates section
            Func<string, int, int> tempFuncPointer = tempObj.FirstTestFunction;
            int value = tempFuncPointer("hello", 3);
            Console.ReadKey();

            //action:
            Action<string, int> tempActionPointer = tempObj.ThirdTestFunction;
            tempActionPointer("hello", 4);
            Console.ReadKey();


            //predicate:
            Predicate<Employee> tempPredicatePointer = tempObj.FourthTestFunction;
            Employee[] lstEmployee = (new Employee[]
            {
                   new Employee(){ Name = "Ashwin", Age = 31},
                   new Employee(){ Name = "Bokil", Age = 25},
                   new Employee(){ Name = "Amit", Age = 28},
                   new Employee(){ Name = "Ajay", Age = 29},
                   new Employee(){ Name = "Sujay", Age = 26}
            });

            Employee tempEmployee = Array.Find(lstEmployee, tempPredicatePointer);
            var employeesBelow27 = Array.FindAll(lstEmployee, tempPredicatePointer);
            Console.WriteLine("Person below 27 age :" + tempEmployee.Name);

            foreach (var emp in employeesBelow27)
                Console.WriteLine("Person below 27 age :" + emp.Name);

            Console.ReadKey();


            //Converter Delegate:
            Converter<Employee, XEmployee> tempConvertorPointer
                = new Converter<Employee, XEmployee>(tempObj.ConvertToXEmployee);

            List<XEmployee> xEmployee = Array.ConvertAll(lstEmployee, tempConvertorPointer).ToList();
            Console.ReadKey();

        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class XEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public bool IsExEmployee
        {
            get { return true; }
        }
    }

    public class DelegateSample
    {
        public int FirstTestFunction(string strParameter, int intParamater)
        {
            Console.WriteLine("First Test Function Execution");
            Console.WriteLine(strParameter);
            return intParamater;
        }

        public int SecondTestFunction(string strParameter, int intParamater)
        {
            Console.WriteLine("Second Test Function Execution");
            Console.WriteLine(strParameter);
            return intParamater;
        }

        public void ThirdTestFunction(string strParameter, int intParamater)
        {
            Console.WriteLine("Third Test Function Execution");
            Console.WriteLine(strParameter);
        }

        public bool FourthTestFunction(Employee employee)
        {
            return employee.Age < 27;
        }

        public XEmployee ConvertToXEmployee(Employee employee)
        {
            return new XEmployee() { Name = employee.Name, Age = employee.Age };
        }

        public int SixTestFunction(Employee strParameter1, Employee strParamater2)
        {
            return strParameter1.Name.CompareTo(strParamater2.Name);
        }
    }
}



//Flavours Of Delegates

//1
//Func<TParameter, TOutput>

//Func is logically similar to base delegate implementation.The difference is in the way we declare. 
//At the time of declaration, we need to provide the signature parameter & its return type.

//First two parameters are the method input parameters. 
//3rd parameter (always the last parameter) is the out parameter which should be the output return type of the method.

//Func is always used when you have return object or type from method. 
//If you have void method, you should be using Action.


//2
//Action<TParameter>

//Action is used when we do not have any return type from method. 
//Method with void signature is being used with Action delegate.

//Action<string, int> tempActionPointer;
//Similar to Func delegate, the first two parameters are the method input parameters.
//Since we do not have return object or type, all the parameters are considered as input parameters.


//3
//Predicate<in T>

//Predicate is a function pointer for method which returns boolean value.
//They are commonly used for iterating a collection or to verify if the value does already exist.
//Declaration for the same looks like this:

//Predicate<Employee> tempPredicatePointer;

//For sample, I have created an Array which holds a list of Employees. 
//Predicate is used to get employee below age of 27: SEE MAIN METHOD ABOVE


//4
//Converter<TInput, TOutput>

//Convertor delegate is used when you need to migrate / convert one collection into another by using some algorithm. 
//Object A gets converted into Object B.


