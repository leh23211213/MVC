using Framework;
namespace MVC.Views
{
    using Models;

    internal class BookSingleView
    {
        protected Book Model; // biến lư trữ thông tin cuốn sách đang cần hiển thị
        
        public BookSingleView(Book model)
        {
            Model = model;
        }
      
        
        public void Render()
        {
            if (Model == null) // check object có dữ liệu không
            {
                ViewHelp.WriteLine("No Book Found!", ConsoleColor.Red);

                return;
            }
            ViewHelp.WriteLine("Book Detail Information", ConsoleColor.Red);

            /*  sử dụng cách tạo xâu kiểu " interpolation" 
             * và dùng dấu cách để căn chỉnh tạo thẩm mỹ 
             */
             
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