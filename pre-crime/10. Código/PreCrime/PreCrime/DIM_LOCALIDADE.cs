//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PreCrime
{
    using System;
    using System.Collections.Generic;
    
    public partial class DIM_LOCALIDADE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIM_LOCALIDADE()
        {
            this.FATO_CADASTRO_CRIME = new HashSet<FATO_CADASTRO_CRIME>();
        }
    
        public int ID_OCALIDADE { get; set; }
        public Nullable<int> COD_LOCALIDADE { get; set; }
        public string CIDADE { get; set; }
        public string ESTADO { get; set; }
        public Nullable<int> LATITUDE { get; set; }
        public Nullable<int> LONGITUDE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FATO_CADASTRO_CRIME> FATO_CADASTRO_CRIME { get; set; }
    }
}
