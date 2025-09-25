namespace Sprint2.Models;

public class User
{
    public int Id { get; set; }  
    public string First_name { get; set; }
    public string Last_name { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string? Phone { get; set; }
    public string? Cellphone { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Zipcode { get; set; }
    public string? Country { get; set; }
    public string? Gender { get; set; }
    public int? Age { get; set; }
    public string? Password { get; set; }
    public DateTime? Created_at { get; set; }
    public DateTime? Updated_at { get; set; }
    
}