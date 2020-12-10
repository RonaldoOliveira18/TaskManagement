using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TasksMicroservice.Model
{
    public class TaskEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string User { get; set; }
        public DateTime? DtStart { get; set; }
        public DateTime? DtScheduling { get; set; }
        public DateTime? DtEnd { get; set; }
    }
}
