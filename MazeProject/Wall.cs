using System;

namespace MazeProject
{
    public class Wall : MapSite
    {
        public Wall()
        {

        }
        public override void Enter()
        {
            Console.WriteLine("Wall");
        }
    }

    public class BombedWall : Wall
    {

    }
}