using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Persistence
{
	public class OrderRepository
	{
		public static void CreateNewOrder(DTO.OrderDTO dto)
		{
			var db = new PapaBobsDbEntities();

			var order = new Order();
			order.OrderId = Guid.NewGuid();
			order.PizzaSize = dto.PizzaSize;
			order.CrustSize = dto.CrustSize;
			order.Sausages = dto.Sausages;
			order.Pepperoni = dto.Pepperoni;
			order.Onions = dto.Onions;
			order.GreenPeppers = dto.GreenPeppers;
			order.TotalPrize = dto.TotalPrize;
			order.CustomerName = dto.CustomerName;
			order.CustomerAddress = dto.CustomerAddress;
			order.CustomerZip = dto.CustomerZip;
			order.CustomerPhone = dto.CustomerPhone;
			order.PaymentMethod = DTO.Enums.PaymentType.Credit;

			db.Orders.Add(order);
			db.SaveChanges();
		}
	}
}
