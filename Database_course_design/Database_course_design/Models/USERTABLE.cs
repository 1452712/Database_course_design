//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database_course_design.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class USERTABLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USERTABLE()
        {
            this.MESSAGEs = new HashSet<MESSAGE>();
            this.USER_COMMENT_REPOSITORY = new HashSet<USER_COMMENT_REPOSITORY>();
            this.USER_COMMENT_USER = new HashSet<USER_COMMENT_USER>();
            this.USER_COMMENT_USER1 = new HashSet<USER_COMMENT_USER>();
            this.USER_REPOSITORY_LOOKHISTORY = new HashSet<USER_REPOSITORY_LOOKHISTORY>();
            this.USER_REPOSITORY_OPERATION = new HashSet<USER_REPOSITORY_OPERATION>();
            this.USER_REPOSITORY_RELATIONSHIP = new HashSet<USER_REPOSITORY_RELATIONSHIP>();
            this.USERTABLE1 = new HashSet<USERTABLE>();
            this.USERTABLEs = new HashSet<USERTABLE>();
        }
    
        public string USER_ID { get; set; }
        public string PASSWORD { get; set; }
        public string USER_NAME { get; set; }
        public string DEPARTMENT { get; set; }
        public Nullable<int> IDENTITY { get; set; }
        public string EMAIL { get; set; }
        public Nullable<int> GRADE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MESSAGE> MESSAGEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_COMMENT_REPOSITORY> USER_COMMENT_REPOSITORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_COMMENT_USER> USER_COMMENT_USER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_COMMENT_USER> USER_COMMENT_USER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_REPOSITORY_LOOKHISTORY> USER_REPOSITORY_LOOKHISTORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_REPOSITORY_OPERATION> USER_REPOSITORY_OPERATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_REPOSITORY_RELATIONSHIP> USER_REPOSITORY_RELATIONSHIP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USERTABLE> USERTABLE1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USERTABLE> USERTABLEs { get; set; }
    }
}
