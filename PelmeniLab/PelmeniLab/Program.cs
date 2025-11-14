using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Лабораторная работа: Расчет производительности мини-цеха пельменей\n");

        const int shiftCount = 2;

        double Qsut = InputUtils.ReadDouble("Суточная выработка готовой продукции Qсут, т");
        double t = InputUtils.ReadDouble("Продолжительность одной смены t, ч");

        Console.WriteLine("\nВведите массовые доли (в процентах).");
        double at = InputUtils.ReadDouble("Массовая доля теста a_t, %");
        double af = InputUtils.ReadDouble("Массовая доля фарша a_f, % (если неизвестно — 0)", 0);

        double am = 0, aya = 0, a_s = 0, asp = 0;
        if (af <= 0)
        {
            Console.WriteLine("\nВведите состав фарша:");
            am = InputUtils.ReadDouble("Массовая доля мяса a_m, %");
            aya = InputUtils.ReadDouble("Массовая доля яиц a_я, %");
            a_s = InputUtils.ReadDouble("Массовая доля соли a_с, %");
            asp = InputUtils.ReadDouble("Массовая доля специй a_сп, %");
            af = am + aya + a_s + asp;
        }

        Console.WriteLine("\nПаспортные производительности машин (т/ч):");
        double p_pa = InputUtils.ReadDouble("Производительность пельменного автомата p_па, т/ч");
        double p_tm = InputUtils.ReadDouble("Производительность тестомеса p_тм, т/ч");
        double p_k = InputUtils.ReadDouble("Производительность куттера p_к, т/ч");

        
    }
}
