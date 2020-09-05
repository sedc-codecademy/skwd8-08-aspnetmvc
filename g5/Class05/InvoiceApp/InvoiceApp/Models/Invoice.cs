using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InvoiceApp.Models
{
    public class Invoice
    {
        private static readonly Random Rnd = new Random();
        public int Id { get; set; } = Rnd.Next(1, 100000000);
        [Required(ErrorMessage = "Број е задолжителен податок")]
        public string Number { get; set; }
        [Required(ErrorMessage = "Износ е задолжителен податок")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Невалиден податок")]
        public int? Amount { get; set; }
        [Required(ErrorMessage = "Тип на сметка е задолжителен податок")]
        public InvoiceType? Type { get; set; }
        [Required(ErrorMessage = "Задолжителен податок")]
        [Range(1, 12, ErrorMessage = "Изберете валиден месец")]
        public int? Month { get; set; }
        [Required(ErrorMessage = "Задолжителен податок")]
        [Range(1, 2100, ErrorMessage = "Невалиден податок")]
        public int? Year { get; set; }
        public string Description { get; set; }
        [DisplayName("Date")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CreatedAtFormatted => CreatedAt.ToString("dd.MM.yyyy HH:mm");
        public bool Payed { get; set; }
        [DisplayName("Way of payment")]
        public WayOfPayment WayOfPayment { get; set; }
        [DisplayName("Pay until")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime PaymentDay { get; set; }

        public Invoice()
        {
            WayOfPayment = WayOfPayment.Postponed;
            PaymentDay = DateTime.Now.AddDays(10);
        }

        public Invoice(string number, int amount, InvoiceType type, int month, int year, string description, bool payed,
            WayOfPayment wayOfPayment, DateTime paymentDay)
        {
            Number = number;
            Amount = amount;
            Type = type;
            Month = month;
            Year = year;
            Description = description;
            Payed = payed;
            WayOfPayment = wayOfPayment;
            PaymentDay = paymentDay;
        }
    }
}
