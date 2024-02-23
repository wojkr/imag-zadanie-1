using ImagZadanie.Models;
using System.Text;

namespace ImagZadanie.Services.Customers
{
    public static class Customers
    {
        public static bool IsNipValid(string nip)
        {
            if (nip.Length != 10) return false;
            if (nip.Any(c => !char.IsDigit(c))) return false;
            return true;
        }
        public static byte[] FormatedCustomerList(List<Customer> Customers)
        {
            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"-----CUSTOMERS DATA @{DateTime.Now.ToString("ddd, d MMM yyyy")}-----");
            foreach (Customer c in Customers)
            {
                resultBuilder.AppendLine();
                resultBuilder.AppendLine($"Name: {c.Name}");
                resultBuilder.AppendLine($"Address: {c.Address}");
                resultBuilder.AppendLine($"NIP: {c.Nip}");
            }
            string result = resultBuilder.ToString();
            return Encoding.UTF8.GetBytes(result);
        }
    }
}
