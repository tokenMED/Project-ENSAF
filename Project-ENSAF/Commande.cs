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
    
    public partial class Commande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Commande()
        {
            this.Produit_commande = new HashSet<Produit_commande>();
        }
    
        public int NCommande { get; set; }
        public int codeMagazin { get; set; }
        public System.DateTime dateDemande { get; set; }
        public System.DateTime dateArriveSouhaite { get; set; }
        public bool statut { get; set; }
        public Nullable<int> idFournisseur { get; set; }
    
        public virtual Magazin Magazin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produit_commande> Produit_commande { get; set; }
        public virtual Fournisseur Fournisseur { get; set; }
    }
}
