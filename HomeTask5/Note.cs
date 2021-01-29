using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask5
{
    //public abstract class Note
    //{
    //    public string _name;


    //    public void Add()
    //    {

    //    }

    //    public void Get()
    //    {

    //    }
    //    public void Remove()
    //    {

    //    }

    //}
    public class Contact
    {
        public string _name;
        public string _phone;
        public byte _age;
        public Contact(string name, string phone, byte age)
        {
            _name = name;
            _phone = phone;
            _age = age;
        }
        public Contact()
        {
            _name = "";
            _phone = "";
            _age = 0;
        }

        public void Get()
        {
            Console.WriteLine($"{_name} - {_phone}  -  {_age}");
        }

        public void Add()
        {
            Console.WriteLine("Введите имя");

            _name = Console.ReadLine();

            Console.WriteLine("Введите номер телефона");

            _phone = Console.ReadLine();

            Console.WriteLine("Введите возраст");

            _age = Byte.Parse(Console.ReadLine());
        }

    }
    //public class Event : Note
    //{
    //    public DateTime _event_date;
    //    public string _description;
    //}
}
