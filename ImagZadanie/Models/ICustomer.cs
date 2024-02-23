namespace ImagZadanie.Models
{
    public interface ICustomer
    {
        Guid Guid { get; }
        string Name { get; }
        string Address { get; }
        string Nip { get; }
    }
}
