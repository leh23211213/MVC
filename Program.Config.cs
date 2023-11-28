namespace MVC
{
    using Models;
    using Controllers;
    using DataServices;
    using Framework;
    internal partial class Program
    {
        private static void ConfigRouter()
        {
            IDataAccess context = new JsonDataAccess();
            BookController controller = new BookController(context);
            ShellController shell = new ShellController(context);
            // ConfigController config = new ConfigController();
            Router r = Router.Instance;
            r.Register("about", About);
            r.Register("help", Help);
            r.Register(route: "create",
                action: p => controller.Create(),
                help: "[create]rnhập sách mới");
            r.Register(route: "do create",
                action: p => controller.Create(toBook(p)),
                help: "this route should be used only in code");
            r.Register(route: "update",
                action: p => controller.Update(p["id"].ToInt()),
                help: "[update ? id = <value>]rntìm và chập nhật sách");
            r.Register(route: "do update",
                action: p => controller.Update(p["id"].ToInt(), toBook(p)),
                help: "this route should be used only in code");
            r.Register(route: "list",
                action: p => controller.List(),
                help: "[list]rhiển thị tất cả sách");
            r.Register(route: "list file",
                action: p => controller.List(p["path"]),
                help: "[list file ? path = <value>]rhiển thị tất cả sách");
            r.Register(route: "single",
                action: p => controller.Single(p["id"].ToInt()),
                help: "[single ? id = <value>]rhiển thị một cuốn sách");
            r.Register(route: "single file",
                action: p => controller.Single(p["id"].ToInt(), p["path"]),
                help: "[single file ? id = <value> & path = <value>]");
            r.Register(route: "delete",
                action: p => controller.Delete(p["id"].ToInt()),
                help: "[delete ? id = <value>]");
            r.Register(route: "do delete",
                action: p => controller.Delete(p["id"].ToInt(), true),
                help: "this route should be used only in code");
            r.Register(route: "filter",
                action: p => controller.Filter(p["key"].ToString()),
                help: "[filter ? key = <value>]rntìm sách theo từ khóa");
            r.Register(route: "add shell",
                action: p => shell.Shell(p["path"], p["ext"]),
                help: "[add shell ? path = <value>]");
            r.Register(route: "read",
                action: p => shell.Read(p["id"].ToInt()),
                help: "[read ? id = <value>]");
            r.Register(route: "mark",
                action: p => controller.Mark(p["id"].ToInt()),
                help: "[mark ? id = <value>]");
            r.Register(route: "unmark",
                action: p => controller.Mark(p["id"].ToInt(), false),
                help: "[unmark ? id = <value>]");
            r.Register(route: "show marks",
                action: p => controller.ShowMarks(),
                help: "[show marks]");
            r.Register(route: "clear",
                action: p => shell.Clear(true),
                help: "[clear]rnUse with care");
            r.Register(route: "do clear",
                action: p => shell.Clear(true),
                help: "[clear]rnUse with care");
            r.Register(route: "save shell",
                action: p => shell.Save(),
                help: "[save shell]");
            /* với tính năng show stats hiển thị thống kê sách theo thư mục ta có thể theo logic
              xây dựng tính năng thống kê tiêu chí khác như tác giả , nhà xuất bản */
            r.Register(route: "show stats",
                action: p => controller.Stats(),
                help: "[show stats]");
            // BUG:
            // r.Register(route: "config prompt text",
            //     action: p => config.ConfigPromptText(p["text"]),
            //     help: "[config prompt text ? text = <value>]");
            // r.Register(route: "config prompt color",
            //     action: p => config.ConfigPromptColor(p["color"]),
            //     help: "[config prompt color ? color = <value>]");
            // r.Register(route: "current data access",
            //     action: p => config.CurrentDataAccess(),
            //     help: "[current data access]");
            // r.Register(route: "config data access",
            //     action: p => config.ConfigDataAccess(p["da"], p["file"]),
            //     help: "[config data access ? da = <value:json,xml> & file = <value>]");
            #region helper
            // local funtion to convert parameter to book object
            Book toBook(Parameter p)
            {
                var b = new Book();
                if (p.ContainKey("id")) b.Id = p["id"].ToInt();
                if (p.ContainKey("author")) b.Authors = p["authors"];
                if (p.ContainKey("title")) b.Title = p["title"];
                if (p.ContainKey("publisher")) b.Publisher = p["publisher"];
                if (p.ContainKey("year")) b.Year = p["year"].ToInt();
                if (p.ContainKey("edition")) b.Edition = p["edition"].ToInt();
                if (p.ContainKey("isbn")) b.Isbn = p["isbn"];
                if (p.ContainKey("tags")) b.Tags = p["tags"];
                if (p.ContainKey("description")) b.Description = p["description"];
                if (p.ContainKey("file")) b.File = p["file"];
                if (p.ContainKey("rate")) b.Rating = p["rate"].ToInt();
                if (p.ContainKey("reading")) b.Reading = p["reading"].ToBool();
                return b;
            }
            #endregion
        }
    }
}