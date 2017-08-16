using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProject
{
    class BombedMazeFactory:MazeFactory
    {
        public override Wall MakeWall()
        {
            return new BombedWall();
        }
        public override Room MakeRoom(int number)
        {
            return new RoomWithBomb(number);
        }
    }
}
