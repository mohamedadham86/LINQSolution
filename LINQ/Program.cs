//using LINQ.DataSources;
//using System.Linq;
//namespace LINQ
//{
//	internal class Program
//	{
//		static void Main(string[] args)
//		{

//			//Q1
//			var Products = Source.ProductList;

//			Console.WriteLine("Question 1: Seafood Products");

//			var result1 = Products
//				.Where(p => p.Category == "Seafood");

//			foreach (var product in result1)
//			{
//				Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
//			}


//			//Q2
//			var result2 = Products
//	       .Select(p => p.ProductName);

//			foreach (var name in result2)
//			{
//				Console.WriteLine(name);
//			}


//			//Q3
//			var result3 = Products
//	.OrderBy(p => p.UnitPrice);

//			foreach (var product in result3)
//			{
//				Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
//			}



//			//Q4
//			var result4 = Products
//	.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

//			foreach (var product in result4)
//			{
//				Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
//			}

//			//Q5

//			var result5 = Products
//				.Where(p => p.UnitsInStock > 0 &&
//							p.Category == "Spices & Condiments");

//			foreach (var product in result5)
//			{
//				Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
//			}

//			//Q6
//			var result6 = Source.ProductList
//	.Select(p => new
//	{
//		Name = p.ProductName,
//		Price = p.UnitPrice,
//		StockStatus = p.UnitsInStock > 0
//			? "Available"
//			: "Out of Stock"
//	});

//			foreach (var product in result6)
//			{
//				Console.WriteLine(
//					$"{product.Name} - {product.Price} - {product.StockStatus}");
//			}

//			//Q7
//			var result7 = Source.ProductList
//	.Select((p, index) => new
//	{
//		Position = index + 1,
//		Name = p.ProductName
//	});

//			foreach (var product in result7)
//			{
//				Console.WriteLine($"{product.Position}. {product.Name}");
//			}

//			//Q8
//			var result8 = Source.ProductList
//	.OrderBy(p => p.Category)
//	.ThenByDescending(p => p.UnitPrice);

//			foreach (var product in result8)
//			{
//				Console.WriteLine(
//					$"{product.Category} - {product.ProductName} - {product.UnitPrice}");
//			}

//			//Q9
//			var result9 = Source.ProductList
//	.Where(p => p.Category == "Beverages")
//	.OrderByDescending(p => p.UnitsInStock);

//			foreach (var product in result9)
//			{
//				Console.WriteLine(
//					$"{product.ProductName} - Stock: {product.UnitsInStock}");
//			}

			
		

//			//Q11
//			var result11 = Source.ProductList
//	.Select((p, index) => new
//	{
//		Position = index + 1,
//		p.ProductName
//	});

//			foreach (var product in result11)
//			{
//				Console.WriteLine($"{product.Position}. {product.ProductName}");
//			}

//			//Q12
//			string[] Arr =
//{
//	"aPPLE", "AbAcUs", "bRaNcH",
//	"BlUeBeRrY", "ClOvEr", "cHeRry"
//};

//			var result12 = Arr
//				.OrderBy(word => word.Length)
//				.ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

//			foreach (var word in result12)
//			{
//				Console.WriteLine(word);
//			}

//			//Q13
//			var result13 = Arr
//	.Where(word => word.Length > 1 && word[1] == 'i')
//	.Reverse();

//			foreach (var word in result13)
//			{
//				Console.WriteLine(word);
//			}








//		}
//	}
//}
