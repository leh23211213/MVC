namespace MVC.DataServices
{
    using MVC.Models;
    public interface IDataAccess
    {
        List<Book> Books { get; set; }
        void Load();
        void SaveChanges();
    }
}