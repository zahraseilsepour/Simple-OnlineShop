using System.ComponentModel.DataAnnotations;

namespace Shop.Domain.Models.BaseEntites
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public bool IsDelet { get; set; }
        public DateTime CreateDate { get; set; }= DateTime.Now;
    }
}
