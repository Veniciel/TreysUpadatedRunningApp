namespace TreysUpadatedRunningApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Runner_Log
    {
        public int Runner_LogId { get; set; }

        [Required]
        [StringLength(100)]
        public string Runner_Name { get; set; }

        [Required]
        public string Run_Description { get; set; }

        public string Miles_Ran { get; set; }

        public string Total_Distance { get; set; }

        public string Pushup_Count { get; set; }

        public string Start_Date { get; set; }

        public string Total_Time { get; set; }

        public string Pullup_Count { get; set; }

        public string Total_Count { get; set; }
    }
}
