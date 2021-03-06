using System.Collections.Generic;
using System;

namespace Series
{
    class Program
    {
        private static serieRepository repository = new serieRepository();
        static void Main(string[] args)
        {                    
            string userOption = getUserOption(); 

            Console.WriteLine("--------------");

            while (userOption != "X")
            {
                switch (userOption)
                {
                    case "1":
                        ShowAllSeries();
                        break;

                    case "2":
                        AddSerie();
                        break;

                    case "3":
                        UpdateSerie();
                        break;

                    case "4":
                        DeleteSerie();
                        break;

                    case "5":
                        FindSerieById();
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                        
                }
                userOption = getUserOption();
            }

            Console.WriteLine("Thank you! Bye bye.");
        }

        private static void FindSerieById(){
            Console.WriteLine("show serie");
            Console.WriteLine();

            Console.WriteLine("Inform ID to show: ");
            int idIn = int.Parse(Console.ReadLine());
            Serie serie = repository.FindById(idIn);
            Console.WriteLine(serie);

        }

        private static void DeleteSerie(){
            Console.WriteLine("Update serie");
            Console.WriteLine();

            Console.WriteLine("Inform ID to delete: ");
            int idIn = int.Parse(Console.ReadLine());

            repository.Delete(idIn);

        }

        private static void AddSerie(){
            Console.WriteLine("Add series");
            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genre), i));    
            }    
            Console.WriteLine("Inform gender according to the options above: ");
            int genreIn = int.Parse(Console.ReadLine());

            Console.WriteLine("Inform the title: ");
            string titleIn = Console.ReadLine();

            Console.WriteLine("Inform the year of serie: ");
            int yearIn = int.Parse(Console.ReadLine());

            Console.WriteLine("Inform a description: ");
            string descriptionIn = Console.ReadLine();

            Serie serie = new Serie(id: repository.NextId(),
                                    title: titleIn, 
                                    description: descriptionIn, 
                                    genre:(Genre)genreIn, 
                                    year: yearIn);

            repository.Add(serie);

        }

        private static void UpdateSerie(){
            Console.WriteLine("Update serie");
            Console.WriteLine();

            Console.WriteLine("Inform ID to update: ");
            int idIn = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genre), i));    
            }    
            Console.WriteLine("Inform gender according to the options above: ");
            int genreIn = int.Parse(Console.ReadLine());

            Console.WriteLine("Inform the title: ");
            string titleIn = Console.ReadLine();

            Console.WriteLine("Inform the year of serie: ");
            int yearIn = int.Parse(Console.ReadLine());

            Console.WriteLine("Inform a description: ");
            string descriptionIn = Console.ReadLine();
            
            Serie serie = new Serie(id: idIn,
                                    title: titleIn, 
                                    description: descriptionIn, 
                                    genre:(Genre)genreIn, 
                                    year: yearIn);
            repository.Update(idIn, serie);            

        }

        private static void ShowAllSeries(){
            Console.WriteLine("Show all series");
            var list = repository.List();
            if (list.Count > 0) {
                foreach (var serie in list)
                {
                    Console.WriteLine("#ID {0}: {1}", serie.Id, serie.title);
                }
            } else {
                Console.WriteLine("List of series is empty");
            }
        }

        private static string getUserOption() {
            ShowMenu();
            return Console.ReadLine().ToUpper();
        } 

        private static void ShowMenu() {
            Console.WriteLine("----- S E R I E S ------");
            Console.WriteLine("1 - Show all series");
            Console.WriteLine("2 - Add new serie");
            Console.WriteLine("3 - Update serie");
            Console.WriteLine("4 - Delete serie");
            Console.WriteLine("5 - Find serie by id");
            Console.WriteLine("C - Clear");
            Console.WriteLine("X - Exit");
            Console.WriteLine();
            Console.WriteLine("which do you prefer?");            
        }
    }
}
