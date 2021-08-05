using Domain.Entities.Bases;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class SpecialityClinica : EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
