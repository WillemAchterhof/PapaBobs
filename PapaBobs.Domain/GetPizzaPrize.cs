using PapaBobs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Domain
{
	public class GetPizzaPrize
	{
		public static decimal CalculateNewPrize(OrderDTO dto)
		{
			decimal totalPrice = 0;

			totalPrice += GetPizzaSize(dto);
			totalPrice += GetCrustPrize(dto);
			totalPrice += GetToppingPrize(dto);

			return totalPrice;
		}
		private static decimal GetPizzaSize(OrderDTO dto)
		{
			switch (dto.PizzaSize)
			{
				case DTO.Enums.SizeType.Small:
					return 12;
				case DTO.Enums.SizeType.Medium:
					return 14;
				case DTO.Enums.SizeType.Large:
					return 16;
				default:
					return 0;
			}
		}
		private static decimal GetCrustPrize(OrderDTO dto)
		{
			switch (dto.CrustSize)
			{
				case DTO.Enums.CrustType.Thin:
					return -2;
				case DTO.Enums.CrustType.Regular:
					return 0;
				case DTO.Enums.CrustType.Thick:
					return 2;
				default:
					return 0;
			}
		}
		private static decimal GetToppingPrize(OrderDTO dto)
		{
			decimal toppingPrize = 0.0M;

			toppingPrize += (dto.Sausages) ? 2 : 0;
			toppingPrize += (dto.Pepperoni) ? 1.5M : 0;
			toppingPrize += (dto.Onions) ? 1 : 0;
			toppingPrize += (dto.GreenPeppers) ? 1 : 0;

			return toppingPrize;
		}

	}
}
