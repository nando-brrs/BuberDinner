using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Models;

public abstract class AggregateRootId<TId> : ValueObject
{
    public abstract TId Value { get; protected set; }
}