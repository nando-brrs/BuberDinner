using BubeerDinner.Domain.Entities;

namespace BubeerDinner.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}