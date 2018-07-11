namespace BusinessLogic
{
    using Model;
    using System;
    using System.Collections.Generic;

    public static class Gourmet
    {
        private static List<Restaurant> restaurants = new List<Restaurant>();

        private static void MakeFakeList()
        {
            Random numberVotes = new Random();
            var Malditos = new Restaurant();
            Malditos.Id = 1;
            Malditos.Name = "Malditos Burger";
            Malditos.Suggested = numberVotes.Next(10, 500);
            var Factory = new Restaurant();
            Factory.Id = 2;
            Factory.Name = "Factory Grill";
            Factory.Suggested = numberVotes.Next(10, 500);
            var Kansas = new Restaurant();
            Kansas.Id = 3;
            Kansas.Name = "Kansas Grill";
            Kansas.Suggested = numberVotes.Next(10, 500);
            var Ulupica = new Restaurant();
            Ulupica.Id = 4;
            Ulupica.Name = "Mama Ulupica";
            Ulupica.Suggested = numberVotes.Next(10, 500);
            var Corleone = new Restaurant();
            Corleone.Id = 5;
            Corleone.Name = "Don Corleone";
            Corleone.Suggested = numberVotes.Next(10, 500);
            var Padrino = new Restaurant();
            Padrino.Id = 6;
            Padrino.Name = "El Padrino";
            Padrino.Suggested = numberVotes.Next(10, 500);
            var Bunker = new Restaurant();
            Bunker.Id = 7;
            Bunker.Name = "Bunker";
            Bunker.Suggested = numberVotes.Next(10, 500);
            restaurants.Add(Malditos);
            restaurants.Add(Factory);
            restaurants.Add(Kansas);
            restaurants.Add(Ulupica);
            restaurants.Add(Corleone);
            restaurants.Add(Padrino);
            restaurants.Add(Bunker);
        }

        public static List<Restaurant> GetMostRecommended()
        {
            MakeFakeList();
            restaurants.Sort(delegate (Restaurant a, Restaurant b)
            {
                return b.Suggested.CompareTo(a.Suggested);
            });

            return restaurants;
        }
    }
}
