using System;
using System.Collections.Generic;

namespace CSharp7NewFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Out Variables");
            OutVariables.GetEmployeeDetails(out var EmployeeName, out var Gender, out var Salary, out var Department);
            Console.WriteLine($"Name is {EmployeeName} and gender is {Gender} with salary {Salary} from the department {Department}");
            OutVariables obj = new OutVariables();
            obj.GetSecondEmployeeDetails(out var EmployeeName2, out var Gender2, out var Salary2, out var Department2);
            Console.WriteLine($"Name is {EmployeeName2} and gender is {Gender2} with salary {Salary2} from the department {Department2}");

            Console.WriteLine("Pattern Matching");
            DisplayAreaClass dac = new DisplayAreaClass();
            Circle circle = new Circle(10);
            dac.DisplayAreaMethod(circle);
            Rectangle rectangle = new Rectangle(10, 5);
            dac.DisplayAreaMethod(rectangle);
            Triangle triangle = new Triangle(10, 5);
            dac.DisplayAreaMethod(triangle);

            Console.WriteLine("Tuples");
            var values = new List<double>() { 10, 20, 30, 40, 50 };
            Tuples TObj = new Tuples();
            var (countResult, SumResult, ProResult) = TObj.Calulate(values);
            Console.WriteLine($"There are {countResult} values and their sum is {SumResult} and product is {ProResult}");

            Console.WriteLine("ExpressionBodie");
            ExpressionBodiedMethods expressionMethod = new ExpressionBodiedMethods("Cerosh", "Jacob");
            expressionMethod.DisplayName();
            Console.WriteLine(expressionMethod);
            ExpressionBodiedConstructor expressionConstructor = new ExpressionBodiedConstructor("Cerosh");
            Console.WriteLine(expressionConstructor.Name);
            var expressionGetterSetter = new ExprBodiedGettersnSetters();
            expressionGetterSetter.EmpBasicSalaryList.Add(101, 1000);
            expressionGetterSetter.EmpBasicSalaryList.Add(102, 15000);
            expressionGetterSetter.EmpId =101;
            Console.WriteLine($"The basic salary of EmpId {expressionGetterSetter.EmpId} is: {expressionGetterSetter.EmpBasicSalary}");
            expressionGetterSetter.EmpBasicSalary = 1300;
            Console.WriteLine($"The basic salary of EmpId {expressionGetterSetter.EmpId} is: {expressionGetterSetter.EmpBasicSalary}");

            var thrownExpression = new ThrownExpression("Cerosh");
            thrownExpression.TryWithNameNull();
            thrownExpression.TryGetFirstName();
            thrownExpression.TryGetLastName();
        }


    }
}
