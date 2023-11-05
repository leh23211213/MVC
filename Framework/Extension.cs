using System.Data.SqlTypes;

namespace Framework
{
    public static class Extension
    {
        public static int ToInt(this string value)
        {
            return int.Parse(value);
        }
        public static bool ToInt(this string value, out int i)
        {
            return int.TryParse(value, out i);
        }

        public static bool ToBool(this string value)
        {
            var v = value.ToLower();
            if (v == "y" || v == "true") return true;
            return false;
        }
        public static string ToString(this bool value, string format)
        {
            if (format == "y/n")
                return value ? "Yes" : "No";
            if (format == "c/k")
                return value ? "Có" : "Không";
            return value ? "True" : "False";
        }
    }
}