using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6_5_interface_SDA
{
    internal class Company
    {
        string name; //название
        int persons; //количество сотрудников
        int money; // месячный фонд заработной платы
        public string Name
        {// свойство
            get { return name; }
        }
        public int Persons
        {// свойство
            get { return persons; }
        }
        public Company(
        string name, int persons, int money)
        {
            this.name = name; this.persons = persons;
            this.money = money;
        }
        // печать информации о компании
        public void show()
        {
        Console.WriteLine("В компании " + name +
        " трудятся " + persons + " сотрудников ");
            Console.WriteLine("Фонд зарплаты: " + money);
        }
        // описания других методов – см. пример 3.4
    } // класс Company
      // создание класса для сравнения объектов по
      // первому критерию - количество сотрудников
}

