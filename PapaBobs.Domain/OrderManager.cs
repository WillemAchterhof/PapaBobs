using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Domain
{
	public class OrderManager
	{
		public static void CreateNewOrder(DTO.OrderDTO dto)
		{
			if (dto.CustomerName.Length == 0)
			{ throw new Exception("Please, fill in your name!"); }
			else if (dto.CustomerAddress.Length == 0)
			{ throw new Exception("We cannot deliver your pizza!<br />Address is missing!"); }
			else if (dto.CustomerZip.Length == 0)
			{ throw new Exception("We cannot deliver your pizza with out a correct zip!"); }
			else if (dto.CustomerPhone.Length == 0)
			{ throw new Exception("We need your phone to contact  you when we have arrived, or when there are unforseen curcomstances!"); }
			else
			{ Persistence.OrderRepository.CreateNewOrder(dto); }
		}
		public static List<DTO.OrderDTO> GetOpenOrders()
		{
			return Persistence.OrderRepository.GetOpenOrders();
		}
	}
}
