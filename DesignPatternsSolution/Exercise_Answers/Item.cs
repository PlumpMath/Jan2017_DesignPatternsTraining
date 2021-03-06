﻿
namespace Exercise_Answers
{
    public abstract class Item : LibObject, IRegistarable
    {
        public Item(int amount, int year)
        {
            AvailableAmount = amount;
            ObjType = ObjectType.Item;
            YearCreated = year;
        }

        public abstract RegisteredObject GetRegistrationInfo();
    }

    public class Book : Item
    {
        public Book(string author, string title, int year, int amount) : base(amount, year)
        {
            NameOrTitle = title;
            Author = author;
        }
        public string Author { get; set; }

        public override RegisteredObject GetRegistrationInfo()
        {
            return new RegisteredObject
            {
                Info = "Book Name: " + NameOrTitle + " , Author: " + Author + " Year: " + YearCreated,
                AvailableAmount = AvailableAmount
            };
        }
    }
}
