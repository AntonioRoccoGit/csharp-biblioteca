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
        public void PushDocument(Document document)
        {
            this.Documents.Add(document);
        }

        /// <summary>
        /// delete the specific document from library
        /// </summary>
        /// <param name="document"></param>
        public void PopDocument(Document document)
        {
            this.Documents.Remove(document);
        }


        /// <summary>
        /// Get in console the Title of each Document
        /// </summary>
        public void GetDocuments()
        {

            Console.WriteLine();
            Console.WriteLine("Ecco la tua lista dei documenti");
            Console.WriteLine();
            foreach (var item in this.Documents)
            {
                Console.WriteLine(item.Title);
            }
            Console.WriteLine("-------------FINE LISTA----------");
            Console.WriteLine();
        }

        /// <summary>
        /// Find document by ID
        /// 
        /// </summary>
        /// <param name="id"> Write the id (ISBN included for the book) </param>
        public void FindDocumentById(string id)
        {
            foreach (Document item in this.Documents)
            {
                if (item.IdentificationNumber == id)
                {
                    DocumentDetails(item);
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
        public void FindDocumentByTitle(string name)
        {
            foreach (Document item in this.Documents)
            {
               
                if (item.Title.ToLower() == name.ToLower())
                {
                    DocumentDetails(item);
                    return;

                }
            }
            Console.WriteLine("Non sono stati trovati documenti");
            Console.WriteLine();
        }

        //-----------------------------------borrows List function

        public void PushBorrow(Borrowed borrow)
        {
            this.Borrows.Add(borrow);
        }

        /// <summary>
        /// 
        /// </summary>
        public void PopBorrows(Borrowed borrow)
        {
            this.Borrows.Remove(borrow);
        }


        /// <summary>
        /// 
        /// </summary>
        public void GetBorrowsHistory()
        {
            foreach (var item in this.Borrows)
            {
                this.BorrowDetails(item);
            }
            Console.WriteLine();
        }

        public void GetBorrowByUser(User user)
        {
            bool nameMatch = false;
            bool surnameMatch = false;

            foreach (var item in this.Borrows)
            {
                nameMatch = item.UserName.ToLower() == user.Name.ToLower();
                surnameMatch = item.UserSurname.ToLower() == user.Surname.ToLower();
                if (nameMatch && surnameMatch )
                {
                    this.BorrowDetails(item);
                }
            }
            if (!nameMatch && !surnameMatch)
            {
            Console.WriteLine("Nessun'impegnativa trovata");
            Console.WriteLine();

            }

        }

        //-------------------------------------UTILITIES FUNCTION

        private void DocumentDetails(Document item)
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine($"    Risultato Trovato:");
            Console.WriteLine();
            Console.WriteLine($" Titolo: {item.Title}");
            Console.WriteLine($" ID: {item.IdentificationNumber}");
            Console.WriteLine($" Genere: {item.Genre}");
            Console.WriteLine("-----------------------");
            Console.WriteLine();

        }

        private void BorrowDetails(Borrowed item)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine($"          Impegnativa cliente");
            Console.WriteLine($" Credenziali: {item.UserName} {item.UserSurname}");
            Console.WriteLine($" Data di presa in caricp: {item.StartDate}");
            Console.WriteLine($" Data di riconsegna: {item.EndDate}");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

        }
    }
}
