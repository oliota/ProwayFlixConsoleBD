//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class assistidos
    {
        public int id_assistido { get; set; }
        public Nullable<System.DateTime> dataehora { get; set; }
    
        public virtual filmes filmes { get; set; }
        public virtual series series { get; set; }
        public virtual usuarios usuarios { get; set; }
    }
}