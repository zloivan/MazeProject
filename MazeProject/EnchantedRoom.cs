namespace MazeProject
{
    internal class EnchantedRoom : Room
    {
        private int number;
        private object p;


        public EnchantedRoom(int number, object p):base(number)
        {
            this.number = number;
            this.p = p;
        }
    }
}