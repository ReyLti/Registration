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
    
    public partial class PersonalComputer
    {
        public PersonalComputer()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int ID_PC { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
    
        public virtual ICollection<Order> Order { get; set; }
        public virtual Type Type1 { get; set; }
    }
}
