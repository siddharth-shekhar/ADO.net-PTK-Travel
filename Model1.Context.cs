﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PKR_Travels_DatabaseFirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class REDBUSEntities : DbContext
    {
        public REDBUSEntities()
            : base("name=REDBUSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BusInfo> BusInfoes { get; set; }
        public virtual DbSet<Bus_View> Bus_View { get; set; }
    
        public virtual ObjectResult<spGetBusInfo_Result> spGetBusInfo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetBusInfo_Result>("spGetBusInfo");
        }
    }
}
