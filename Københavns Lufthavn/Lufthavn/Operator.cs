//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lufthavn
{
    using System;
    using System.Collections.Generic;
    
    public partial class Operator
    {
        public int OperatorID { get; set; }
        public int RouteID { get; set; }
        public int AirlineID { get; set; }
    
        public virtual Airline Airline { get; set; }
        public virtual Route Route { get; set; }
    }
}
