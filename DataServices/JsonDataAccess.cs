namespace MVC.DataServices
{
    using Models;
    using Newtonsoft.Json;

    public class JsonDataAccess : IDataAccess
    {
        public List<Book> Books { get; set; } = new List<Book>();
        private readonly string _file = "data.json";
        public void Load()
        {
            if (!File.Exists(_file))
            {
                SaveChanges();
                return;
            }
            var jsonString = File.ReadAllText(_file);
            Books = JsonConvert.DeserializeObject<List<Book>>(jsonString);
        }
        public void SaveChanges()
        {
            var jsonString = JsonConvert.SerializeObject(Books);
            File.WriteAllText(_file, jsonString);
        }
    }
}
