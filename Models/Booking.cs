using System.ComponentModel.DataAnnotations;

namespace EasyInvoice.Models;

public class Booking
{
    [Required]
    public BookingType Type { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime StartDate { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [DateGreaterThan("StartDate", ErrorMessage = "Das Enddatum muss mindestens 24h nach dem Startdatum liegen.")]
    public DateTime EndDate { get; set; }

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "Der Preis muss eine positive Ganzzahl sein.")]
    public decimal Price { get; set; }
}


/// <summary>
/// Attribut, das sicherstellt, dass Start- und Enddatum der Buchung mindestens 24h auseinander liegen.
/// </summary>
public class DateGreaterThanAttribute(string _comparisonProperty) : ValidationAttribute
{
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        var currentValue = (DateTime)value!;
        var property = validationContext.ObjectType.GetProperty(_comparisonProperty) ?? throw new ArgumentException("Es wurde kein Datum übergeben.");
        var comparisonValue = (DateTime)property.GetValue(validationContext.ObjectInstance)!;

        if (currentValue <= comparisonValue.AddDays(1))
            return new ValidationResult(ErrorMessage);

        return ValidationResult.Success!;
    }
}
