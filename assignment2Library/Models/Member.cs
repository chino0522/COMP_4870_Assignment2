using System.ComponentModel.DataAnnotations;

namespace assignment2Library.Models;

public class Member
{
    [Key]
    public int MemberId { get; set; }

    [Required]
    public string? FirstName { get; set; }

    [Required]
    public string? LastName { get; set; }

    [EmailAddress]
    [Required]
    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public DateTime? Created { get; set; } = DateTime.Now;

    public DateTime? Modified { get; set; } = DateTime.Now;

    public string? CreatedBy { get; set; } = "System";

    public string? ModifiedBy { get; set; } = "System";
}
