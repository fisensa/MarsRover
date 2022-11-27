namespace MarsRover
{
    internal class Program
    {
        private static MarsRoverControl marsRoverControl = new MarsRoverControl();
        private static void Main(string[] args)
        {
            Rover rover = new Rover(); ;
            int lineNumbers = 0;
            Console.WriteLine("Enter plateu size");
            string? input = Console.ReadLine();
           

            while (!String.IsNullOrEmpty(input) || input.ToLower() != "go")
            {
                input = input.ToUpper();
                //if command given is q, stop reading input and exit the loop
                if (input == "Q")
                {
                    Console.WriteLine("Quit");
                    break;
                }
                else
                {
                    //if command is r, reset and start from begining
                    if (input == "R")
                    {
                        Console.WriteLine("Enter plateu size");
                        marsRoverControl = new MarsRoverControl();
                        lineNumbers = 0;
                    }
                 
                }
                //platou size
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
                //rover position and orientation
                else if (lineNumbers % 2 == 1)
                {
                  
                    lineNumbers++;
                    string[] roverPosition = input.Split(' ');
                    try
                    {
                        if (marsRoverControl.VerifyRoverPosition(Int32.Parse(roverPosition[0]), Int32.Parse(roverPosition[1])))
                        {
                            if (roverPosition[2].All(c => "NWES".Contains(c)))
                            {
                               
                                rover = new Rover(Convert.ToInt32(roverPosition[0]), Convert.ToInt32(roverPosition[1]), roverPosition[2]);
                                Console.WriteLine("Enter commands");

                            }
                            else {
                                Console.WriteLine("Invalid direction, try again");
                                Console.WriteLine("Enter position and heading");
                                lineNumbers--;
                            }
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
                //commands to move/rotate rover
                else if (lineNumbers % 2 == 0)
                {

                    lineNumbers++;
                    marsRoverControl.AddRover(rover);
                    if (input.All(c => "LRM".Contains(c)))
                    {
                        foreach (char command in input)
                        {
                            if (marsRoverControl.VerifyRoverPosition(rover.X, rover.Y))
                                rover.Move(command);
                        }
                        Console.WriteLine(rover.X + " " + rover.Y + " " + rover.Direction);
                    }
                    else {
                        Console.WriteLine("Invalid command, please try again");
                      
                        lineNumbers--;
                    }
                    Console.WriteLine("Enter position and heading");
                   
                }
               
                input = Console.ReadLine();
            }
        }
    }
}









