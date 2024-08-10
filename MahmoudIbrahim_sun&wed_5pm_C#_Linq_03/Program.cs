using static MahmoudIbrahim_sun_wed_5pm_C__Linq_03.ListGenerator;

namespace MahmoudIbrahim_sun_wed_5pm_C__Linq_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Partitioning Operators

            #region Question_1
            //var CustomerOrders = CustomerList.Select(CustomerData => new{ CustomerData.Orders, CustomerData.City}).Where(c => c.City == "Washington").Take(3);

            //foreach (var item in CustomerOrders)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question_2
            //var CustomerOrders = CustomerList.Select(CustomerData => new { CustomerData.Orders, CustomerData.City }).Where(c => c.City == "Washington").Skip(2);

            //foreach (var item in CustomerOrders)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question_3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var subset = numbers.TakeWhile((n, index) => n >= index);
            //foreach (var item in subset)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question_4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var subset = numbers.SkipWhile(n => n % 3 != 0);
            //foreach (var item in subset)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question_5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var subset = numbers.SkipWhile((n, index) => n >= index);
            //foreach (var item in subset)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion
        }
    }
}
