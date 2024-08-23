namespace GraphQLExample.GraphQL
{
    public class Query
    {
        public string Hello() => "Hello, world!";

        public List<Book> GetBooks() => new List<Book>
        {
            new Book { Id = 1, Title = "C# in Depth", Author = new Author { Id = 1, Name = "Jon Skeet" }},
            new Book { Id = 2, Title = "Pro ASP.NET Core", Author = new Author { Id = 2, Name = "Adam Freeman" }},
        };

        public List<Author> GetAuthors() => new List<Author>
        {
            new Author { Id = 1, Name = "Jon Skeet" },
            new Author { Id = 2, Name = "Adam Freeman" }
        };
    }
}
