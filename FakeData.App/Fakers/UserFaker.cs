using Bogus;
using FakeData.App.Models;
using static FakeData.App.Utils.DataGenerator;

namespace FakeData.App.Fakers;

public class UserFaker : TrDataGenerator<User>
{
    public UserFaker()
    {
        RuleFor(u => u.Username, f => f.Internet.UserName());
        RuleFor(u => u.Email, f => f.Internet.Email());
        RuleFor(u => u.PasswordHash, f => f.Internet.Password());
        RuleFor(u => u.CreatedAt, f => f.Date.Past(2));
        RuleFor(u => u.LastLogin, f => f.Date.Recent(30)); ;
    }
}
