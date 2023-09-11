using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
    {

        //ATTRIBUTE
        private List<Document> Documents;

        public Library(string name) 
        {
            this.Name = name;    
            this.Documents = new List<Document>();
        }


        //-----------------------------------------PROPRETIES
        public string Name { get; }

        //-----------------------------------------FUNCTIONS


        //Document List function
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


        //-------------------------------------UTILITIES FUNCTION

        private void documentDetails(Document item)
        {
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
