using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Science_FPT
{
    public class Book
    {
        public int BookID { get; set; }
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        private int numOfBookReaders;

        public Book()
        {
            // Default constructor
        }
        public Book(string title, string author, int bookID, int iSBN,  int numOfBookReaders)
        {
            BookID = bookID;
            ISBN = iSBN;
            Title = title;
            Author = author;
            this.numOfBookReaders = numOfBookReaders;
        }

        public int GetNumberOfBookReaders()
        {
            return numOfBookReaders;
        }

        public void SetNumberOfBookReaders()
        {
            numOfBookReaders++;
        }
    }


}
