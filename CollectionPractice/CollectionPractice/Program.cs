using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionPractice
{
    class Program
    {
        public static void DisplayOption()
        {
            Console.WriteLine("Please Select An Option");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Borrow Book");
            Console.WriteLine("3. Return Book");
            Console.WriteLine("4. Display List");
            Console.WriteLine("5. Exit");
        }
        static void Main(string[] args)
        {
            Book objBook = new Book();
            var bookList = new List<Book>();
            string bookName = string.Empty;
            string bookCode = string.Empty;
            string bookAuthor = string.Empty;
            int bookStock = 0;

            Console.WriteLine("================ Welcome To ABC Library System ====================");
            DisplayOption();
            
            bool loopContinue = true;
            while (loopContinue)
            {               
                int option = Convert.ToInt32(Console.ReadLine());
                if (option != 0)
                {
                    switch (option)
                    {
                        case 1:                           
                            Console.Write("Book : "); bookName = Console.ReadLine();
                            Console.Write("Code : "); bookCode = Console.ReadLine();
                            Console.Write("Author : "); bookAuthor = Console.ReadLine();
                            Console.Write("Add Stock : "); bookStock = Convert.ToInt32(Console.ReadLine());
                            if (bookList.Count != 0)
                            {
                                foreach (var book in bookList)
                                {
                                    if (book.Code == bookCode)
                                        book.stock += bookStock;
                                    else                                       
                                        bookList.Add(new Book() { Name = bookName, Code = bookCode, Author = bookAuthor, stock = bookStock });
                                    break;
                                }
                            }
                            else                                
                                bookList.Add(new Book() { Name = bookName, Code = bookCode, Author = bookAuthor, stock = bookStock});
                            Console.WriteLine("Successfully Book Added In Library.");
                            DisplayOption();
                            loopContinue = true;
                            break;
                        case 2:
                            Console.Write("Code : "); bookCode = Console.ReadLine();
                            Console.Write("Borrow Quantity : "); bookStock = Convert.ToInt32(Console.ReadLine());
                            foreach (var book in bookList)
                            {
                                if (book.Code == bookCode)
                                {
                                    if (bookStock > book.stock)
                                        Console.WriteLine("Sorry given quantity is not available in stock.");
                                    else
                                        book.stock -= bookStock;
                                }                                
                            }
                            DisplayOption();
                            loopContinue = true;
                            break;
                        case 3:
                            Console.Write("Code : "); bookCode = Console.ReadLine();
                            Console.Write("Return Quantity : "); bookStock = Convert.ToInt32(Console.ReadLine());
                            foreach (var book in bookList)
                            {
                                if (book.Code == bookCode)
                                {
                                    book.stock += bookStock;
                                }                                
                            }
                            DisplayOption();
                            loopContinue = true;
                            break;
                        case 4:
                            Console.Write("Name");
                            Console.Write("\tCode");
                            Console.Write("\tAuthor");
                            Console.Write("\tStock");
                            Console.WriteLine();
                            foreach (var book in bookList)
                            {
                                Console.Write(book.Name);
                                Console.Write("\t" + book.Code);
                                Console.Write("\t" + book.Author);
                                Console.Write("\t" + book.stock);
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            DisplayOption();
                            loopContinue = true;
                            break;
                        case 5:
                            Console.WriteLine("Thank you for using ABC library system.");
                            loopContinue = false;
                            break;
                    }
                }   
            }

            Console.ReadLine();
        }       
    }
}
