//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dbdata
{
    using System;
    using System.Collections.Generic;
    
    public partial class GameGenre
    {
        public int GameID { get; set; }
        public int CodeID { get; set; }
        public Nullable<bool> Dummy { get; set; }
    
        public virtual Code Code { get; set; }
        public virtual Game Game { get; set; }
    }
}
