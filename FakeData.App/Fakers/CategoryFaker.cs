using FakeData.App.Models;
using static FakeData.App.Utils.DataGenerator;

namespace FakeData.App.Fakers;

public class CategoryFaker : TrDataGenerator<Category>
{
    public CategoryFaker()
    {
        RuleFor(c => c.Name, f => f.Commerce.Categories(1)[0]);
        RuleFor(c => c.Description, f => f.Lorem.Sentence());
    }
}
