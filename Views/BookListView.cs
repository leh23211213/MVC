namespace MVC.Views
{
    using Models;
    using Framework;
    internal class BookListView : ViewBase<Book[]>
    {
        public BookListView(Book[] model) : base(model) { }
        public override void Render()
        {
            if (Model.Length == 0)
            {
                ViewHelp.WriteLine("No book found!", ConsoleColor.Yellow);
                return;
            }
            ViewHelp.WriteLine("the book list", ConsoleColor.Green);
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (Book b in Model)
            {
                ViewHelp.Write($"[{b.Id}] ", ConsoleColor.Yellow);
                ViewHelp.WriteLine($"[{b.Title}] ", b.Reading ? ConsoleColor.Cyan : ConsoleColor.White);
            }
            ViewHelp.WriteLine($"{Model.Length} item(s)", ConsoleColor.Green);
            //Console.ResetColor();
        }
    }
}