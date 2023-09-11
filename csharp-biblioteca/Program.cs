using System.ComponentModel;

namespace csharp_biblioteca
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Biblioteca");

            //create library
            Library myFirstLibrary = new Library("Biblio DB");

            //create an user
            User registeredUser = new User("Pippo","Foo","user.foo@gmail.com","adminadmin", "3339990000");
            User registeredUserNoBorrow = new User("Franco","Bar","franco.bar@gmail.com","adminadmin", "3339990000");

            //create generic documents
            Document theLionKing = new Document("1436599887", "The Lion King", "1994", "animation");
            theLionKing.SetLocatedAt("4","6a");
            theLionKing.SetAuthor("Pinco", "Pallo");

            Book wordWar = new Book("ISBN-001", "Word War", "1945", "action");
            Book noImagination = new Book("ISBN-959484", "No Imagination", "2012", "imagination");
            Dvd happyBook = new Dvd("959484", "Happy Book", "2012", "imagination");
            Dvd cleanCode = new Dvd("001", "Clean Code", "1945", "action");

            //add document in documents list
            myFirstLibrary.PushDocument(theLionKing);
            myFirstLibrary.PushDocument(wordWar);
            myFirstLibrary.PushDocument(noImagination);
            myFirstLibrary.PushDocument(happyBook);
            myFirstLibrary.PushDocument(cleanCode);

            //control if documents are added
            myFirstLibrary.GetDocuments();

            //remove a document
            myFirstLibrary.PopDocument(theLionKing);

            //control the document was removed 
            myFirstLibrary.GetDocuments();

            //search by id
            myFirstLibrary.FindDocumentById("4");
            myFirstLibrary.FindDocumentById("ISBN-959484");
            myFirstLibrary.FindDocumentByTitle("clean Code");

            //Create some borrow
            Borrowed cleanCodeBorrow = new Borrowed(registeredUser, 12, "001");

            myFirstLibrary.PushBorrow(cleanCodeBorrow);
            myFirstLibrary.GetBorrowsHistory();
            myFirstLibrary.GetBorrowByUser(registeredUser);
            myFirstLibrary.GetBorrowByUser(registeredUserNoBorrow); 


        }
    }
}