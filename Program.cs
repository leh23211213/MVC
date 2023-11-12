namespace MVC
{
    using DataServices;
    using Controllers;
    using Framework;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SimpleDataAccess context = new SimpleDataAccess();
            BookController controller = new BookController(context);
            
            Router r = Router.Instance;
        
            r.Register("about", About);
            r.Register("help", Help);
            r.Register(route: "create",
                action: p => controller.Create(),
                help: "[create]\r\nnhập sách mới");
            r.Register(route: "update",
                action: p => controller.Update(p["id"].ToInt()),
                help: "[update ? id = <value>]\r\ntìm và cập nhập sách");
            r.Register(route: "list",
                action: p => controller.List(),
                help: "[list]\r\nhiển thị tất cả các sách");
            r.Register(route: "single",
                action: p => controller.Single(p["id"].ToInt()),
                help: "[single ? id = <value> \r\nhiển thị một cuốn sách theo id");
            while (true)
            {
                ViewHelp.Write("# Request: ", ConsoleColor.Green);
                string userInput = Console.ReadLine();
                string request = userInput.ToLower();

                if (request == null) { continue; }
                else
                {
                    if (request == "quit" || request == "q")
                    {
                        Console.WriteLine("Press any key to continue...");
                        break;
                    }

                    // ****************************************************
                    Router.Instance.Forward(request);
                }
            }
        }
        private static void About(Parameter parameter)
        {
            ViewHelp.WriteLine("Book manager version 1.0", ConsoleColor.Green);
            ViewHelp.WriteLine("by HiepLe", ConsoleColor.Magenta);
        }
        private static void Help(Parameter parameter)
        {
            if (parameter == null)
            {
                ViewHelp.WriteLine("Supported Command: ", ConsoleColor.Green);
                ViewHelp.WriteLine(Router.Instance.GetRoutes(), ConsoleColor.Yellow);
                ViewHelp.WriteLine("Type: help ? cmd = <command> to get command details", ConsoleColor.Cyan);
                return;
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            var command = parameter["cmd"].ToLower();
            ViewHelp.WriteLine(Router.Instance.GetHelp(command));
        }
    }
}