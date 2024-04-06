using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreArchitecture.Data
{
    public abstract class BaseEntity<TKey> : IBaseEntity<TKey>
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual TKey Id { get; set; }

        [Column(Order = 1001)]
        [DefaultValue("GETDATE()")]
        public DateTime? CreationDate { get; set; }

        [Column(Order = 1002)]
        public DateTime? LastUpdatedDate { get; set; }
    }
}
