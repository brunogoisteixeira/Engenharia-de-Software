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
    
    public partial class DIM_GRUPO_OBJETOS
    {
        public int ID_GRUPO_OBJETOS { get; set; }
        public Nullable<int> COD_GRUPO_OBJETOS { get; set; }
        public string DECRICAO_GRUPO_OBJETO { get; set; }
        public int ID_OBJETOS_FURTADOS { get; set; }
    
        public virtual DIM_OBJETOS_FURTADOS DIM_OBJETOS_FURTADOS { get; set; }
    }
}
