namespace MVC
{
    using Controllers;
    internal class Program
    {
        private static void Main(string[] args)
        {
            BookController controller = new BookController();
            while (true)
            {
                Console.Write("Request> ");
                string request = Console.ReadLine();
                if (request == null) { continue; }
                else
                {
                    if (request == "quit" || request == "q")
                    {
                        Console.WriteLine("Press any key to continue...");
                        break;
                    }

                    // ****************************************************

                    switch (request.ToLower())
                    {
                        case "single":
                            controller.Single(1);
                            break;
                        case "create":
                            controller.Create();
                            break;
                        case "update":
                            controller.Update(1);
                            break;
                        case "list":
                            controller.List();
                            break;
                        default:
                            Console.WriteLine("Unknown command");
                            break;
                    }
                }
            }

        }
    }
}