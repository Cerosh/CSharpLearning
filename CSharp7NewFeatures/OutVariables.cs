using System;
namespace CSharp7NewFeatures
{
    public class OutVariables
    {
        public static void GetEmployeeDetails(out string EmployeeName, out string Gender, out long Salary, out string Department)
        {
            EmployeeName = "Cerosh Jacob";
            Gender = "Male";
            Salary = 20000;
            Department = "IT";
        }

        public void GetSecondEmployeeDetails(out string EmployeeName, out string Gender, out long Salary, out string Department)
        {
            EmployeeName = "Simi Kurup";
            Gender = "Female";
            Salary = 20000;
            Department = "IT";
        }
    }
}
