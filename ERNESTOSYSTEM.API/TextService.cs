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
            // Devuelve los nombres de los días en español (es-ES)
            var es = CultureInfo.GetCultureInfo("es-ES");
            return es.DateTimeFormat.DayNames;
        }
    }
}
