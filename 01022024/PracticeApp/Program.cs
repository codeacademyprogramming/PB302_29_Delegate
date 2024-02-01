

using PracticeApp;

Book book1 = new Book("Eli ve Nino", 9,"Author1");
Book book2 = new Book("Atalar ve Ogullar", 0.4, "Author2");
Book book3 = new Book("Ana dili", 14, "Author3");
Book book4 = new Book("Riyaziyyat", 40, "Author1");
Book book5 = new Book("Heyat bilgisi", 54, "Author1");
Book book6 = new Book("Ingilis dili", 20, "Author4");
Book book7 = new Book("Heyvanlar alemi", 5, "Author2");


Library lib = new Library();    
lib.Books.Add(book1);
lib.Books.Add(book2);
lib.Books.Add(book3);
lib.Books.Add(book4);
lib.Books.Add(book5);
lib.Books.Add(book6);
lib.Books.Add(book7);


//var wantedBook1 = lib.FindByName("Ana dili");
//var wantedBook1 = lib.Find(delegate (Book book) { return book.Name == "Ana dili"; });
var wantedBook1 = lib.Find(book=>book.Name=="Ana dili");

Console.WriteLine(wantedBook1);

//var wantedBook2 = lib.FindByAuthor("Author2");
var wantedBook2 = lib.Find(b => b.Author == "Author2");

Console.WriteLine(wantedBook2);

//var wantedBook3 = lib.FindBySearch("il");
var wantedBook3 = lib.Find(b => b.Name.Contains("il"));

Console.WriteLine(wantedBook3);

lib.Books.RemoveAll(x => x.Price < 10);

foreach (var item in lib.Search(x=>x.Price<10))
{
    Console.WriteLine(item);
}


var wantedBooks = lib.Books.FindAll(x => x.Price < 10);
wantedBooks = lib.Books.FindAll(x => x.Name.Length > 7);

var wantedBook4 = lib.Books.Find(x => x.Name == "Ana dili");
wantedBook4 = lib.Books.First(x => x.Name == "Ana dili");
wantedBook4 = lib.Books.FirstOrDefault(x => x.Name == "Ana dili");
lib.Books.Sum(x => x.Price);
lib.Books.Max(x => x.Price);



