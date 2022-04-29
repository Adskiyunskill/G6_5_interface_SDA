// See https://aka.ms/new-console-template for more information
using G6_5_interface_SDA;

class Program
{
    public static void Main()
    {
        List<Company> comp1 = new List<Company>() {
    new Company("ABCD3",102,900001),
     new Company("ABCD1",101,900002),
    new Company("ABCD2",100,900003)

 };
        foreach (Company z in comp1) z.show();
        // создание экземпляра класса, реализующего
        // сравнение объектов по
        // количеству сотрудников
        Count SortPersons = new Count();
        // сортировка по количеству сотрудников
        comp1.Sort(SortPersons);
        // вывод результата сортировки
        Console.WriteLine("Результат сортировки:");
        foreach (Company z in comp1) z.show();
        // создание экземпляра класса, реализующего
        // сравнение объектов по названию компании
        CName SortName = new CName();
        // сортировка по названию компании
        comp1.Sort(SortName);
        // вывод результата сортировки
        Console.WriteLine("Результат сортировки:");
        foreach (Company z in comp1) z.show();
    }
}

