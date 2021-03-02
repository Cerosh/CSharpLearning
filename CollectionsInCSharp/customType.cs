using System;
using System.Collections.Generic;

namespace CollectionsInCSharp
{
    public class CustomType
    {
        public void customTypeCreation()
        {
            List<User> users = new List<User>();
            users.Add(new User{ Name ="Cerosh",Age = 35, Email = "c@rosh.com",Phone = 12345});
            users.Add(new User{ Age = 9, Phone=34456, Email="r@ithu.com", Name="rithu"});
            users.Add(new User { Name = "rohan", Email = "r@ohan", Phone = 232342, Age = 15 });

            foreach (var item in users)
            {
                Console.WriteLine("The user {0} with age {1} has email {2} and phone {3}",item.Name, item.Age, item.Email, item.Phone);
            }
        }
    }
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public Int64 Phone { get; set; }
    }

}
