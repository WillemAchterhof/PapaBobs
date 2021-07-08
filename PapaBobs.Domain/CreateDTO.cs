using PapaBobs.DTO;
using PapaBobs.DTO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Domain
{
	public class CreateDTO
	{
		public static DTO.OrderDTO GetDTO(SizeType pizzaSize, CrustType crustSize, bool sausages, bool pepperoni, bool onions, bool greenPeppers, decimal totalCost, string customerName, string customerAddres, string customerZip, string customerPhone, PaymentType paymentType)
		{
			DTO.OrderDTO orderDTO = new OrderDTO();

			orderDTO.PizzaSize = pizzaSize;
			orderDTO.CrustSize = crustSize;
			orderDTO.Sausages = sausages;
			orderDTO.Pepperoni = pepperoni;
			orderDTO.Onions = onions;
			orderDTO.GreenPeppers = greenPeppers;
			orderDTO.TotalPrize = totalCost;
			orderDTO.CustomerName = customerName;
			orderDTO.CustomerAddress = customerAddres;
			orderDTO.CustomerZip = customerZip;
			orderDTO.CustomerPhone = customerPhone;
			orderDTO.PaymentMethod = paymentType;

			return orderDTO;
		}
	}
}
