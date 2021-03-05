using System;
using System.Collections.Generic;

namespace CSharp7NewFeatures
{
    public class ExpressionBodiesMembers
    {
        
    }
    public class ExpressionBodiedMethods
    {
        private string FirstName;
        private string LastName;
        public ExpressionBodiedMethods(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string GetFullName() => $"{FirstName} {LastName}";
        public override string ToString() => $"{FirstName} {LastName}";
        public void DisplayName() => Console.WriteLine(GetFullName());
    }

    public class ExpressionBodiedConstructor
    {
        private string locationName;
        public ExpressionBodiedConstructor(string name) => locationName = name;
        public string Name
        {
            get => locationName;
            set => locationName = value;
        }
    }

    public class ExprBodiedGettersnSetters
    {
        public Dictionary<int, double> EmpBasicSalaryList = new Dictionary<int, double>();
        public int EmpId { get; set; }
        public double EmpBasicSalary
        {
            get => EmpBasicSalaryList[EmpId];
            set => EmpBasicSalaryList[EmpId] = value;
        }
    }
}
