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
    
    public partial class DIM_TEMPO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIM_TEMPO()
        {
            this.FATO_CADASTRO_CRIME = new HashSet<FATO_CADASTRO_CRIME>();
        }
    
        public int ID_TEMPO { get; set; }
        public string NIVEL { get; set; }
        public Nullable<System.DateTime> DATA { get; set; }
        public Nullable<short> DIA { get; set; }
        public string DIADASEMANA { get; set; }
        public string DIAUTIL { get; set; }
        public string FERIADO { get; set; }
        public string TIPOFERIADO { get; set; }
        public string FIMSEMANA { get; set; }
        public Nullable<short> QUINZENA { get; set; }
        public Nullable<short> MES { get; set; }
        public string NOMEMES { get; set; }
        public string FIMMES { get; set; }
        public Nullable<short> TRIMESTRE { get; set; }
        public string NOMETRIMESTRE { get; set; }
        public Nullable<short> SEMESTRE { get; set; }
        public string NOMESEMESTRE { get; set; }
        public short ANO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FATO_CADASTRO_CRIME> FATO_CADASTRO_CRIME { get; set; }
    }
}
