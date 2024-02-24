using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoriaWinForm.Data.Entities
{
    [Table("tblCarImages")]
    public class CarImageEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        public short Priority { get; set; }
        public DateTime DateCreated { get; set; }
        [ForeignKey("Car")]
        public int CarId { get; set; }
        public virtual CarEntity Car { get; set; }
    }
}
