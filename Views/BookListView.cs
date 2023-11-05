using System.ComponentModel;
using System.Buffers.Text;
using Framework;
namespace MVC.Views
{
    using Models;
    internal class BookListView
    {
        protected Book[] Model;
        public BookListView(Book[] model)
        {
            Model = model;
        }
        public void Render()
        {
            if (Model.Length == 0)
            {
                ViewHelp.WriteLine("No book found!", ConsoleColor.Yellow);
                return;
            }
            ViewHelp.WriteLine("the book list", ConsoleColor.Green);
            foreach (Book b in Model)
            {
                ViewHelp.Write($"[{b.Id}] ", ConsoleColor.Yellow);
                ViewHelp.WriteLine($"[{b.Title}] ", b.Reading ? ConsoleColor.Cyan : ConsoleColor.White);
            }
        }
    }
}