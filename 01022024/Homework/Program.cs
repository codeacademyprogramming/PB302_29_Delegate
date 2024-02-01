using Homework;

Dictionary<string, DateTime> exams = new Dictionary<string, DateTime>();

exams.Add("Ana dili", new DateTime(2024, 10, 6));
exams.Add("ingilis dili", new DateTime(2024, 10, 23));
exams.Add("Riyaziyyat", new DateTime(2024, 02, 03));
exams.Add("Emek", new DateTime(2024, 10, 20));


foreach (var item in exams)
{
    var diff = item.Value.Date - DateTime.Now.Date;
    Console.WriteLine($"{item.Key}: {item.Value.ToString("yyyy-MMMM-dd")} ({diff.TotalDays})");
}


string opt;
Library lib = new Library();
do
{
    Console.WriteLine("1. Add book");
    Console.WriteLine("2. Show book");
    Console.WriteLine("3. Remove book");
    Console.WriteLine("4. Search books");
    Console.WriteLine("0. Exit");

 
    opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            Console.WriteLine("Book name: ");
            string name = Console.ReadLine();

            try
            {
                lib.AddBook(name);
                Console.WriteLine("Book successfully added!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            break;
        case "2":
            Console.WriteLine("\n\tBooks:");
            foreach (var item in lib.Books)
            {
                Console.WriteLine(item);
            }
            break;
        case "3":
            Console.WriteLine("Book name: ");
            name = Console.ReadLine();

            if(lib.RemoveBook(name))
                Console.WriteLine("Book successfully removed");
            else Console.WriteLine("Book not found!");
            break;
        case "4":
            Console.WriteLine("Search: ");
            string search = Console.ReadLine();
            foreach (var item in lib.Search(search))
            {
                Console.WriteLine(item);
            }
            break;
        case "0":
            break;
        default:
            break;
    }

} while (opt!="0");



