using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practices.Helper;
using Practices.models;

namespace Practices.Data
{
    public class DataInitializer
    {
        public static void seed(ModelBuilder mb)
        {
            mb.Entity<User>().HasData(new User
            {
                Id = 1,
                Username = "Shotiko",
                HashedPassword = "secure_password".HashHash(),
                IsBlocked = false,
                InvalidLoginAttemptsAmount = 0
            }) ;

            mb.Entity<Toys>().HasData(
                new Toys
                {
                    Id = 1,
                    Price = 100,
                    Name = "jdad",
                    Manufacturer = "uhAjidosk"
                },
                new Toys
                {
                    Id = 2,
                    Price = 50,
                    Name = " wejr029",
                    Manufacturer = "g9sdjfks"
                });
        }


    }
}
