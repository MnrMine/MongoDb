namespace MongoDb.Dtos.OrderDtos
{
    public class CreateOrderDto
    {
        public string? OrderProductName { get; set; }
        public int OrderProductPiece { get; set; }
        public DateTime OrderDate { get; set; }
        public string? CustomerId { get; set; }
        public string? ProductId { get; set; }
    }
}
