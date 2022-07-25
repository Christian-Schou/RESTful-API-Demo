using Microsoft.EntityFrameworkCore;
using REST_API_TEMPLATE.Models;

namespace REST_API_TEMPLATE.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder _builder;

        public DbInitializer(ModelBuilder builder)
        {
            _builder = builder;
        }

        public void Seed()
        {
            _builder.Entity<Author>().HasData(
                new Author()
                {
                    Id = new Guid(),
                    Name = "J.K. Rowling",
                    DateOfBirth = new DateTime(1965, 07, 31),
                    Books = new List<Book>()
                    {
                        new Book()
                        {
                             Id = new Guid(),
                             Title = "Harry Potter and the Sorcerer's Stone",
                             Description = "Harry Potter's life is miserable. His parents are dead and he's stuck with his heartless relatives, who force him to live in a tiny closet under the stairs.",
                             Genre = Genre.Fantasy,
                             Publisher = "Scholastic; 1st Scholastic Td Ppbk Print., Sept.1999 edition (September 1, 1998)",
                             ISBN = "978-0439708180",
                             Rating = 5
                        },
                        new Book()
                        {
                            Id = new Guid(),
                            Title = "Harry Potter and the Chamber of Secrets",
                            Description = "Ever since Harry Potter had come home for the summer, the Dursleys had been so mean and hideous that all Harry wanted was to get back to the Hogwarts School for Witchcraft and Wizardry. ",
                            Genre = Genre.Fantasy,
                            Publisher = "Scholastic Paperbacks; Reprint edition (September 1, 2000)",
                            ISBN = "978-0439064873",
                            Rating = 5
                        }
                    }
                },
                new Author()
                {
                    Id = new Guid(),
                    Name = "Walter Isaacson",
                    DateOfBirth = new DateTime(1952, 05, 20),
                    Books = new List<Book>()
                    {
                        new Book()
                        {
                            Id = new Guid(),
                            Title = "Steve Jobs",
                            Description = "Walter Isaacson’s “enthralling” (The New Yorker) worldwide bestselling biography of Apple cofounder Steve Jobs.",
                            Genre = Genre.Biography,
                            Publisher = "Simon & Schuster; 1st edition (October 24, 2011)",
                            ISBN = "978-1451648539",
                            Rating = 4.5
                        }
                    }
                });
        }
    }
}
