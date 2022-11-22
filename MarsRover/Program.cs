namespace MarsRover
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            int lineNumbers = 0;
            Console.WriteLine("Enter plateu size");
            string? input = Console.ReadLine();
            while (!String.IsNullOrEmpty(input) || input.ToLower() != "go")
            {
                if (input.ToLower() == "q")
                {
                    Console.WriteLine("Quit");
                    break;
                }
                else
                {
                    if (input.ToLower() == "r")
                    {
                        Console.WriteLine("Enter plateu size");
                    }
                 
                }

                if (lineNumbers == 0)
                {
               
                 
                    try
                    {
                        string[] sizeOfPlatou = input.Split(' ');
                    
                        Plateau plateau = new Plateau(Convert.ToInt32(sizeOfPlatou[0]), Convert.ToInt32(sizeOfPlatou[1]));
                        lineNumbers++;
                    }
                    catch (Exception ex) {
                        Console.WriteLine("Invalid input");
                        lineNumbers = 0;
                    }
                    
                }
                else if (lineNumbers % 2 == 1)
                {
                    string[] roverPosition = input.Split(' ');
                    Rover rover = new Rover(Convert.ToInt32(roverPosition[0]), Convert.ToInt32(roverPosition[1]), Convert.ToChar(roverPosition[2]));
                    lineNumbers++;
                }
                else if (lineNumbers % 2 == 0)
                {
                    //foreach (char command in input)
                    //{
                    //    rover.Move(command);
                    //}
                    //Console.WriteLine(rover.X + " " + rover.Y + " " + rover.Direction);
                    lineNumbers++;
                }
               
                input = Console.ReadLine();
            }
        }
    }
}









