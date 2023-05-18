
namespace Hometask5
{
    internal class Icebox
    {
        public List<(string Name, decimal Quantity)> IceCreamList { get; set; }

        public string SortOfIceCream { get; set; }

        public decimal AmountofIceCream { get; set; }

        public decimal RemainingIceCream
        {
            get
            {
                var resultingAmount = 0.0m;
                resultingAmount = IceCreamList.Sum(ic => ic.Quantity);
                return resultingAmount;
            }   
        }

        public decimal FullnessofIceCream 
        {
            get
            {
               return RemainingIceCream / AmountofIceCream * 100;
            }
        }

        public Icebox(string sort, decimal amount)
        {
            SortOfIceCream = sort;
            AmountofIceCream = amount;
            InitProductList();
        }

        private void InitProductList()
        {
            IceCreamList = new List<(string, decimal)>();
        }

        public void IceCreamforSale(string product, decimal quantitykg)
        {
            var productItem = (product, quantitykg);
            IceCreamList.Add(productItem);
        }

        public void TakeIceCreamOut(string product, decimal quantitykg)
        {
            //var productItem = (product, quantitykg);
            //IceCreamList.Remove(productItem);

            var soldIceCream = IceCreamList.First(IceCream => IceCream.Name == product);
            if (soldIceCream.Quantity < quantitykg)
            {
               throw new ArgumentOutOfRangeException(nameof(quantitykg), $"The {soldIceCream.Name} has less ice cream than {soldIceCream.Quantity}");
            }
            soldIceCream.Quantity -= quantitykg;
        }
      

        public void PrintBagsContents()
        {
            Console.WriteLine($"{SortOfIceCream}'s Icebox has:");
            foreach(var item in IceCreamList)
            {
                Console.WriteLine($" {item.Name} - {item.Quantity}kg");
            }
        }
    }
    
}
