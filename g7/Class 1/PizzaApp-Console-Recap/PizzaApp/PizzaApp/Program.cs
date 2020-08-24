using System;
using System.Collections.Generic;
using PizzaApp.Domain.Domains;
using PizzaApp.Domain.SeedEntities;
using PizzaApp.Services;

namespace PizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzas = SeedUsersAndPizzas.SeedPizzas();

            var users = SeedUsersAndPizzas.SeedUsers();

            var pizzaRepo = new PizzaRepo();

            List<Pizza> funghiPizzas = pizzaRepo.GetPizzasByType(pizzas, Domain.Enums.PizzaType.Funghi);

            funghiPizzas.ForEach(p => Console.WriteLine(p.Type));
        }
    }
}
