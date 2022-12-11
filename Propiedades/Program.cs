using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            Sale mySale = new Sale(100, DateTime.Now);
            Console.WriteLine(mySale.Total);

        }
    }
    class Sale
    {
      private  int total;
       private DateTime date;

        public string Date
        {
            get
            {
                return date.ToLongDateString();
            }
        }
        public int Total
        {
            get
            {
                return total;
            }
            set
            {
                if(value < 0) value = 0;
                total = value; 
            }
        }

        public Sale(int total, DateTime data)
        {
            this.total = total;
            this.date = date;
        }
    }
}


