// BUG:
// namespace MVC
// {
//     using DataServices;
//     using Newtonsoft.Json;
//     internal class Config
//     {
//         private static Config _instance;
//         public static Config Instance = _instance ?? (_instance = new Config());
//         private Config() { }
//         private ConfigSettings _settings;

//         // private Properties.Settings _s = Properties.Settings.Default;
//         // public void Reload() => _s.Reload();
//         private string ConfigFilePath = "appsettings.json";
//         public void LoadSettings()
//         {
//             if (File.Exists(ConfigFilePath))
//             {
//                 string json = File.ReadAllText(ConfigFilePath);
//                 _settings = JsonConvert.DeserializeObject<ConfigSettings>(json);
//             }
//             else
//             {
//                 _settings = new ConfigSettings
//                 {
//                     DataAccess = "json",
//                     PromptText = "Enter data:",
//                     PromptColor = ConsoleColor.White,
//                     DataFile = "data.json"
//                 };
//                 SaveSettings();
//             }
//         }
//         public void SaveSettings()
//         {
//             string json = JsonConvert.SerializeObject(_settings, Formatting.Indented);
//             File.WriteAllText(ConfigFilePath, json);
//         }
//         public IDataAccess IDataAccess
//         {
//             get
//             {
//                 var da = _settings.DataAccess;
//                 switch (da.ToLower())
//                 {
//                     case "json": return new JsonDataAccess();
//                     case "xml": return new XmlDataAccess();
//                     default: return new JsonDataAccess();
//                 }
//             }
//         }

//         // public string DataAccess
//         // {
//         //     get => _settings.DataAccess;
//         //     set
//         //     {
//         //         _settings.DataAccess = value;
//         //         SaveSettings();
//         //     }
//         // }
//         // public string PromptText
//         // {
//         //     get => _settings.PromptText;
//         //     set
//         //     {
//         //         _settings.PromptText = value;
//         //         SaveSettings();
//         //     }
//         // }
//         // public ConsoleColor PromptColor
//         // {
//         //     get => _settings.PromptColor;
//         //     set
//         //     {
//         //         _settings.PromptColor = value;
//         //         SaveSettings();
//         //     }
//         // }
//         // public string DataFile
//         // {
//         //     get => _settings.DataFile;
//         //     set
//         //     {
//         //         _settings.DataFile = value;
//         //         SaveSettings();
//         //     }
//         // }
//     }
//     public class ConfigSettings
//     {
//         public string DataAccess { get; set; }
//         public string PromptText { get; set; }
//         public ConsoleColor PromptColor { get; set; }
//         public string DataFile { get; set; }
//     }
// }