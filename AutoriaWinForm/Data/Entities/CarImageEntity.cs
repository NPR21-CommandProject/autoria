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
        public int MyProperty { get; set; }
    }
}
