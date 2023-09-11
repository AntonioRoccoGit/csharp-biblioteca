using System.ComponentModel;

namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Biblioteca");

            //create an user
            User registeredUser = new User("User","Foo","user.foo@gmail.com","adminadmin", "3339990000");


            //create a generic document
            Document theLionKing = new Document("1436599887", "The Lion King", "1994", "animation");
            theLionKing.SetLocatedAt("4","6a");
            theLionKing.SetAuthor("Pinco", "Pallo");

            Console.WriteLine(theLionKing.LocatedAt);
            Console.Write(theLionKing.Author.Name);
            
        }
    }
}