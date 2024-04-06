using System;

namespace CoreArchitecture.Data
{
    public interface IBaseEntity<TKey> : IBaseEntity
    {
        TKey Id { get; set; }
        DateTime? CreationDate { get; set; }
        DateTime? LastUpdatedDate { get; set; }
    }

    public interface IBaseEntity
    {
    }
}
