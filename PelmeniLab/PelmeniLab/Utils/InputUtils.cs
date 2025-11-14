using System;
using System.Globalization;

public static class InputUtils
{
    public static double ReadDouble(string prompt, double? defaultValue = null)
    {
        while (true)
        {
            Console.Write(prompt + (defaultValue.HasValue ? $" [{defaultValue.Value}]" : "") + ": ");
            var s = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(s))
            {
                if (defaultValue.HasValue) return defaultValue.Value;
                continue;
            }

            if (double.TryParse(s.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out var v))
                return v;
            if (double.TryParse(s.Replace('.', ','), NumberStyles.Any, CultureInfo.GetCultureInfo("ru-RU"), out v))
                return v;

            Console.WriteLine("Не удалось распознать число. Введите снова (разделитель — точка или запятая).");
        }
    }

    public static int CeilToInt(double x) => (int)Math.Ceiling(x);
}
