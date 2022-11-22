using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    internal class MarsRoverControl
    {

        internal Plateau? Plateau { get; set; }
        internal List<Rover> Rovers { get; set; }

        public MarsRoverControl()
        {
            Rovers = new List<Rover>();
        }

        public void AddRover(Rover rover)
        {
            Rovers.Add(rover);
        }

        public void SetPlateau(Plateau plateau)
        {
            Plateau = plateau;
        }

        public bool VerifyRoverPosition(int x, int y)
        {
            if (x > Plateau.X || y > Plateau.Y || x < 0 || y < 0 || Rovers.Any(r => r.X == x && r.Y == y))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //get x and y for all rovers
        public List<string> GetRoverPositions()
        {
            List<string> roverPositions = new List<string>();
            foreach (Rover rover in Rovers)
            {
                roverPositions.Add(rover.X + " " + rover.Y + " " + rover.Direction);
            }
            return roverPositions;
        }

        


    }
}
