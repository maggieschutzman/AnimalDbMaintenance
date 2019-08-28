using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Animals.Models {
    public class Animal {
        [Key]
        public int AniamlId { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(30)]
        public string Habitat { get; set; }
        [Range(0, 10)]
        public int Legs { get; set; }
        [StringLength(30)]
        public string Food { get; set; }

    }
}
