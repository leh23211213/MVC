namespace MVC.Views
{
    using Framework;
    using Models;
    internal class BookUpdateView : ViewBase<Book>
    {
        public BookUpdateView(Book model) : base(model) { }
        public override void Render()
        {
            ViewHelp.WriteLine("Update book information", ConsoleColor.Green);
            var authors = ViewHelp.InputString("Authors", Model.Authors);
            var title = ViewHelp.InputString("Title", Model.Title);
            var publisher = ViewHelp.InputString("Publisher", Model.Publisher);
            var isbn = ViewHelp.InputString("Isbn", Model.Isbn);
            var tags = ViewHelp.InputString("Tags", Model.Tags);
            var description = ViewHelp.InputString("Description", Model.Description);
            var file = ViewHelp.InputString("File", Model.File);
            var year = ViewHelp.InputInt("Year", Model.Year);
            var edition = ViewHelp.InputInt("Edition", Model.Edition);
            var rating = ViewHelp.InputInt("Rate", Model.Rating);
            var reading = ViewHelp.InputBool("Reading", Model.Reading);
        }
    }
}