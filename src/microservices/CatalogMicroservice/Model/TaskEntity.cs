using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogMicroservice.Model
{
    public class TaskEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string User { get; set; }
        public DateTime dtStart { get; set; }
        public DateTime dtScheduling { get; set; }
        public DateTime dtEnd { get; set; }
    }
}
