using System;
using System.Collections.Generic;

namespace ConsoleApp29
{
    class Tshirt
    {
        public string size;
        public string color;
        public float price;
        public string image;

        public Tshirt(string valueSize ,string valueColor, float valuePrice,string valueImage)
        {
            size = valueSize;
            color = valueColor;
            price = valuePrice;
            image = valueImage;
        }


    }
    class User
    {
        public string name;
        public string email;

        public User(string valueName,string valueEmail)
        {
            name = valueName;
            email = valueEmail;
        }
        class ShoppingCart
        {
            class Address
            {
                public string street;
                public string city;
                public string zipCode;

                public Address(string valueStreet, string valueCity, string valuezipCode)
                {
                    street = valueStreet;
                    city = valueCity;
                    zipCode = valuezipCode;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int Total;
            List<Tshirt> tshirts = new List<Tshirt>();

            Tshirt Redshirt = new Tshirt("L","Red",500,"none");
            Tshirt Blackshirt = new Tshirt("M", "Black", 750, "none");
            Tshirt Blueshirt = new Tshirt("S", "Blue", 625, "none");

            tshirts.Add(Redshirt);
            tshirts.Add(Blackshirt);
            tshirts.Add(Blueshirt);

            User Jame = new User("Jame Watson","Jame@gmail.com");
        }
    }
}
