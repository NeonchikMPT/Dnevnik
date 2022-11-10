using System;

namespace Zametka
{
    internal class Program
    {
        static DateTime Time = DateTime.Now;
        static int TudaSuda = 0;
        static int Dela = 2;
        static void Main(string[] args)
        {
            Zametka a = new Zametka()
            {
                Day = 6,
                name = "Сделать практические",
                opisanie = "Описание: Сделать практические по ИТ и ОАИП"
            };
            Zametka.zametki.Add(a);
            Zametka b = new Zametka()
            {
                Day = 6,
                name = "Встретиться с друзьями",
                opisanie = "Описание: Встретиться с друзьями и пойти гулять в Парк Горького"
            };
            Zametka.zametki.Add(b);
            Zametka c = new Zametka()
            {
                Day = 6,
                name = "Выступить на концерте",
                opisanie = "Описание: Приехать в МПТ и выступить на концерте для первакурсников"
            };
            Zametka.zametki.Add(c);
            Zametka d = new Zametka()
            {
                Day = 7,
                name = "Пойти на учебу",
                opisanie = "Описание: Пойти на пары + генеральная репетиция"
            };
            Zametka.zametki.Add(d);
            Zametka e = new Zametka()
            {
                Day = 8,
                name = "Волейбол",
                opisanie = "Описание: Приехать на Нахимовский проспект и поучаствовать на соревнованиях"
            };
            Zametka.zametki.Add(e);
            Zametka f = new Zametka()
            {
                Day = 8,
                name = "РЭУ",
                opisanie = "Описание: Поехать в РЭУ и выиграть турнир по бильярду"
            };
            Zametka.zametki.Add(f);
            Zametka g = new Zametka()
            {
                Day = 9,
                name = "Зал",
                opisanie = "Описание: Сходить вечерком в зал"
            };
            Zametka.zametki.Add(g);
            Zametka h = new Zametka()
            {
                Day = 9,
                name = "Бассейн",
                opisanie = "Описание: Сходить по плавать и расслабить свои мышцы, и я снять напряжение"
            };
            Zametka.zametki.Add(h);
            Zametka i = new Zametka()
            {
                Day = 10,
                name = "Тренировка",
                opisanie = "Описание: Встретить парочку людей и начать тренировку в бильярдном зале"
            };
            Zametka.zametki.Add(i);

            while (true)
            {
                Alfavite();
                Clavishka();
                Strelochechka();
            }
        }


        private static void Alfavite()
        {
            int mestniiyNomerok = 0;
            Console.SetCursorPosition(4, 1);
            Console.WriteLine($"Заметки на эту дату: {Time.AddDays(TudaSuda).Day}.{Time.AddDays(TudaSuda).Month}.{Time.AddDays(TudaSuda).Year}");
            foreach (var elementik in Zametka.zametki)
            {
                if (elementik.Day == Time.AddDays(TudaSuda).Day)
                {
                    mestniiyNomerok++;
                    Console.SetCursorPosition(4, mestniiyNomerok + 1);
                    elementik.Number = mestniiyNomerok;
                    Console.Write($"{elementik.Number}.{elementik.name}\n");
                }
            }

        }
        private static void Clavishka()
        {
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    TudaSuda--;
                    break;
                case ConsoleKey.RightArrow:
                    TudaSuda++;

                    break;
                case ConsoleKey.UpArrow:
                    if (Dela < 3)
                    {
                        Dela = 2;
                    }
                    else
                    {
                        Dela--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (Dela > 3)
                    {
                        Dela = 4;
                    }
                    else
                    {
                        Dela++;
                    }
                    break;
                case ConsoleKey.Enter:
                    Pometochkka();
                    Console.ReadKey();
                    break;
                case ConsoleKey.Escape:
                    System.Environment.Exit(0);
                    break;
            }
        }

        private static void Pometochkka()
        {
            int mestniiyNomerok = 0;
            Console.Clear();
            foreach (var elementik in Zametka.zametki)
            {
                if (elementik.Day == Time.AddDays(TudaSuda).Day)
                {
                    mestniiyNomerok++;
                    elementik.Number = mestniiyNomerok;
                    if (mestniiyNomerok == Dela - 1)
                    {
                        Console.Write($"  {elementik.name}\n");
                        Console.Write(" " + elementik.opisanie);
                    }
                }
            }
        }

        private static void Strelochechka()
        {
            Console.Clear();
            Console.SetCursorPosition(0, Dela);
            Console.Write("-->");
        }
    }
}