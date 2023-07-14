using BuberDinner.Application.Menus.Commands;
using BuberDinner.Application.UnitTests.TestUtils.Constants;

namespace BuberDinner.Application.UnitTests.Menus.Commands.TestUtils;

public class CreateMenuCommandUtils
{
    //name
    //description
    //list of sections
    public static CreateMenuCommand CreateCommand(List<MenuSectionCommand>? sections = null)
        => new CreateMenuCommand(
        new Guid(Constants.Host.Id.Value.ToString()!),
        Constants.Menu.Name,
        Constants.Menu.Description,
        sections ?? CreateSectionsCommands()
    );

    public static List<MenuSectionCommand> CreateSectionsCommands(
        int sectionCount = 1, List<MenuItemCommand>? items = null) =>
        Enumerable.Range(0, sectionCount)
            .Select(index => new MenuSectionCommand(
                Constants.Menu.SectionNameFromGivenIndex(index),
                Constants.Menu.SectionDescriptionFromGivenIndex(index),
                CreateItemsCommands()
            )).ToList();

    public static List<MenuItemCommand> CreateItemsCommands(int itemCount = 1) =>
        Enumerable.Range(0, itemCount)
            .Select(index => new MenuItemCommand(
                Constants.Menu.ItemNameFromGivenIndex(index),
                Constants.Menu.ItemDescriptionFromGivenIndex(index)
            )).ToList();
}