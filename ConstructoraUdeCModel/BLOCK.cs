//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConstructoraUdeCModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class BLOCK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BLOCK()
        {
            this.PROPERTY = new HashSet<PROPERTY>();
        }
    
        public string CODE { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string PROJECT { get; set; }
    
        public virtual PROJECT PROJECT1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROPERTY> PROPERTY { get; set; }
    }
}
