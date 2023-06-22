using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Menus.ValueObjects;

namespace BuberDinner.Domain.Menus.Entities;

public sealed class MenuSection : Entity<MenuSectionId>
{
    private readonly List<MenuItem> _items = new();
    public IReadOnlyList<MenuItem> Items => _items.AsReadOnly();

    public string Name { get; }
    public string Description { get; }

    public MenuSection(MenuSectionId id,
                       string name,
                       string description,
                       List<MenuItem> items)
     : base(id)
    {
        Name = name;
        Description = description;
        _items = items;
    }

    public static MenuSection Create(string name,
                                           string description,
                                           List<MenuItem> menuItems)
    {
        return new(MenuSectionId.CreateUnique(), name, description, menuItems);
    }

#pragma warning disable CS8618
    private MenuSection() { }
#pragma warning restore CS8618
}