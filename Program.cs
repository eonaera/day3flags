using System;

namespace day3flags
{
    class Program
    {
        static void Main(string[] args)
        {
            //PadikiGER(4, 5, 10);
            //PadikiGERfancy(4, 5, 10);
            //PadikiSUI(2, 6, 12);
            PadikiSUIfancy(3, 8, 16);
        }
        static void PadikiGER(int flatPerFloor, int padikiCount, int floorCount)
        {
            Console.WriteLine("Germany");
            Console.WriteLine($"We have a {floorCount}-storey house with {padikiCount} padiks and {flatPerFloor} flats per floor");
            Console.WriteLine($"flats In House:{flatPerFloor * floorCount * padikiCount}");
            if (floorCount < 3)
            {
                Console.WriteLine("Sorry. Your house is too small to use German flag lighting");
            }
            else
            {
                int ostatok = floorCount % 3;
                if (ostatok != 0)
                {
                    Console.WriteLine($"Your first {ostatok} floors doesn't be lit");
                }
                else
                {
                    Console.WriteLine("aLL flats work");
                }
                int flatnumber = 1;
                for (int padik = 1; padik <= padikiCount; padik++)
                {
                    for (int floor = 1; floor <= floorCount; floor++)
                    {
                        for (int flatFloor = 1; flatFloor <= flatPerFloor; flatFloor++)
                        {
                            if (floor <= ostatok)
                            {
                                Console.WriteLine($"Flat{flatnumber} is off");
                            }
                            else
                            {
                                if (floor > ((floorCount - ostatok) / 3 * 2 + ostatok))
                                {
                                    Console.WriteLine($"Flat{flatnumber} is black");
                                }
                                else
                                {
                                    if (floor > ((floorCount - ostatok) / 3 + ostatok))
                                    {
                                        Console.WriteLine($"Flat{flatnumber} is red");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Flat{flatnumber} is yellow");
                                    }
                                }
                            }
                            flatnumber++;
                        }
                    }
                }
            }
        }
        static void PadikiGERfancy(int flatPerFloor, int padikiCount, int floorCount)
        {
            Console.WriteLine($"We have a {floorCount}-storey house with {padikiCount} padiks and {flatPerFloor} flats per floor");
            Console.WriteLine($"flats In Houes:{flatPerFloor * floorCount * padikiCount}");
            if (floorCount < 3)
            {
                Console.WriteLine("Sorry. Your house is too small to use German flag lighting");
            }
            else
            {
                int ostatok = floorCount % 3;
                if (ostatok != 0)
                {
                    Console.WriteLine($"Your first {ostatok} floor(s) is(are) not lit");
                }
                else
                {
                    Console.WriteLine("aLL flats work");
                }
                for (int floor = floorCount; floor > 0; floor--)
                {
                    for (int padik = padikiCount; padik > 0; padik--)
                    {
                        for (int flatFloor = flatPerFloor; flatFloor > 0; flatFloor--)
                        {
                            if (floor <= ostatok)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("*");
                            }
                            else
                            {
                                if (floor > ((floorCount - ostatok) / 3 * 2 + ostatok))
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write("*");
                                }
                                else
                                {
                                    if (floor > ((floorCount - ostatok) / 3 + ostatok))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("*");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("*");
                                    }
                                }
                            }
                        }
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void PadikiSUI(int flatPerFloor, int padikiCount, int floorCount)
        {
            Console.WriteLine("Switzerland");
            Console.WriteLine($"We have a {floorCount}-storey house with {padikiCount} padiks and {flatPerFloor} flats per floor");
            Console.WriteLine($"flats In House:{flatPerFloor * floorCount * padikiCount}");
            if ((floorCount < 5) & (padikiCount < 5))
            {
                Console.WriteLine("Sorry. Your house is too small to use Swiss flag lighting");
            }
            else
            {
                int ostatokf = floorCount % 5;
                if (ostatokf != 0)
                {
                    Console.WriteLine($"Your first {ostatokf} floors don't be lit");
                }
                else
                {
                    Console.WriteLine("aLL flats work");
                }
                int flatnumber = 1;
                int ostatokp = floorCount % 5;
                for (int padik = 1; padik <= padikiCount; padik++)
                {
                    for (int floor = 1; floor <= floorCount; floor++)
                    {
                        for (int flatFloor = 1; flatFloor <= flatPerFloor; flatFloor++)
                        {
                            if (floor <= ostatokf)
                            {
                                Console.WriteLine($"Flat{flatnumber} is off");
                            }
                            else
                            {
                                if ((floor <= ((floorCount - ostatokf) / 5 * 2 + ostatokf)) & (floor > ((floorCount - ostatokf) / 5 + ostatokf)) & (padik > ((padikiCount - ostatokp) / 5*2 + ostatokp)) & (padik <= ((padikiCount - ostatokp) / 5 * 3 + ostatokp)))
                                {
                                    Console.WriteLine($"Flat{flatnumber} is white");
                                }
                                else
                                {
                                    if ((floor <= ((floorCount - ostatokf) / 5 * 3 + ostatokf)) & (floor > ((floorCount - ostatokf) / 5 * 2 + ostatokf)) & (padik > ((padikiCount - ostatokp) / 5 + ostatokp)) & (padik <= ((padikiCount - ostatokp) / 5 * 4 + ostatokp)))
                                    {
                                        Console.WriteLine($"Flat{flatnumber} is white");
                                    }
                                    else
                                    {
                                        if ((floor <= ((floorCount - ostatokf) / 5 * 4 + ostatokf)) & (floor > ((floorCount - ostatokf) / 5 * 3 + ostatokf)) & (padik > ((padikiCount - ostatokp) / 5 * 2 + ostatokp)) & (padik <= ((padikiCount - ostatokp) / 5 * 3 + ostatokp)))
                                        {
                                            Console.WriteLine($"Flat{flatnumber} is white");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Flat{flatnumber} is red");
                                        }
                                    }
                                }
                            }
                            flatnumber++;
                        }
                    }
                }
            }
        }
        static void PadikiSUIfancy(int flatPerFloor, int padikiCount, int floorCount)
        {
            Console.WriteLine("Switzerland");
            Console.WriteLine($"We have a {floorCount}-storey house with {padikiCount} padiks and {flatPerFloor} flats per floor");
            Console.WriteLine($"flats In House:{flatPerFloor * floorCount * padikiCount}");
            if ((floorCount < 5) & (padikiCount < 5))
            {
                Console.WriteLine("Sorry. Your house is too small to use Swiss flag lighting");
            }
            else
            {
                int ostatokf = floorCount % 5;
                if (ostatokf != 0)
                {
                    Console.WriteLine($"Your first {ostatokf} floors don't be lit");
                }
                else
                {
                    Console.WriteLine("aLL flats work");
                }
                int ostatokp = floorCount % 5;
                for (int floor = floorCount; floor > 0; floor--)
                {
                    for (int padik = 1; padik <= padikiCount; padik++)
                    {
                        for (int flatFloor = flatPerFloor; flatFloor > 0; flatFloor--)
                        {
                            if (floor <= ostatokf)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("*");
                            }
                            else
                            {
                                if ((floor <= ((floorCount - ostatokf) / 5 * 2 + ostatokf)) & (floor > ((floorCount - ostatokf) / 5 + ostatokf)) & (padik > ((padikiCount - ostatokp) / 5 * 2 + ostatokp)) & (padik <= ((padikiCount - ostatokp) / 5 * 3 + ostatokp)))
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("*");
                                }
                                else
                                {
                                    if ((floor <= ((floorCount - ostatokf) / 5 * 3 + ostatokf)) & (floor > ((floorCount - ostatokf) / 5 * 2 + ostatokf)) & (padik > ((padikiCount - ostatokp) / 5 + ostatokp)) & (padik <= ((padikiCount - ostatokp) / 5 * 4 + ostatokp)))
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.Write("*");
                                    }
                                    else
                                    {
                                        if ((floor <= ((floorCount - ostatokf) / 5 * 4 + ostatokf)) & (floor > ((floorCount - ostatokf) / 5 * 3 + ostatokf)) & (padik > ((padikiCount - ostatokp) / 5 * 2 + ostatokp)) & (padik <= ((padikiCount - ostatokp) / 5 * 3 + ostatokp)))
                                        {
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Write("*");
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write("*");
                                        }
                                    }
                                }
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}