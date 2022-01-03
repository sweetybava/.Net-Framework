using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSamplePrg
{
    //Interface
    public interface IBooks
    {
        //abstract method
        void bookTitle();
    }

    //inherit the interface class
    class BookName : IBooks
    {
        //method
        public void bookTitle()
        {
            //get the user input
            Console.WriteLine("Enter the book name: ");
            string bookName = Console.ReadLine();

            //Displaying the values
            Console.WriteLine("Book Name: " + bookName);
        }
    }

    //edition class inherit the Ibooks interface
    class Edition : IBooks
    {
        //method
        public void bookTitle()
        {
            //user input
            Console.WriteLine("Enter the book edition: ");
            int bookEdition = Convert.ToInt32(Console.ReadLine());

            //Displaying the values
            Console.WriteLine("Book Name: " + bookEdition);
        }
    }
}
