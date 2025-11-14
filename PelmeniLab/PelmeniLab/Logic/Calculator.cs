using System;

public static class Calculator
{
    public static void RunCalculations(
        double Qsut, double t, double at, double af,
        double am, double aya, double a_s, double asp,
        double p_pa, double p_tm, double p_k,
        int shiftCount)
    {
        double R_p = Qsut / (shiftCount * t);
        int n_pa = InputUtils.CeilToInt(R_p / p_pa);

        double R_t = (at / 100.0) * R_p;
        int n_tm = InputUtils.CeilToInt(R_t / p_tm);

        double R_f = (af / 100.0) * R_p;
        int n_k = InputUtils.CeilToInt(R_f / p_k);

        if (Math.Abs((at + af) - 100.0) > 1e-6)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Предупреждение: a_t + a_f = {at + af:F2}%");
            Console.ResetColor();
        }

        Console.WriteLine("\n================= РЕЗУЛЬТАТЫ =================");
        Console.WriteLine($"Суточная выработка Qсут = {Qsut:F3} т");
        Console.WriteLine($"R_п = {R_p:F3} → n_па = {n_pa}");
        Console.WriteLine($"R_т = {R_t:F3} → n_тм = {n_tm}");
        Console.WriteLine($"R_ф = {R_f:F3} → n_к = {n_k}");

        if (am + aya + a_s + asp > 0)
        {
            Console.WriteLine("\nСостав фарша:");
            Console.WriteLine($"Мясо: {am}%, Яйца: {aya}%, Соль: {a_s}%, Специи: {asp}%");
        }

        Console.WriteLine("\nНажмите Enter для выхода...");
        Console.ReadLine();
    }
}
