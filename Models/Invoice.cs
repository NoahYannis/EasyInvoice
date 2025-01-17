using System.ComponentModel.DataAnnotations;

namespace EasyInvoice.Models;

public class Invoice
{
    [Required]
    [EnumDataType(typeof(BookingType), ErrorMessage = "Der Typ muss ein gültiger Wert sein.")]
    public BookingType Type { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime TimeSpan { get; set; }

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "Der Preis muss eine positive Ganzzahl sein.")]
    public decimal Price { get; set; }
}
