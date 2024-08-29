using FireWolf.Models;
using System.ComponentModel.DataAnnotations;

namespace FireWolf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new AppDbContext();

            var user = new Users()
            {
                userName = "soso",
                password = "1234",
                email = "soso@gmail.com"

            };

            var context = new ValidationContext(user);
            var errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(user, context, errors, true))
            {
                foreach (var validationResult in errors) 
                {
                    Console.WriteLine(validationResult);
                }
            }
            else
            {
            db.Users.Add(user);
            db.SaveChanges();

            }






            //var user = new Users()
            //{
            //    userName = "testing",
            //    email = "test@gmail.com"
            //};

            //db.Users.Add(user);

            //var user = db.Users.Find(3);

            //if (user != null)
            //{
            //    Console.WriteLine(user.userName);
            //   // user.userName = "sameh";
            //    db.Users.Remove(user);
            //    db.SaveChanges();
            //}
            //else
            //{
            //    Console.WriteLine("nothing");
            //}
        }
    }
}
