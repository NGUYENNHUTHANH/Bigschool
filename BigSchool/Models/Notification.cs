using System;
using System.ComponentModel.DataAnnotations;

namespace BigSchool.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public Course Course { get; set; }
        public NotificationType Type { get; set; }
    }
}