using System;

namespace InterfaceSamplePrg
{
    class Program
    {
        static void Main(string[] args)
        {
            //object 
            IBooks ib;
            ib = new BookName();
            ib.bookTitle();
            ib = new Edition();
            ib.bookTitle();

            
        }
    }
}
