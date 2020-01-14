using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SLCSCore.Data;

namespace SLCSCore.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SLCSContext(serviceProvider.GetRequiredService<DbContextOptions<SLCSContext>>()))
            {
                if (context.Book.Any())
                {
                    return;
                }

                context.Book.AddRange(
                    new Book
                    {
                       BookName＝"三隻小豬",
                       Author＝"A",
                       Publisher="A",
                       PublishPlace="USA",
                       PublishYear="1600",
                       Isbn="12345678",
                       TopicCode=1,
                       BookStatusCode=1,
                       LocationCode=1
                    }
                );

                context.User.AddRange(
                    new User
                    {
                     Account="123",
                     IdNumber="E12345678",
                     Password="@bc123",
                     Phone="0912345678",
                     Email="abc@gmail.com"
                    }
                );

                 

                context.SaveChanges();
            }
        }
    }
}
