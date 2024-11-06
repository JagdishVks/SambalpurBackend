using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dharmendraPradhan.Models
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string From { get; set; }  // Sender information

        [Required]
        public string Body { get; set; }  // Main message content

        [Required]
        public List<string> Content { get; set; } = new List<string>();  // Array of message parts

        public DateTime Timestamp { get; set; } = DateTime.UtcNow;  // Message timestamp
    }
}
