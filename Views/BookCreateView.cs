using Framework;
namespace BookMan.ConsoleApp.Views
{
    /// <summary>
    /// class để thêm một cuốn sách mới
    /// </summary>
    internal class BookCreateView
    {
        public BookCreateView()
        {

        }
        /// <summary>
        /// yêu cầu người dùng nhập từng thông tin và lưu lại thông tin đó
        /// </summary>
        public void Render()
        {
            ViewHelp.WriteLine("Create a new book", ConsoleColor.Green);
            var title = ViewHelp.InputString("Title");
            var authors = ViewHelp.InputString("Authors");
            var Publisher = ViewHelp.InputString("Publisher");
            var year = ViewHelp.InputInt("Year");
            var edition = ViewHelp.InputInt("Edition");
            var tags = ViewHelp.InputString("Tags");
            var description = ViewHelp.InputString("Description");
            var rate = ViewHelp.InputInt("Rate");
            var reading = ViewHelp.InputBool("Reading");
            var file = ViewHelp.InputString("File");

        }
      
    }
}