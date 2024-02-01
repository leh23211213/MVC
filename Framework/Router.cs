
namespace Framework
{
    using System.Text;
    using RoutingTable = Dictionary<string, ControllerAction>;
    public delegate void ControllerAction(Parameter parameter = null);

    public class Router
    {
        private static Router _instance;
        private readonly RoutingTable _routingTable;
        private readonly Dictionary<string, string> _helpTable;
        private Router()
        {
            _routingTable = new RoutingTable();
            _helpTable = new Dictionary<string, string>();
        }
        public static Router Instance => _instance ?? (_instance = new Router());
        public string GetRoutes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var k in _routingTable.Keys)
                sb.AppendFormat("{0}, ", k);
            return sb.ToString();
        }
        public string GetHelp(string key)
        {
            if (_helpTable.ContainsKey(key))
                return _helpTable[key];
            else
                return "Documentation not ready yet!";
        }
        public void Register(string route, ControllerAction action, string help = "")
        {
            if (!_routingTable.ContainsKey(route))
            {
                _routingTable[route] = action;
                _helpTable[route] = help;
            }
        }
        public void Forward(string request)
        {
            var req = new Request(request);
            if (!_routingTable.ContainsKey(req.Route))
                throw new Exception("Command not found!");
            if (req.Parameter == null)
                _routingTable[req.Route]?.Invoke();
            else
                _routingTable[req.Route]?.Invoke(req.Parameter);
        }
        private class Request
        {
            public string Route { get; private set; }
            public Parameter Parameter { get; private set; }
            public Request(string request)
            {
                Analyze(request);
            }
            private void Analyze(string request)
            {
                var questionMarkIndex = request.IndexOf('?');
                if (questionMarkIndex < 0)
                {
                    Route = request.ToLower().Trim();
                }
                else
                {
                    if (questionMarkIndex <= 1) throw new Exception("Invalid request parameter");
                    var tokens = request.Split(new[] { '?' }, 2, StringSplitOptions.RemoveEmptyEntries);
                    Route = tokens[0].Trim().ToLower();
                    var parameterPart = request.Substring(questionMarkIndex + 1).Trim();
                    Parameter = new Parameter(parameterPart);
                }
            }
        }
    }
}