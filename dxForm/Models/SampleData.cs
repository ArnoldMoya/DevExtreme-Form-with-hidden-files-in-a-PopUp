namespace dxForm.Models
{
    public class SampleData
    {
        public static List<Order> Orders = new List<Order>()
        {
            new Order() {
                ID = 1,
                Name = "name 1",
                Price = 2
            },
            new Order() {
                ID = 2,
                Name = "name 2",
                Price = 21
            },
            new Order() {
                ID = 3,
                Name = "name 3",
                Price = 32
            }
        };
    }
}
