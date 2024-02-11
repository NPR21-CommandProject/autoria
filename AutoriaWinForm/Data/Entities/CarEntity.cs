using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoriaWinForm.Data.Entities
{
    [Table("tblCars")]
    public class CarEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Brand { get; set; }
        [Required, StringLength(200)]
        public string Model { get; set; }
        [Required, StringLength(200)]
        public int Price { get; set; }
        [Required]
        public string Odometer { get; set; }
        [Required]
        public int EngineCapacity { get; set; }
        [Required]
        public string FuelType { get; set; }
        [Required, StringLength(200)]
        public DateTime DateCreated { get; set; }
        public int AddedByUserId { get; set; }

       
        [ForeignKey("AddedByUserId")] 
        public virtual UserEntity AddedByUser { get; set; }

       
        public virtual ICollection<CarImageEntity> CarImages { get; set; }
        
    }
}
