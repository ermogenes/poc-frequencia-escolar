//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EscolaColetorWeb.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class chamada
    {
        public int cd_chamada { get; set; }
        public System.DateTime dt_chamada { get; set; }
        public int cd_aluno { get; set; }
        public bool in_presente { get; set; }
    
        public virtual aluno aluno { get; set; }
    }
}