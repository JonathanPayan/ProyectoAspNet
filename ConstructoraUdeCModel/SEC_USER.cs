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
    
    public partial class SEC_USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SEC_USER()
        {
            this.SEC_SESSION = new HashSet<SEC_SESSION>();
            this.SEC_USER_ROLE = new HashSet<SEC_USER_ROLE>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public string LASTNAME { get; set; }
        public string CELLPHONE { get; set; }
        public string EMAIL { get; set; }
        public string USER_PASSWORD { get; set; }
        public string ACTIONCITY { get; set; }
    
        public virtual CITY CITY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEC_SESSION> SEC_SESSION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEC_USER_ROLE> SEC_USER_ROLE { get; set; }
    }
}
