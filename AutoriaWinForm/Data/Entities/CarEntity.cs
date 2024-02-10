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
        public string VehicleType { get; set; }
        [Required, StringLength(200)]
        public string Price { get; set; }
        [Required, StringLength(50)]
        public string Odometer { get; set; }
        [Required, StringLength(50)]
        public string EngineCapacity { get; set; }
        [Required]
        public string FuelType { get; set; }
        [Required, StringLength(200)]
        public string PhotoDescription { get; set; }
        [Required, StringLength(1500)]
        public string CarDescription { get; set; }
        [Required, StringLength(1500)]
        public DateTime DateCreated { get; set; }
        public virtual ICollection<CarImageEntity> CarImages { get; set; }
    }
}
