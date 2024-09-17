using FakeData.App.Models;
using FakeData.App.Utils;
using static FakeData.App.Utils.DataGenerator;

namespace FakeData.App.Fakers;

public class ProductFaker : TrDataGenerator<Product>
{
    public ProductFaker()
    {
        RuleFor(p => p.Name, f => f.Commerce.ProductName());
        RuleFor(p => p.Description, f => f.Commerce.ProductDescription());
        RuleFor(p => p.Price, f => decimal.Parse(f.Commerce.Price()));
        RuleFor(p => p.Stock, f => f.Random.Number(1, 1000));
        RuleFor(p => p.CreatedAt, f => f.Date.Past(1));
        RuleFor(p => p.Category, f => DataGenerator.GenerateSingle<Category, CategoryFaker>());
        RuleFor(p => p.User, f => DataGenerator.GenerateSingle<User, UserFaker>());
    }
}
