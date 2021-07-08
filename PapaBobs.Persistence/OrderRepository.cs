using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Persistence
{
	public class OrderRepository
	{
		public static void CreateNewOrder()
		{
			var db = new PapaBobsDbEntities();

			var order = new Order();
			order.OrderId = Guid.NewGuid();
			order.PizzaSize = DTO.Enums.CrustType.Thick;
			order.CrustSize = DTO.Enums.CrustType.Thick;
			order.Onions = true;
			order.TotalPrize = 16.50M;
			order.CustomerName = "Test";
			order.CustomerAddress = "TestAdress";
			order.CustomerZip = "TestZip";
			order.CustomerPhone = "TestPhone";
			order.PaymentMethod = DTO.Enums.PaymentType.Credit;

			db.Orders.Add(order);
			db.SaveChanges();
		}
	}
}
