using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.CodeFirst.Example.Context.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        //[Column(TypeName = "nvarchar(25)")]
        [Column(TypeName = "nvarchar")]
        [MaxLength(25)]
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
