namespace MVC.Models
{
    /// <summary>
    ///  Lớp mô tả sách điện tử
    /// </summary>
    public class Book
    {
        private int _id = 1;
        /// <summary>
        /// số định danh duy nhất cho mỗi object
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { if (value >= 1) _id = value; }
        }

        private string _authors = "Unknown authors";
        /// <summary>
        /// tên tác giả hoặc nhóm tác giả ( không nhận xâu rỗng)
        /// </summary>
        public string Authors
        {
            get { return Authors; }
            set { if (!string.IsNullOrEmpty(value)) _authors = value; }
        }

        private string _title = "A now book";
        /// <summary>
        /// tiêu đề sách ( không nhận xâu rỗng )
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { if (!string.IsNullOrEmpty(value)) _title = value; }
        }

        private string _publisher = "Unknown publisher";
        /// <summary>
        /// nhà xuất bản (không nhận xâu rỗng)
        /// </summary>
        public string Publisher
        {
            get { return _publisher; }
            set { if (!string.IsNullOrEmpty(value)) _publisher = value; }
        }

        private int _year = 2018;
        /// <summary>
        /// năm xuất bản ( min 1950 )
        /// </summary>
        public int Year
        {
            get { return _year; }
            set { if (value >= 1950) _year = value; }
        }
        private int _edition = 1;
        /// <summary>
        /// lần tái bản, không nhỏ hơn 1
        /// </summary>
        public int Edition
        {
            get { return _edition; }
            set { if (value >= 1) _edition = value; }
        }
        /// <summary>
        ///  mã số quốc tế 
        /// </summary>
        public string Isbn { get; set; } = "";
        /// <summary>
        /// từ khóa mô tả nội dung/ thể loại
        /// </summary>
        public string Tags { get; set; } = "";
        /// <summary>
        /// mô tả tóm tắt nội dung
        /// </summary>
        public string Description { get; set; } = "A new book";

        private int _rating;
        /// <summary>
        /// đánh giá cá nhân, value[1,5];
        /// </summary>
        public int Rating
        {
            get { return _rating; }
            set { if (value >= 1 && value <= 5) _rating = value; }
        }

        /// <summary>
        /// đánh dấu đang đọc
        /// </summary>
        public bool Reading { get; set; }

        private string _file = "";
        public string File
        {
            get { return _file; }
            set { if (System.IO.File.Exists(value)) _file = value; }
        }
        /// <summary>
        /// file sách ( không có đường dẫn)
        /// </summary>
        public string FileName
        {
            get { return System.IO.Path.GetFileName(_file); }
        }
    }
}