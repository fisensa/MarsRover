using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    internal class Rover
    {
        private int
            _x,
            _y;

        private char _direction;

        public Rover(int x, int y, char direction)
        {
            _x = x;
            _y = y;
            _direction = direction;
        }
        public int X
        {
            get { return _x; }
        }
        public int Y
        {
            get { return _y; }
        }
        public char Direction
        {
            get { return _direction; }
        }

        public void Move(char command)
        {
            switch (command)
            {
                case 'L':
                    TurnLeft();
                    break;
                case 'R':
                    TurnRight();
                    break;
                case 'M':
                    MoveForward();
                    break;
            }
        }

        private void TurnLeft()
        {
            switch (_direction)
            {
                case 'N':
                    _direction = 'W';
                    break;
                case 'E':
                    _direction = 'N';
                    break;
                case 'S':
                    _direction = 'E';
                    break;
                case 'W':
                    _direction = 'S';
                    break;
            }
        }

        private void TurnRight()
        {
            switch (_direction)
            {
                case 'N':
                    _direction = 'E';
                    break;
                case 'E':
                    _direction = 'S';
                    break;
                case 'S':
                    _direction = 'W';
                    break;
                case 'W':
                    _direction = 'N';
                    break;
            }
        }

        private void MoveForward()
        {
            switch (_direction)
            {
                case 'N':
                    _y++;
                    break;
                case 'E':
                    _x++;
                    break;
                case 'S':
                    _y--;
                    break;
                case 'W':
                    _x--;
                    break;
            }
        }
        
        

    }
}
