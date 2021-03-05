using System;
namespace CSharp7NewFeatures
{
    public class ThrownExpression
    {
        public string FullName { get; }
        public ThrownExpression(string name) => FullName = name ?? throw new ArgumentNullException(name);
        public string GetFirstName()
        {
            var parts = FullName.Split(' ');
            return (parts.Length > 1) ? parts[0] : throw new InvalidOperationException("Method:GetFirstName, Full Name is not available");
        }
        public string GetLastName() => throw new NotImplementedException("Method GetLastName is not Implemented");

        public void TryWithNameNull()
        {
            try
            {
                new ThrownExpression(null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType() + ": " + ex.Message);
            }
        }
        public void TryGetFirstName()
        {
            try
            {
                new ThrownExpression("Cerosh").GetFirstName();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType() + ": " + ex.Message);
            }
        }
        public void TryGetLastName()
        {
            try
            {
                new ThrownExpression("Cerosh").GetLastName();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType() + ": " + ex.Message);
            }
        }
    }
}
