﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ParfumsEntities : DbContext
    {
        public ParfumsEntities()
            : base("name=ParfumsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Parfum> Parfums { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<ParfumInfo> ParfumInfoes { get; set; }
        public virtual DbSet<SalesInfo> SalesInfoes { get; set; }
    
        public virtual ObjectResult<BetweenSalesInfo_Result> BetweenSalesInfo(Nullable<int> lowNumber, Nullable<int> highNumber)
        {
            var lowNumberParameter = lowNumber.HasValue ?
                new ObjectParameter("LowNumber", lowNumber) :
                new ObjectParameter("LowNumber", typeof(int));
    
            var highNumberParameter = highNumber.HasValue ?
                new ObjectParameter("HighNumber", highNumber) :
                new ObjectParameter("HighNumber", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BetweenSalesInfo_Result>("BetweenSalesInfo", lowNumberParameter, highNumberParameter);
        }
    
        public virtual int insert_brend(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insert_brend", nameParameter);
        }
    
        public virtual int insert_category(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insert_category", nameParameter);
        }
    
        public virtual int insert_parfum(string name, Nullable<int> price, string comment, Nullable<int> cat_id, Nullable<int> bra_id)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(int));
    
            var commentParameter = comment != null ?
                new ObjectParameter("Comment", comment) :
                new ObjectParameter("Comment", typeof(string));
    
            var cat_idParameter = cat_id.HasValue ?
                new ObjectParameter("cat_id", cat_id) :
                new ObjectParameter("cat_id", typeof(int));
    
            var bra_idParameter = bra_id.HasValue ?
                new ObjectParameter("bra_id", bra_id) :
                new ObjectParameter("bra_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insert_parfum", nameParameter, priceParameter, commentParameter, cat_idParameter, bra_idParameter);
        }
    
        public virtual ObjectResult<SearchSalesInfo_Result> SearchSalesInfo(string searchText, Nullable<int> lowNumber, Nullable<int> highNumber)
        {
            var searchTextParameter = searchText != null ?
                new ObjectParameter("SearchText", searchText) :
                new ObjectParameter("SearchText", typeof(string));
    
            var lowNumberParameter = lowNumber.HasValue ?
                new ObjectParameter("LowNumber", lowNumber) :
                new ObjectParameter("LowNumber", typeof(int));
    
            var highNumberParameter = highNumber.HasValue ?
                new ObjectParameter("HighNumber", highNumber) :
                new ObjectParameter("HighNumber", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchSalesInfo_Result>("SearchSalesInfo", searchTextParameter, lowNumberParameter, highNumberParameter);
        }
    }
}