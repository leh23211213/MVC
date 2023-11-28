// BUG:
// namespace MVC.Controllers
// {
//     using Framework;
//     internal class ConfigController : ControllerBase
//     {
//         private Config _config = Config.Instance;
//         public void ConfigPromptText(string text)
//         {
//             _config.PromptText = text;
//             Success("The command prompt will change next time");
//         }
//         public void ConfigPromptText(string text)
//         {
//             if (Enum.TryParse(text, true, out ConsoleColor color))
//             {
//                 _config.PromptColor = color;
//                 Success("The command prompt color will change next time");
//             }
//         }
//         public void CurrentDataAccess(){
//             var da = _config.DataAccess;
//             var file = _config.DataFile;
//             Inform($"Current data access engine: {da}rnCurrent data file: {file}");
//         }
//         public void ConfigDataAccess(string da, string file)
//         {
//             _config.DataAccess = da;
//             _config.DataFile = file;
//             Success("The changes will be available next time");
//         }
//     }
// }