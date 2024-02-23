using System.ComponentModel.DataAnnotations;

namespace ImagZadanie.Models
{
    public record Customer([property: Key] Guid Guid, string Name, string Address, string Nip) : ICustomer;
}
