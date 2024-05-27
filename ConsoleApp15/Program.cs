using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования
            TaxiSystem taxiSystem = new TaxiSystem();

            // Добавление такси в систему
            taxiSystem.AddTaxi(new Taxi { TaxiID = 1, DriverName = "Джон", CarModel = "Toyota", Available = true });
            taxiSystem.AddTaxi(new Taxi { TaxiID = 2, DriverName = "Алиса", CarModel = "Honda", Available = false });
            taxiSystem.AddTaxi(new Taxi { TaxiID = 3, DriverName = "Боб", CarModel = "Ford", Available = true });

            // Поиск доступного такси
            Taxi availableTaxi = taxiSystem.FindAvailableTaxi();
            if (availableTaxi != null)
            {
                Console.WriteLine($"Доступное такси: ID {availableTaxi.TaxiID}, Водитель {availableTaxi.DriverName}, Модель {availableTaxi.CarModel}");
            }
            else
            {
                Console.WriteLine("Нет доступного такси.");
            }

            // Добавление информации о количестве пользователей такси
            int worldwideTaxiUsersDaily = 1_000_000; // Примерное количество пользователей такси ежедневно во всем мире
            int countryTaxiUsersWeekly = 100_000; // Примерное количество пользователей такси еженедельно в стране
            int cityTaxiUsersMonthly = 50_000; // Примерное количество пользователей такси ежемесячно в городе

            Console.WriteLine($"Во всем мире пользуются такси ежедневно: {worldwideTaxiUsersDaily} человек");
            Console.WriteLine($"В нашей стране пользуются такси еженедельно: {countryTaxiUsersWeekly} человек");
            Console.WriteLine($"В нашем городе пользуются такси ежемесячно: {cityTaxiUsersMonthly} человек");

            // Обзор существующих информационных систем о наличии такси
            Console.WriteLine("Обзор существующих информационных систем о наличии такси:");
            Console.WriteLine("- Система А: ...");
            Console.WriteLine("- Система B: ...");
            Console.WriteLine("- Система C: ...");

            // Приведение данных о росте рынка такси за последние годы
            Console.WriteLine("Данные о росте рынка такси за последние годы:");
            Console.WriteLine("Год | Объем рынка (млн. $)");
            Console.WriteLine("2018 | 50");
            Console.WriteLine("2019 | 60");
            Console.WriteLine("2020 | 70");
            Console.WriteLine("2021 | 80");

            // Описание проблем, с которыми сталкиваются люди при поиске такси
            Console.WriteLine("Проблемы при поиске такси:");
            Console.WriteLine("- Долгие ожидания");
            Console.WriteLine("- Отсутствие свободных машин");
            Console.WriteLine("- Завышенные цены");

            // Преимущества использования информационных систем для отслеживания наличия такси
            Console.WriteLine("Преимущества использования информационных систем для отслеживания наличия такси:");
            Console.WriteLine("- Повышение эффективности работы служб такси");
            Console.WriteLine("- Улучшение качества обслуживания клиентов");
            Console.WriteLine("- Снижение времени ожидания такси");
            Console.WriteLine("- Увеличение прибыли служб такси");
            Console.WriteLine("- Снижение транспортных проблем в крупных городах");
            Console.ReadKey();
        }
    }
}
