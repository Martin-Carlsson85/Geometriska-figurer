using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    class Program
    {
        /// <summary>
        /// Ska läsa in en figurs längs och bredd, skapa objekt och returna en refens till det. 
        /// Metoden ska ha en parameter av typen ShapeType vars värde bestämmer om en ellips eller rektangel ska skapas.
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns>En refens till objektet</returns>
        private static Shape CreatShape(ShapeType shapeType)
            {
           
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("=============================");

                if (shapeType == ShapeType.Rectangle)
                {
                    Console.WriteLine("=        Rektangel          =");
                }
                else
                {
                    Console.WriteLine("=        Ellips             =");
                }
                Console.WriteLine("=============================\n");
                Console.ResetColor();
  
                double length = ReadDoubleGreaterThanZero("Ange längden: ");
                double width = ReadDoubleGreaterThanZero("Ange höjden: ");

                if (shapeType == ShapeType.Rectangle)
                {
                    return new Rectangle(length, width);
                }
                else
                {
                    return new Ellipse(length, width);
                }
            }
    
        /// <summary>
        /// Metoden main anropar metoden ViewMenu för att visa menyn. Väljer användaren att inte avsluta applikationen ska metoden CreateShape anropas som skapar och
        /// returnerar en referens till ett ellips- eller rectangel-objekt.
        /// Referensen till objektet används sedan vid anrop av ViewDetail som presenterar figurens detaljer.
        /// När beräknigen är gjord visas menyn på nytt. 
        /// </summary>
        static void Main(string[] args)
        {
            do
            {
                ViewMenu();
                switch (Console.ReadLine())
                {
                    case "0":
                        return;
                    case "1":
                        ViewShapeDetail(CreatShape(ShapeType.Ellipse));
                        break;
                    case "2":
                        ViewShapeDetail(CreatShape(ShapeType.Rectangle));
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n Fel! Ange ett nummer mellan 0 och 2.");
                        Console.ResetColor();
                        break;
                }

                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n Tryck tangent för att fortsätta ");
                    Console.ResetColor();
                    Console.CursorVisible = false;
                    Console.ReadKey(true);
                    Console.CursorVisible = true;
            } 
            while (true);
            }

        /// <summary>
        /// Metoden returnerar ett värde av typen double som är större än 0. Man kan skicka ett argument till metoden. 
        /// Argumentet ska vara en sträng med info som ska visas där man matar in värdet.
        /// Om man matar in fel värde får man ett felmeddelande och en ny chans att mata in rätt värde.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns>Värdet av typen double </returns>
            private static double ReadDoubleGreaterThanZero(string prompt)
            {     
                double userInput;
                do
                {
                    Console.Write(prompt);
                    if (double.TryParse(Console.ReadLine(), out userInput) && userInput > 0d)
                    {
                        return userInput;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nVärdet måste vara ett tal större än 0!");
                        Console.ResetColor();
                    }
             
                }while (true);
            
            }
             
   
            /// <summary>
            /// Denna metoden har till uppgift att visa menyn
            /// </summary>
            private static void ViewMenu()
            {
                 
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("============================");
                Console.WriteLine("=                          =");
                Console.WriteLine("=   Geometriska Figurer    =");
                Console.WriteLine("=                          =");
                Console.WriteLine("============================");
                Console.ResetColor();
                Console.WriteLine("\n0. Avsluta\n\n1. Ellips\n\n2. Rekangel\n");
                Console.WriteLine("============================\n");
                Console.Write("Ange menyval [0-2]: ");
            }
             
            /// <summary>
            /// Denna metod har till uppgift att visa figurens alla detaljer.
            /// Vid anrop av metoden skickas ett argument med som referear till figuren och detaljerna ska prenseteras.
            /// Parametern Shape referer till figuren.
            /// Basklassen Shape överskuggar metoden ToString
            /// </summary>
            /// <param name="shape"></param>
            private static void ViewShapeDetail(Shape shape)
            {
           
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n==============================");
                Console.WriteLine("=         Detaljer           =");
                Console.WriteLine("==============================");
                Console.ResetColor();
                Console.WriteLine(shape.ToString());
            }
        }
     }
                
