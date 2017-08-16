using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame mazegame = new MazeGame();
            MazeFactory factory = new MazeFactory();
            mazegame.CreateMaze(factory);

        }
    }
}
