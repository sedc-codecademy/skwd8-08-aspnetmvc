using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SEDC.PizzaApp.Domain.Models
{
    public class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string FeedbackMessage { get; set; }
        public double Rating { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
