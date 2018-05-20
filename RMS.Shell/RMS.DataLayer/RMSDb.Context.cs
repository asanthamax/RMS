﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RMS.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class erp_hotelEntities : DbContext
    {
        public erp_hotelEntities()
            : base("name=erp_hotelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int DeleteBilling(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteBilling", idParameter);
        }
    
        public virtual int DeleteBranch(Nullable<int> branchId)
        {
            var branchIdParameter = branchId.HasValue ?
                new ObjectParameter("branchId", branchId) :
                new ObjectParameter("branchId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteBranch", branchIdParameter);
        }
    
        public virtual int DeleteCustomer_attributes(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteCustomer_attributes", idParameter);
        }
    
        public virtual int DeleteCustomers(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteCustomers", idParameter);
        }
    
        public virtual int DeleteDeleteOrders(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteDeleteOrders", idParameter);
        }
    
        public virtual int DeleteDeletePriority_level(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteDeletePriority_level", idParameter);
        }
    
        public virtual int DeleteMenu(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteMenu", idParameter);
        }
    
        public virtual int DeleteMenu_category(Nullable<int> categoryId)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteMenu_category", categoryIdParameter);
        }
    
        public virtual int DeleteMenu_gallery(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteMenu_gallery", idParameter);
        }
    
        public virtual int DeleteMenu_items(Nullable<int> itemID)
        {
            var itemIDParameter = itemID.HasValue ?
                new ObjectParameter("itemID", itemID) :
                new ObjectParameter("itemID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteMenu_items", itemIDParameter);
        }
    
        public virtual int DeleteMenu_price(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteMenu_price", idParameter);
        }
    
        public virtual int DeleteOrders_tables(Nullable<int> orderId)
        {
            var orderIdParameter = orderId.HasValue ?
                new ObjectParameter("orderId", orderId) :
                new ObjectParameter("orderId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteOrders_tables", orderIdParameter);
        }
    
        public virtual int DeleteSequence_table(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteSequence_table", idParameter);
        }
    
        public virtual int DeleteSpecial_offers(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteSpecial_offers", idParameter);
        }
    
        public virtual int DeleteStock(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteStock", idParameter);
        }
    
        public virtual int DeleteTable_reservations(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteTable_reservations", idParameter);
        }
    
        public virtual int DeleteTableDetails(Nullable<int> tableno)
        {
            var tablenoParameter = tableno.HasValue ?
                new ObjectParameter("tableno", tableno) :
                new ObjectParameter("tableno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteTableDetails", tablenoParameter);
        }
    
        public virtual int DeleteUser_permissions(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteUser_permissions", idParameter);
        }
    
        public virtual int DeleteUser_role(Nullable<int> roleID)
        {
            var roleIDParameter = roleID.HasValue ?
                new ObjectParameter("roleID", roleID) :
                new ObjectParameter("roleID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteUser_role", roleIDParameter);
        }
    
        public virtual int DeleteUsers(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteUsers", idParameter);
        }
    
        public virtual ObjectResult<GetAllBillings_Result> GetAllBillings()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllBillings_Result>("GetAllBillings");
        }
    
        public virtual ObjectResult<GetAllBranches_Result> GetAllBranches()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllBranches_Result>("GetAllBranches");
        }
    
        public virtual ObjectResult<GetAllCustomer_attributes_Result> GetAllCustomer_attributes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllCustomer_attributes_Result>("GetAllCustomer_attributes");
        }
    
        public virtual ObjectResult<GetAllCustomers_Result> GetAllCustomers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllCustomers_Result>("GetAllCustomers");
        }
    
        public virtual ObjectResult<GetAllMenu_categories_Result> GetAllMenu_categories()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllMenu_categories_Result>("GetAllMenu_categories");
        }
    
        public virtual ObjectResult<GetAllMenu_galleries_Result> GetAllMenu_galleries()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllMenu_galleries_Result>("GetAllMenu_galleries");
        }
    
        public virtual ObjectResult<GetAllMenu_items_Result> GetAllMenu_items()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllMenu_items_Result>("GetAllMenu_items");
        }
    
        public virtual ObjectResult<GetAllMenu_prices_Result> GetAllMenu_prices()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllMenu_prices_Result>("GetAllMenu_prices");
        }
    
        public virtual ObjectResult<GetAllMenus_Result> GetAllMenus()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllMenus_Result>("GetAllMenus");
        }
    
        public virtual ObjectResult<GetAllOrders_Result> GetAllOrders()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllOrders_Result>("GetAllOrders");
        }
    
        public virtual ObjectResult<GetAllPriority_levels_Result> GetAllPriority_levels()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllPriority_levels_Result>("GetAllPriority_levels");
        }
    
        public virtual ObjectResult<GetAllSequence_tables_Result> GetAllSequence_tables()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllSequence_tables_Result>("GetAllSequence_tables");
        }
    
        public virtual ObjectResult<GetAllSpecial_offers_Result> GetAllSpecial_offers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllSpecial_offers_Result>("GetAllSpecial_offers");
        }
    
        public virtual ObjectResult<GetAllStocks_Result> GetAllStocks()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllStocks_Result>("GetAllStocks");
        }
    
        public virtual ObjectResult<GetAllTable_reservations_Result> GetAllTable_reservations()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllTable_reservations_Result>("GetAllTable_reservations");
        }
    
        public virtual ObjectResult<GetAllTables_Result> GetAllTables()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllTables_Result>("GetAllTables");
        }
    
        public virtual ObjectResult<GetAllUser_permissions_Result> GetAllUser_permissions()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllUser_permissions_Result>("GetAllUser_permissions");
        }
    
        public virtual ObjectResult<GetAllUsers_Result> GetAllUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllUsers_Result>("GetAllUsers");
        }
    
        public virtual int ManageMenuDetails(Nullable<int> id, string menuCode, string menuTitle, Nullable<short> status, Nullable<double> ratings, string remarks, string menuCategoryId, string branchCode, Nullable<bool> isDeleted)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var menuCodeParameter = menuCode != null ?
                new ObjectParameter("menuCode", menuCode) :
                new ObjectParameter("menuCode", typeof(string));
    
            var menuTitleParameter = menuTitle != null ?
                new ObjectParameter("menuTitle", menuTitle) :
                new ObjectParameter("menuTitle", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(short));
    
            var ratingsParameter = ratings.HasValue ?
                new ObjectParameter("ratings", ratings) :
                new ObjectParameter("ratings", typeof(double));
    
            var remarksParameter = remarks != null ?
                new ObjectParameter("remarks", remarks) :
                new ObjectParameter("remarks", typeof(string));
    
            var menuCategoryIdParameter = menuCategoryId != null ?
                new ObjectParameter("menuCategoryId", menuCategoryId) :
                new ObjectParameter("menuCategoryId", typeof(string));
    
            var branchCodeParameter = branchCode != null ?
                new ObjectParameter("branchCode", branchCode) :
                new ObjectParameter("branchCode", typeof(string));
    
            var isDeletedParameter = isDeleted.HasValue ?
                new ObjectParameter("IsDeleted", isDeleted) :
                new ObjectParameter("IsDeleted", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ManageMenuDetails", idParameter, menuCodeParameter, menuTitleParameter, statusParameter, ratingsParameter, remarksParameter, menuCategoryIdParameter, branchCodeParameter, isDeletedParameter);
        }
    
        public virtual int sp_Branch(string branchCode, string branchName, string town)
        {
            var branchCodeParameter = branchCode != null ?
                new ObjectParameter("branchCode", branchCode) :
                new ObjectParameter("branchCode", typeof(string));
    
            var branchNameParameter = branchName != null ?
                new ObjectParameter("branchName", branchName) :
                new ObjectParameter("branchName", typeof(string));
    
            var townParameter = town != null ?
                new ObjectParameter("town", town) :
                new ObjectParameter("town", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Branch", branchCodeParameter, branchNameParameter, townParameter);
        }
    
        public virtual int sp_CustomerAttributes(string customerAttribute, string customerValue, Nullable<int> customerId)
        {
            var customerAttributeParameter = customerAttribute != null ?
                new ObjectParameter("customerAttribute", customerAttribute) :
                new ObjectParameter("customerAttribute", typeof(string));
    
            var customerValueParameter = customerValue != null ?
                new ObjectParameter("customerValue", customerValue) :
                new ObjectParameter("customerValue", typeof(string));
    
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("customerId", customerId) :
                new ObjectParameter("customerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_CustomerAttributes", customerAttributeParameter, customerValueParameter, customerIdParameter);
        }
    
        public virtual int sp_Customers(Nullable<int> id, string customerID, string remarks, Nullable<short> status)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var customerIDParameter = customerID != null ?
                new ObjectParameter("customerID", customerID) :
                new ObjectParameter("customerID", typeof(string));
    
            var remarksParameter = remarks != null ?
                new ObjectParameter("remarks", remarks) :
                new ObjectParameter("remarks", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Customers", idParameter, customerIDParameter, remarksParameter, statusParameter);
        }
    
        public virtual int sp_menuCategories(string categoryId, string categoryName, Nullable<short> isMain, string parentCategory, Nullable<int> seq_no)
        {
            var categoryIdParameter = categoryId != null ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(string));
    
            var categoryNameParameter = categoryName != null ?
                new ObjectParameter("categoryName", categoryName) :
                new ObjectParameter("categoryName", typeof(string));
    
            var isMainParameter = isMain.HasValue ?
                new ObjectParameter("isMain", isMain) :
                new ObjectParameter("isMain", typeof(short));
    
            var parentCategoryParameter = parentCategory != null ?
                new ObjectParameter("parentCategory", parentCategory) :
                new ObjectParameter("parentCategory", typeof(string));
    
            var seq_noParameter = seq_no.HasValue ?
                new ObjectParameter("seq_no", seq_no) :
                new ObjectParameter("seq_no", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_menuCategories", categoryIdParameter, categoryNameParameter, isMainParameter, parentCategoryParameter, seq_noParameter);
        }
    }
}