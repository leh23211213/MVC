namespace MVC.Views
{
    using Models;
    using Framework;
    internal class BookSingleView : ViewBase<Book>
    {
        public BookSingleView(Book model) : base(model) { }

        public override void Render()
        {
            if (Model == null)
            {
                ViewHelp.WriteLine("No Book Found!", ConsoleColor.Red);
                return;
            }
            ViewHelp.WriteLine("Book Detail Information", ConsoleColor.Red);

            // Console.WriteLine($"ID:             {Model.Id}");
            Console.WriteLine($"Authors:        {Model.Authors}");
            Console.WriteLine($"Title:          {Model.Title}");
            Console.WriteLine($"Publisher:      {Model.Publisher}");
            Console.WriteLine($"Year:           {Model.Year}");
            Console.WriteLine($"Edition:        {Model.Edition}");
            Console.WriteLine($"Isbn:           {Model.Isbn}");
            Console.WriteLine($"Tags:           {Model.Tags}");
            Console.WriteLine($"Description:    {Model.Description}");
            Console.WriteLine($"Rating:         {Model.Rating}");
            Console.WriteLine($"Reading:        {Model.Reading}");
            Console.WriteLine($"File:           {Model.File}");
            Console.WriteLine($"File Name:      {Model.FileName}");
        }
    }
}