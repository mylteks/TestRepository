//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XocTuHr
{
    using System;
    using System.Collections.Generic;
    
    public partial class pub_info
    {
        public string pub_id { get; set; }
        public byte[] logo { get; set; }
        public string pr_info { get; set; }
    
        public virtual publishers publishers { get; set; }
    }
}
