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
    
    public partial class TB_TIPO_OBJETO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_TIPO_OBJETO()
        {
            this.TB_TIPO_OBJETO_OCORRENCIA = new HashSet<TB_TIPO_OBJETO_OCORRENCIA>();
        }
    
        public int COD_TIPO_OBJETO { get; set; }
        public string DESCRICAO_OBJETO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TIPO_OBJETO_OCORRENCIA> TB_TIPO_OBJETO_OCORRENCIA { get; set; }
    }
}
