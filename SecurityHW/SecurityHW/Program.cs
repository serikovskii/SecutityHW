using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityHW
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new SecurityContext())
            {
                var visitor = new Visitor();

                Console.WriteLine("Введите имя посетителя:");
                visitor.FullName = Console.ReadLine();

                Console.WriteLine("Введите ИИН посетителя:");
                visitor.IIN = Console.ReadLine();

                Console.WriteLine("Введите цель посещения посетителя:");
                visitor.Purpose = Console.ReadLine();

                Console.WriteLine("Введите дату и время прихода посетителя (дд.мм.гггг.чч:мм):");
                visitor.DateTimeArrival = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);

                Console.WriteLine("Введите дату и время ухода посетителя (дд.мм.гггг чч:мм):");
                visitor.DateTimeDeparture = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);

                Console.WriteLine("Посетитель добавлен");
                context.Visitors.Add(visitor);
                context.SaveChanges();
            }
        }
    }
}
