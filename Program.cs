using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            string FamilyName = "None";
            bool x = true;
            Console.WriteLine("Создание новой учетной записи для пользователя\n");
            Console.Write("Введите имя пользователя: ");
            string Name = Console.ReadLine();
            Console.Write("Введите фамилию пользователя: ");
            string Surename = Console.ReadLine();
            Console.Write("Введите отчество пользователя: ");
            try
            {
                FamilyName = Console.ReadLine();
            }
            catch
            {
                x = false;
            }
            Console.Write("Введите логин пользователя: ");
            string Login = Console.ReadLine();
            Console.Write("Введите пароль пользователя: ");
            string Password = Console.ReadLine();
            Console.Write("Введите гендер: ");
            string Gender = Console.ReadLine();
            Console.Write("Введите должность: ");
            string Title = Console.ReadLine();
            string HashPassword = HashPasswords.Hash.Password(Password);
            Console.WriteLine("Хешированный паоль пользвателя: "+HashPassword);
            Model.LibraryBase db = new Model.LibraryBase();
            Model.Employee employee = new Model.Employee();
            employee.Name = Name;
            employee.Surename = Surename;
            if (x) { employee.FamilyName = FamilyName; }    
            else { employee.FamilyName = "-"; }
            employee.Login = Login;
            employee.Password = HashPassword;
            employee.Gender = Convert.ToInt32(Gender);
            employee.JobTitle = Convert.ToInt32(Title);
            db.Employee.Add(employee);
            db.SaveChanges();
            //if (db.Employee.Last().Login == Login)
            //{
            //    Console.WriteLine("Пользователь успешно добавлен");
            //}
            //else
            //{
            //    Console.WriteLine("Пользователь не добавлен");
            //}

        }
    }
}
