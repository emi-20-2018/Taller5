//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Taller5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cliente()
        {
            this.cliente1 = new HashSet<cliente>();
        }
        [Key][StringLength(10,MinimumLength =10)]
        public string id { get; set; }
        [Required]
        public int ci { get; set; }
        [Required][Display(Name ="Nombre Completo")][StringLength(200,MinimumLength =50)]
        public string nombre { get; set; }
        [Required][Display(Name = "Nombre Completo")][StringLength(200, MinimumLength = 50)]
        public string dirección { get; set; }
        [Required]
        public int teléfono { get; set; }
        [Required][StringLength(10,MinimumLength =10)]
        public string id_cliente { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cliente> cliente1 { get; set; }
        public virtual cliente cliente2 { get; set; }
    }
}