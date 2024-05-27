using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    enum UserRole
    {
        Администратор,
        Модератор,
        Пользователь,
        Гость
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вашу роль: ");
            string userRoleInput = Console.ReadLine();

            UserRole userRole;
            if (Enum.TryParse(userRoleInput, true, out userRole))
            {
                switch (userRole)
                {
                    case UserRole.Администратор:
                        Console.WriteLine("Вы зарегистрированы как администратор.");
                        break;
                    case UserRole.Модератор:
                        Console.WriteLine("Вы зарегистрированы как модератор.");
                        break;
                    case UserRole.Пользователь:
                        Console.WriteLine("Вы зарегистрированы как пользователь.");
                        break;
                    case UserRole.Гость:
                        Console.WriteLine("Вы зарегистрированы как гость.");
                        break;
                    default:
                        Console.WriteLine("Некорректное значение роли.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некорректное значение роли.");
            }

            Console.WriteLine("Нажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
