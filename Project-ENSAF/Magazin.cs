//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_ENSAF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Magazin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Magazin()
        {
            this.Commandes = new HashSet<Commande>();
            this.Vente_magazin = new HashSet<Vente_magazin>();
        }
    
        public int codeMagazin { get; set; }
        public byte[] nomMagazin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commande> Commandes { get; set; }
        public virtual Stock_Magazin Stock_Magazin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vente_magazin> Vente_magazin { get; set; }
    }
}
