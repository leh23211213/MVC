using System;

namespace MVC.Views
{
    using Models; // chú ý  cách dùng namespace
    /// <summary>
    /// class để hiển thị một cuốn sách, chỉ sử dụng trong dự án ( internal )
    /// </summary>
    internal class BookSingleView
    {
        protected Book Model; // biến lư trữ thông tin cuốn sách đang cần hiển thị
        /// <summary>
        /// hàm contructor
        /// </summary>
        /// <param name="model"> cuốn sách cụ thể sẽ được hiển thị </param>
        public BookSingleView(Book model)
        {
            Model = model;
        }
        /// <summary>
        /// in thông báo ra màn hình console với chữ màu 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        protected void WriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        /// <summary>
        /// thực hiện in thông tin ra màn hình console
        /// </summary>
        public void Render()
        {
            if (Model == null) // check object có dữ liệu không
            {
                WriteLine("No Book Found!", ConsoleColor.Red);

                return;
            }
            WriteLine("Book Detail Information", ConsoleColor.Red);

            /*  sử dụng cách tạo xâu kiểu " interpolation" 
             * và dùng dấu cách để căn chỉnh tạo thẩm mỹ 
             */
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