namespace enterprise_order_management.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public OrderStatus Status { get; set; }

        public required IEnumerable<Item> Items { get; set; }

        public required ShippingMethod ShippingMethod { get; set; }

        public required string ShippingAddress { get; set; }

        public required PaymentMethod PaymentMethod { get; set; }
    }

    public enum OrderStatus
    {
        created,
        paid,
        shipped,
        delivered,
        canceled
    }

    public enum ShippingMethod
    {
        normal,
        express
    }

    public enum PaymentMethod
    {
        credit,
        debit
    }
}
