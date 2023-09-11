using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Library
    {

        //-----------------------------------------ATTRIBUTE
        private List<Document> Documents = new List<Document>();
        private List<Borrowed> Borrows = new List<Borrowed>();


        public Library(string name) 
        {
            this.Name = name;
        }


        //-----------------------------------------PROPRETIES
        public string Name { get; }

        //-----------------------------------------FUNCTIONS


        //-----------------------------------documents List function
        public void pushDocument(Document document)
        {
            this.Documents.Add(document);
        }

        /// <summary>
        /// delete the specific document from library
        /// </summary>
        /// <param name="document"></param>
        public void popDocument(Document document)
        {
            this.Documents.Remove(document);
        }


        /// <summary>
        /// Get in console the Title of each Document
        /// </summary>
        public void getDocuments()
        {
            foreach (var item in this.Documents)
            {
                Console.WriteLine(item.Title);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Find document by ID
        /// 
        /// </summary>
        /// <param name="id"> Write the id (ISBN included for the book) </param>
        public void findById(string id)
        {
            foreach (Document item in this.Documents)
            {
                if (item.IdentificationNumber == id)
                {
                    documentDetails(item);
                    return;

                }
            }
            Console.WriteLine("Non sono stati trovati documenti");
            Console.WriteLine();

        }

        /// <summary>
        /// Find document by name(not key sensitive)
        /// </summary>
        /// <param name="name"> Write the complete name, no key sensititve </param>
        public void findByTitle(string name)
        {
            foreach (Document item in this.Documents)
            {
                if (item.Title.ToLower() == name.ToLower())
                {
                    documentDetails(item);
                    return;

                }
            }
            Console.WriteLine("Non sono stati trovati documenti");
            Console.WriteLine();
        }

        //-----------------------------------borrows List function

        public void pushBorrow(Borrowed borrow)
        {
            this.Borrows.Add(borrow);
        }

        /// <summary>
        /// 
        /// </summary>
        public void popBorrows(Borrowed borrow)
        {
            this.Borrows.Remove(borrow);
        }


        /// <summary>
        /// 
        /// </summary>
        public void getBorrows()
        {
            foreach (var item in this.Borrows)
            {
                //TODO;
            }
            Console.WriteLine();
        }
        //-------------------------------------UTILITIES FUNCTION

        private void documentDetails(Document item)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine($"            Risultato Trovato");
            Console.WriteLine($" Titolo: {item.Title}");
            Console.WriteLine($" ID: {item.IdentificationNumber}");
            Console.WriteLine($" Genere: {item.Genre}");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

        }

    }
}
