using System.ComponentModel.DataAnnotations;
using APSIM.RegistrationV2.Components.Classes.Interfaces;

namespace APSIM.RegistrationV2.Components.Classes.Registration;

/// <summary>Class to hold the details of a general use registration application.</summary>
public class GeneralUseRegistration: IRegistration
{
    /// <summary>The email address of the contact person for this application. This is a required field and must be in a valid email format.</summary>
    [Required]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    public string? ContactEmail { get; set; }

    /// <summary>The name of the contact person for this application. This is a required field.</summary>
    [Required(ErrorMessage = "Please enter the contact person's name.")]
    public string? ContactName { get; set; }

    public LicenceStatus LicenceStatus { get; set; } = LicenceStatus.None;

    public DateTime ApplicationDate { get; set; } = DateTime.Now;

    public GeneralUseRegistration(){}

    public override string ToString()
    {
        return $"Contact Email: {ContactEmail}\nContact Name: {ContactName}\nLicence Status: {LicenceStatus}\n Application Date: {ApplicationDate}";
    }

}
