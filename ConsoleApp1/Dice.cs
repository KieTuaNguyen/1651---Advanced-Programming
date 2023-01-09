namespace ConsoleApp1
{
    public class Dice
    {
        //Field
        private int side;
        //Properties
        public int Side
        {
            set { if(value>0) side = value;  }
            get { return side;  }
        }

        public void setSide(int side)
        {
            if (side > 0)
            {
                this.side = side;
            }
            else
            {
                side = 6;
            }
        }
        public int Roll(int s)
        {
            Random rd = new Random();
            return rd.Next(1, s + 1);
        }
    }
}