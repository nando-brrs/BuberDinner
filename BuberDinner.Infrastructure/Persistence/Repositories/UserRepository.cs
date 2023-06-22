
using BubeerDinner.Application.Common.Interfaces.Persistence;
using BubeerDinner.Domain.Users;

namespace BuberDinner.Infrastructure.Persistence.Repositories;
public class UserRepository : IUserRepository
{
    private readonly List<User> _users = new();
    public void Add(User user)
    {
        _users.Add(user);
    }

    public User? GetUserByEmail(string email)
    {
        return _users.SingleOrDefault(u => u.Email == email);
    }
}