namespace MVC
{
    using Framework;
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            // TODO : Xem lại phương thức add/ SAVE.
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // var text = Config.Instance.PromptText;
            // var color = Config.Instance.PromptColor;
            Console.WriteLine("Type: 'About' or 'Help'to know more information");
            ConfigRouter();
            while (true)
            {
                ViewHelp.Write("Request: ", ConsoleColor.Blue);
                string userInput = Console.ReadLine();
                string request = userInput.ToLower();

                if (request == null) { continue; }
                else
                {
                    if (request.Replace(" ", "") == "quit" || request.Replace(" ", "") == "q")
                    {
                        Console.WriteLine("Press any key to continue...");
                        break;
                    }

                    // ****************************************************
                    try
                    {
                        Router.Instance.Forward(request);
                    }
                    catch (Exception e)
                    {
                        ViewHelp.WriteLine(e.Message, ConsoleColor.Red);
                    }
                    finally
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
        private static void About(Parameter parameter)
        {
            ViewHelp.WriteLine("Book manager version 1.1", ConsoleColor.Green);
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