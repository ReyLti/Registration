//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Registration.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Employee()
        {
            this.Order = new HashSet<Order>();
            this.Order1 = new HashSet<Order>();
            this.Order2 = new HashSet<Order>();
        }
    
        public int ID_E { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Surename { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public int JobTitle { get; set; }
        public int Gender { get; set; }
        public Nullable<long> INN { get; set; }
    
        public virtual Gender Gender1 { get; set; }
        public virtual JobTitle JobTitle1 { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Order> Order1 { get; set; }
        public virtual ICollection<Order> Order2 { get; set; }
    }
}
