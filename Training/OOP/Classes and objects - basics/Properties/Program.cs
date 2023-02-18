using System;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(1, 2);
            Console.WriteLine(p1.XCoordinate);//1
            p1.XCoordinate = 5;
            Console.WriteLine(p1.XCoordinate);//5
            Console.WriteLine(p1.YCoordinate);//2
            p1.YCoordinate = 6;
            Console.WriteLine(p1.YCoordinate);//6
            p1.YCoordinate = -1;
        }
    }
    public class Point
    {
        //fields
        private int xCoord;
        private int yCoord;
        //Properties
        public int XCoordinate
        {
            get { return this.xCoord; }
            set { this.xCoord = value; }
        }
        public int YCoordinate
        {
            get
            { //ReadOnly
                return this.yCoord;
            }
            set 
            {
                //Validation
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Values larger or equal than zero are allowed only!");
                }
                this.yCoord = value;
            }
        }
        //Constructor
        public Point(int xCoord,int yCoord)
        {
            this.xCoord = xCoord;
            this.yCoord = yCoord;
        }


    }
}
