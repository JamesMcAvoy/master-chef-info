namespace master_chef_info_cuisine.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class recipes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public recipes()
        {
            list = new HashSet<list>();
        }

        public int id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string description { get; set; }

        public int preparation_time { get; set; }

        public int cooking_time { get; set; }

        public int sleeping_time { get; set; }

        [StringLength(1)]
        public string type { get; set; }

        public int stock { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<list> list { get; set; }
    }
}
