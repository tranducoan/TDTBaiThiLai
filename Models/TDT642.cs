using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TDTBaiThiLai.Models
{
    [Table("TDT642s")]
    public class TDT642
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Day { get; set; }
// TDT642  câu 1
    }
}