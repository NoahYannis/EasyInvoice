using System.ComponentModel.DataAnnotations;

namespace EasyInvoice;

public enum BookingType
{
    [Display(Name = "Halbpension")]
    HalfBoard,

    [Display(Name = "Vollpension")]
    FullBoard,

    [Display(Name = "Spezialangebot")]
    SpecialOffer
}
