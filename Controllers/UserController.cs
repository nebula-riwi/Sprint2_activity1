using Sprint2.Data;
using Sprint2.Models;
using Sprint2.DTOs;

namespace Sprint2.Controllers;

public class UserController
{
    
    // 🔹 READ (todos)
    public List<User> Index()
    {
        using (var db = new MysqlDbContext())
        {
            return db.users.ToList();
        }
    }

    public User? GetById(int id)
    {
        using (var db = new MysqlDbContext())
        {
            return db.users.Find(id);
        }
    }

    public User? GetByEmail(string email)
    {
        using (var db = new MysqlDbContext())
        {
            return db.users.FirstOrDefault(e => e.Email == email);
        }
    }

    public List<User> GetUsersByCity(string city)
    {
        using (var db = new MysqlDbContext())
        {
            return db.users.Where(u => u.City == city).ToList();
        }
    }
    public List<User> GetUsersByCountry(string country)
    {
        using (var db = new MysqlDbContext())
        {
            return db.users.Where(u => u.Country == country).ToList();
        }
    }
    public List<User> GetUsersByAge(int age)
    {
        using (var db = new MysqlDbContext())
        {
            return db.users.Where(u => u.Age > age).ToList();
        }
    }
    public List<User> GetUsersByGender(string gender)
    {
        using (var db = new MysqlDbContext())
        {
            return db.users.Where(u => u.Gender == gender).ToList();
        }
    }
    public List<UsersCount> GetTotalByCity()
    {
        using (var db = new MysqlDbContext())
        {
            return db.users
                .GroupBy(u => u.City)
                .Select(g => new UsersCount
                {
                    Place = g.Key,
                    UserCount = g.Count()
                })
                .ToList();
        }
    }
    public List<UsersCount> GetTotalByCountry()
    {
        using (var db = new MysqlDbContext())
        {
            return db.users
                .GroupBy(u => u.Country)
                .Select(g => new UsersCount
                {
                    Place = g.Key,
                    UserCount = g.Count()
                })
                .ToList();
        }
    }
    public List<User> GetUsersWithoutPhone()
    {
        using (var db = new MysqlDbContext())
        {
            return db.users.Where(u => u.Phone == null).ToList();
        }
    }
    public List<User> GetUsersWithoutAddress()
    {
        using (var db = new MysqlDbContext())
        {
            return db.users.Where(u => u.Address == null).ToList();
        }
    }
    public List<User> GetLastUsers()
    {
        using (var db = new MysqlDbContext())
        {
            return db.users
                .OrderByDescending(u => u.Id)
                .Take(10)
                .ToList();
        }
    }
    public List<User> GetUsersByLastname()
    {
        using (var db = new MysqlDbContext())
        {
            return db.users
                .OrderBy(u => u.Last_name)
                .ToList();
        }
    }
}