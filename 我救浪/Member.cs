//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 我救浪
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            this.Member_Comment = new HashSet<Member_Comment>();
            this.Orders = new HashSet<Order>();
            this.Products = new HashSet<Product>();
        }
    
        public int MemberID { get; set; }
        public string MemberPhone { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<int> CityID { get; set; }
        public Nullable<System.DateTime> BirthdayDate { get; set; }
        public string Email { get; set; }
    
        public virtual City City { get; set; }
        public virtual Member_Wish Member_Wish { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Member_Comment> Member_Comment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
