# Domain Models

## Menu

```csharp
class Menu()
{
    Menu Create();
    void AddDinner(Dinner dinner);
    void RemoveDinner(Dinner dinner);
    void UpdateSection(MenuSection section);
}
```

```json
{
  "id": "00000000-0000-0000-0000-000000000000",
  "name": "Yummy menu",
  "description": "a menu with yummy food",
  "averageRating": 4.5,
  "sections": [
    {
      "id": "00000000-0000-0000-0000-000000000000",
      "name": "Appetizers",
      "description": "Starters",
      "items": [
        {
          "id": "00000000-0000-0000-0000-000000000000",
          "name": "Fried Pickles",
          "description": "Deep fried pickles",
          "price": 5.99
        }
      ]
    }
  ],
  "createdDateTime": "2020-01-01T00:00:00.0000000Z",
  "updatedDateTime": "2020-01-01T00:00:00.0000000Z",
  "hostId": "00000000-0000-0000-0000-000000000000",
  "dinnerIds": ["00000000-0000-0000-0000-000000000000"],
  "menuReviewIds": ["00000000-0000-0000-0000-000000000000"]
}
```
