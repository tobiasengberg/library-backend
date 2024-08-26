using System.ComponentModel.DataAnnotations;

namespace library_api.Models;

public class Book
{
    [Key]
    public int Id { get; set; }
    public string Creator { get; set; }
    public string Title { get; set; }
    public string Publisher { get; set; }
    public string Date { get; set; }

    public Book()
    {
        
    }

    public Book(string creator, string title, string publisher, string date)
    {
        Creator = creator;
        Title = title;
        Publisher = publisher;
        Date = date;
    }
}