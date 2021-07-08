using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.DTO
{
    public class OrderDTO
    {
        public Guid OrderId { get; set; }
        public Enums.SizeType PizzaSize { get; set; }
        public Enums.CrustType CrustSize { get; set; }
        public bool Sausages { get; set; }
        public bool Pepperoni { get; set; }
        public bool Onions { get; set; }
        public bool GreenPeppers { get; set; }
        public decimal TotalPrize { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerZip { get; set; }
        public string CustomerPhone { get; set; }
        public Enums.PaymentType PaymentMethod { get; set; }
        public bool Completed { get; set; }
    }
}
