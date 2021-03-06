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
    
    public partial class Route
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Route()
        {
            this.Operators = new HashSet<Operator>();
        }
    
        public int RouteID { get; set; }
        public int AirlineID { get; set; }
        public int OriginAirportID { get; set; }
        public int DestinationAirportID { get; set; }
        public Nullable<System.DateTime> DepatureDate { get; set; }
        public Nullable<System.DateTime> ArrivalDate { get; set; }
    
        public virtual Airline Airline { get; set; }
        public virtual Airport Airport { get; set; }
        public virtual Airport Airport1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operator> Operators { get; set; }
    }
}
