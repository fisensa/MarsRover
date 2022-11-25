namespace MarsRover
{
    internal class Program
    {
        private static MarsRoverControl marsRoverControl = new MarsRoverControl();
        private static void Main(string[] args)
        {
            
            int lineNumbers = 0;
            Console.WriteLine("Enter plateu size");
            string? input = Console.ReadLine();
           
            while (!String.IsNullOrEmpty(input) || input.ToLower() != "go")
            {
                input = input.ToUpper();
                if (input == "Q")
                {
                    Console.WriteLine("Quit");
                    break;
                }
                else
                {
                    if (input == "R")
                    {
                        Console.WriteLine("Enter plateu size");
                        marsRoverControl = new MarsRoverControl();
                        lineNumbers = 0;
                    }
                 
                }

                if (lineNumbers == 0)
                {
               
                 
                    try
                    {
                        string[] sizeOfPlatou = input.Split(' ');
                    
                        marsRoverControl.Plateau = new Plateau(Convert.ToInt32(sizeOfPlatou[0]), Convert.ToInt32(sizeOfPlatou[1]));
                        Console.WriteLine("Enter position and heading");
                        lineNumbers++;
                    }
                    catch (Exception ex) {
                        Console.WriteLine("Invalid input");
                        lineNumbers = 0;
                    }
                    
                }
                else if (lineNumbers % 2 == 1)
                {
                  
                    lineNumbers++;
                    string[] roverPosition = input.Split(' ');
                    try
                    {
                        Rover rover = new Rover(Convert.ToInt32(roverPosition[0]), Convert.ToInt32(roverPosition[1]), Convert.ToChar(roverPosition[2]));
                        if (marsRoverControl.VerifyRoverPosition(rover.X, rover.Y))
                        {
                            if(rover.Direction.)
                            marsRoverControl.AddRover(rover);
                        }
                        else {
                            Console.WriteLine("Position unavailable, try again");
                            Console.WriteLine("Enter position and heading");
                            lineNumbers--;
                        }
                    }
                    catch (Exception ex) {
                        Console.WriteLine("Invalid input, please try again");
                        Console.WriteLine("Enter position and heading");
                        lineNumbers--;
                    }
                    
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









