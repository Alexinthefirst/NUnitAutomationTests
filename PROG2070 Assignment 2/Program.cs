using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNumber = false;
            bool isGreaterThanZero = false;
            String[] sides = new string[2];

            Console.WriteLine("Please enter the length and width of the rectangle, seperated by x (5x6).");

            // Parse the input for invalids and 0's

            while (!isGreaterThanZero || isNumber == false) {

                String input = Console.ReadLine();

                sides = input.Split('x');

                foreach (String side in sides)
                {
                    isNumber = Int32.TryParse(side, out _);
                }

                if (!isNumber)
                {
                    Console.WriteLine("Please enter a valid integer.");
                }

                if (isNumber && (Int32.Parse(sides[0]) <= 0 || Int32.Parse(sides[1]) <= 0))
                {
                    isGreaterThanZero = false;
                }
                else
                {
                    isGreaterThanZero = true;
                }

                if (!isGreaterThanZero)
                {
                    Console.WriteLine("Please enter an integer greater than 0.");
                }

            }

            // Create the rectangle with the provided sides
            Rectangle rect = new Rectangle(Int32.Parse(sides[0]), Int32.Parse(sides[1]));

            //Console.WriteLine("Rectangle Length: " + rect.GetLength() + " Rectangle Width: " + rect.GetWidth());
            //Console.ReadLine();

            int menuInput = 0;

            // While we haven't exited, keep going
            while (menuInput != 7)
            {
                Console.WriteLine("1. Get Rectangle Length\n" +
                                  "2. Change Rectangle Length\n" +
                                  "3. Get Rectangle Width\n" +
                                  "4. Change Rectangle Width\n" +
                                  "5. Get Rectangle Perimeter\n" +
                                  "6. Get Rectangle Area\n" +
                                  "7. Exit");
                menuInput = getInput();

                switch (menuInput)
                {
                    case 1:
                        Console.WriteLine("\nRectangle Length: " + rect.GetLength() + "\n");
                        break;
                    case 2:
                        
                        int nLength = 0;
                        while (!inputValid(nLength))
                        {
                            Console.WriteLine("\nNew Length: ");

                            String inputLength = Console.ReadLine();

                            bool isValidNumber = Int32.TryParse(inputLength, out _);

                            if (isValidNumber)
                            {
                                nLength = Int32.Parse(inputLength);
                            }

                        }

                        rect.SetLength(nLength);

                        break;
                    case 3:
                        Console.WriteLine("\nRectangle Width: " + rect.GetWidth() + "\n");
                        break;
                    case 4:

                        int nWidth = 0;
                        while (!inputValid(nWidth))
                        {
                            Console.WriteLine("\nNew Width: ");

                            String inputLength = Console.ReadLine();

                            bool isValidNumber = Int32.TryParse(inputLength, out _);

                            if (isValidNumber)
                            {
                                nWidth = Int32.Parse(inputLength);
                            }

                        }

                        rect.SetWidth(nWidth);

                        break;
                    case 5:
                        Console.WriteLine("\nRectangle Perimeter: " + rect.GetPerimeter() + "\n");
                        break;
                    case 6:
                        Console.WriteLine("\nRectangle Area: " + rect.GetArea() + "\n");
                        break;
                    case 7:
                        System.Environment.Exit(0);
                        break;
                }

            }

        }

        /// <summary>
        /// Used to parse input and feed it back to the main function
        /// </summary>
        /// <returns>input</returns>
        public static int getInput()
        {
            String input = Console.ReadLine();
            bool isInt = Int32.TryParse(input, out _);

            if (!isInt)
            {
                return 0;
            }
            else
            {
                return Int32.Parse(input);
            }
        }

        /// <summary>
        /// Checks if the input is valid for changing sides
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool inputValid(int value)
        {
            if (value >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }  
        }
    }
}
