using System;
using System.Reflection.Metadata;

namespace lab.work._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Checkpoint checkpoint = new Checkpoint();
            Human first = new Student() { Name = "Алешка", IsHaveMask = false, IsHaveQR = true };
            Human second = new Student() { Name = "Петрушка", IsHaveMask = true, IsHaveQR = true };
            Human third = new Enrollee() { Name = "Ивашка", IsHaveMask = false, IsHaveQR = false };
            Human main = new Teacher() { Name = "МОНа Семеновна ТРавкина", IsHaveMask = true, IsHaveQR = true };
            Animal doo = new Dog() { Name = "Скуби", IsHaveMask = false};
            Animal soldier = new Dove() { Name = "Вэлиант"};
            Animal flyer = new Squirrel() { Name = "Летяга"};
            checkpoint.VisitorsWantTo.Add(first);
            checkpoint.VisitorsWantTo.Add(second);
            checkpoint.VisitorsWantTo.Add(third);
            checkpoint.VisitorsWantTo.Add(main);
            checkpoint.VisitorsWantTo.Add(doo);
            checkpoint.VisitorsWantTo.Add(soldier);
            checkpoint.VisitorsWantTo.Add(flyer);

            Console.WriteLine($"Масок в наличии {checkpoint.Masks} шт.");
            Console.WriteLine($"Дезинфекций осталось {checkpoint.DisInfections}...\n");
            Console.WriteLine("Те, кто хочет пройти:\n");

            foreach (IVisitor visitor in checkpoint.VisitorsWantTo)
                Console.WriteLine(((IVisitor)visitor).Name);

            checkpoint.Check();
            
            Console.WriteLine("\nТе, кто может пройти:\n");
            foreach (IVisitor visitor in checkpoint.VisitorsCanTo)
                Console.WriteLine(((IVisitor)visitor).Name);

            Console.WriteLine($"\nМасок в наличии {checkpoint.Masks} шт.");
            Console.WriteLine($"Дезинфекций осталось {checkpoint.DisInfections} раз\n");
        }
    }
}
