using System;

namespace FigureSkating
{
    class FigureSkater
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public string Country {get; set;}
        public string Level {get; set;}

        public void Greet()
        {
            Console.WriteLine($"Фигурист {Name} приветствует судей и зрителей!!");
        }

        public void WarmUp()
        {
            Console.WriteLine($"{Name} разминается перед выступление!!");
        }

        public virtual void PerformElement()
        {
            Console.WriteLine($"{Name} выполняет стандартный элемент программы и это прыжок!!");
        }

        public virtual void ShowStyle()
        {
            Console.WriteLine($"Стиль катания {Name} - классический, но прыгает двойные!!");
        }

        public void Train()
        {
            Console.WriteLine($"{Name} посещает групповые тренировки 3 раза в неделю, что базово для любителя!");
        }

        public void Compete()
        {
            Console.WriteLine($"{Name} участвует в городских соревнованиях!!");
        }
    }

    class ProFigureSkater : FigureSkater
    {
        public string CoachName {get; set;}
        public string CurrentProgram {get; set;}

        public override void PerformElement()
        {
            Console.WriteLine($"Вау, {Name} выполняет сложный каскад прыжков: четверной тулуп и тройной аксель!");
        }

        public override void ShowStyle()
        {
            Console.WriteLine($"Уникальный стиль {Name} сочетает современную хореографию с техникой высшего уровня");
        }

        public new void Train()
        {
            Console.WriteLine($"{Name} тренируется ежедневно по 5-6 часов под руководством {CoachName}, что соответствует профи");
        }

        public new void Compete()
        {
            Console.WriteLine($"{Name} выступает в программе '{CurrentProgram}' на международных чемпионатах!");
        }

        public void ShowAchievements()
        {
            Console.WriteLine($"Достижения {Name}:");
            Console.WriteLine($"Возраст: {Age} лет");
            Console.WriteLine($"Страна: {Country}");
            Console.WriteLine($"Тренер: {CoachName}");
            Console.WriteLine($"Программа: {CurrentProgram}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тема: Фигуристы\n");

            ProFigureSkater skater = new ProFigureSkater();
            skater.Name = "Александра Трусова";
            skater.Age = 18;
            skater.Country = "Россия";
            skater.Level = "мастер спорта и участница олимпийских игр 2022 года";
            skater.CoachName = "Этери Тутберидзе";
            skater.CurrentProgram = "Круэлла";

            Console.WriteLine("1.. Вызов базового класса:");
            skater.Greet();
            skater.WarmUp();
            Console.WriteLine();

            Console.WriteLine("2.. Полиморфизм:");
            FigureSkater baseSkater = skater;
            baseSkater.PerformElement();
            baseSkater.ShowStyle();
            Console.WriteLine();

            Console.WriteLine("3.. Вызов скрытых методов через производный класс:");
            skater.Train();
            skater.Compete();
            Console.WriteLine();

            Console.WriteLine("4.. Вызов скрытых методов через базовый класс:");
            baseSkater.Train();
            baseSkater.Compete();
            Console.WriteLine();

            Console.WriteLine("5.. Вызов собственного метода производного класса:");
            skater.ShowAchievements();
        }
    }
}