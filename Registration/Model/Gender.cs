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
    
    public partial class Gender
    {
        public Gender()
        {
            this.Employee = new HashSet<Employee>();
            this.Client = new HashSet<Client>();
        }
    
        public int ID_G { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<Client> Client { get; set; }
    }
}
