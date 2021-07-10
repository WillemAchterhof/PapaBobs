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
		public static List<DTO.OrderDTO> GetOpenOrders()
		{
			PapaBobsDbEntities db = new PapaBobsDbEntities();

			var openOrders = db.Orders.Where(p => p.Completed == false).ToList();
			var openOrdersDTO = new List<DTO.OrderDTO>() ;

			foreach (var dbOpenOrder in openOrders)
			{
				var OpenOrderDTO = new DTO.OrderDTO();

				OpenOrderDTO.OrderId = dbOpenOrder.OrderId;
				OpenOrderDTO.PizzaSize = dbOpenOrder.PizzaSize;
				OpenOrderDTO.CrustSize = dbOpenOrder.CrustSize;
				OpenOrderDTO.Sausages = dbOpenOrder.Sausages;
				OpenOrderDTO.Pepperoni = dbOpenOrder.Pepperoni;
				OpenOrderDTO.Onions = dbOpenOrder.Onions;
				OpenOrderDTO.GreenPeppers = dbOpenOrder.GreenPeppers;
				OpenOrderDTO.TotalPrize = dbOpenOrder.TotalPrize;
				OpenOrderDTO.CustomerName = dbOpenOrder.CustomerName;
				OpenOrderDTO.CustomerAddress = dbOpenOrder.CustomerAddress;
				OpenOrderDTO.CustomerZip = dbOpenOrder.CustomerZip;
				OpenOrderDTO.CustomerPhone = dbOpenOrder.CustomerPhone;
				OpenOrderDTO.PaymentMethod = dbOpenOrder.PaymentMethod;
				OpenOrderDTO.Completed = dbOpenOrder.Completed;

				openOrdersDTO.Add(OpenOrderDTO);
			}

			return openOrdersDTO;
		}

		public static void CompletedOrder(Guid orderID)
		{
			var db = new PapaBobsDbEntities();
			var order = db.Orders.FirstOrDefault(p => p.OrderId == orderID);
			order.Completed = true;
			db.SaveChanges();
		}
	}
}
