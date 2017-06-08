using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProject
{
    class MazeGame
    {
        MazeFactory factory = null;

        public Maze CreateMaze(MazeFactory factory)
        {
            #region FirtVerion

            //Maze aMaze = new Maze();
            //Room r1 = new Room(1);
            //Room r2 = new Room(2);
            //Door theDoor = new Door(r1,r2);

            //aMaze.AddRoom(r1);
            //aMaze.AddRoom(r2);

            //r1.SetSide(Direction.North, new Wall());
            //r1.SetSide(Direction.East, theDoor);
            //r1.SetSide(Direction.South, new Wall());
            //r1.SetSide(Direction.West, new Wall());
            //r2.SetSide(Direction.North, new Wall());
            //r2.SetSide(Direction.East, new Wall());
            //r2.SetSide(Direction.South, new Wall());
            //r2.SetSide(Direction.West, theDoor);
            //return aMaze;

            #endregion

            #region FactoryVersion
            this.factory = factory;
            Maze aMaze = this.factory.MakeMaze();
            Room r1 = this.factory.MakeRoom(1);
            Room r2 = this.factory.MakeRoom(2);
            Door aDoor = this.factory.MakeDoor(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSide(Direction.North, this.factory.MakeWall());
            r1.SetSide(Direction.East, aDoor);
            r1.SetSide(Direction.South, this.factory.MakeWall());
            r1.SetSide(Direction.West, this.factory.MakeWall());
            r2.SetSide(Direction.North, this.factory.MakeWall());
            r2.SetSide(Direction.East, this.factory.MakeWall());
            r2.SetSide(Direction.South, this.factory.MakeWall());
            r2.SetSide(Direction.West, aDoor);
            return aMaze; 
            #endregion
        }
    }
}
