using System.ComponentModel;

namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Biblioteca");

            //create library
            Library myFirstLibrary = new Library("Biblio DB");

            //create an user
            User registeredUser = new User("User","Foo","user.foo@gmail.com","adminadmin", "3339990000");


            //create generic documents
            Document theLionKing = new Document("1436599887", "The Lion King", "1994", "animation");
            theLionKing.SetLocatedAt("4","6a");
            theLionKing.SetAuthor("Pinco", "Pallo");


            Book wordWar = new Book("ISBN-001", "Word War", "1945", "action");
            Book noImagination = new Book("ISBN-959484", "No Imagination", "2012", "imagination");
            Dvd happyBook = new Dvd("959484", "Happy Book", "2012", "imagination");
            Dvd cleanCode = new Dvd("001", "Clean Code", "1945", "action");


            //add document in documents list
            myFirstLibrary.pushDocument(theLionKing);
            myFirstLibrary.pushDocument(wordWar);
            myFirstLibrary.pushDocument(noImagination);
            myFirstLibrary.pushDocument(happyBook);
            myFirstLibrary.pushDocument(cleanCode);

            //control if documents are added
            myFirstLibrary.getDocuments();

            //remove a document
            myFirstLibrary.popDocument(theLionKing);

            //control the document was removed 
            myFirstLibrary.getDocuments();
            


            //search by id
            myFirstLibrary.findById("4");
            myFirstLibrary.findById("959484");
            myFirstLibrary.findByTitle("no imagination");
            myFirstLibrary.findByTitle("clean Code");



        }
    }
}