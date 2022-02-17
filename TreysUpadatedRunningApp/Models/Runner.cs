namespace TreysUpadatedRunningApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Runner")]
    public partial class Runner
    {
        [Key]
        public string UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(256)]
        public string Email { get; set; }
    }
}
