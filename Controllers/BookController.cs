namespace MVC.Controllers
{
    using DataServices;
    using Models;
    using Views;
    public class BookController
    {
        protected Repository Repository;
        public BookController(SimpleDataAccess context)
        {
            Repository = new Repository(context);
        }
        public void Single(int id)
        {
            var model = Repository.Select(id);
            BookSingleView view = new BookSingleView(model);
            view.Render();
        }
        public void Create()
        {
            BookCreateView view = new BookCreateView();
            view.Render();
        }
        public void Update(int id)
        {
            var model = new Book();
            var view = new BookUpdateView(model);
            view.Render();
        }
        public void List()
        {
            var model = Repository.Select();
            BookListView view = new BookListView(model);
            view.Render();
        }
    }
}