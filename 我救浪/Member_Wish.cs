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
    
    public partial class Member_Wish
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member_Wish()
        {
            this.Member_Wish_Color = new HashSet<Member_Wish_Color>();
        }
    
        public int MemberID { get; set; }
        public Nullable<int> CityID { get; set; }
        public Nullable<decimal> YearCost { get; set; }
        public Nullable<int> Space { get; set; }
        public Nullable<int> SizeID { get; set; }
        public Nullable<int> AgeID { get; set; }
        public Nullable<int> AccompanyTimeWeek { get; set; }
        public Nullable<int> LigationID { get; set; }
        public int SubCategoryID { get; set; }
        public Nullable<int> GenderID { get; set; }
    
        public virtual Age Age { get; set; }
        public virtual City City { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Ligation Ligation { get; set; }
        public virtual Member Member { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Member_Wish_Color> Member_Wish_Color { get; set; }
        public virtual Size Size { get; set; }
        public virtual SubCategory SubCategory { get; set; }
    }
}
