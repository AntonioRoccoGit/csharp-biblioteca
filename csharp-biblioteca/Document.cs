using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Document
    {

        //ATTRIBUTE
        private string identificationNumber;
        private string title;
        private string date;
        private string genre;
        private string locatedAt;
        private Author author;


        public Document(string idNumber, string title, string date, string genre)
        {
            this.identificationNumber = idNumber;
            this.title = title;
            this.date = date;
            this.genre = genre;
        }

        //PROPERTIES
        public string IdentificationNumber
        {
            get { return this.identificationNumber; }
        }

        public string Title
        {
            get { return this.title; }
        }
        public string Date
        {
            get { return this.date; }
        }
        public string Genre
        {
            get { return this.genre; }
        }
        public string LocatedAt
        {
            get { return this.locatedAt; }
        }
        public Author Author
        {
            get { return this.author; }
        }

        //SETTER

        public void SetLocatedAt(string section, string rack)
        {
            this.locatedAt = $"Corridoio: {section}, scaffale: {rack}";
        }

        public void SetAuthor(string name, string surname)
        {
            Author documentAuthor = new Author(name, surname);
            this.author = documentAuthor;
        }
    }
}
