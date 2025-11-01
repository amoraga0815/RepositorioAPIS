using System.Globalization;

namespace ERNESTOSYSTEM.API
{
    public static class TextService
    {
        public static string ToUpper(string? input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            return input.ToUpperInvariant();
        }

        public static IEnumerable<string> GetWeekDays()
        {
            // Devuelve los nombres de los días según la cultura actual del servidor
            return CultureInfo.CurrentCulture.DateTimeFormat.DayNames;
        }
    }
}
