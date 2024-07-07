using MongoDb.Dtos.CustomerDtos;

namespace MongoDb.Models
{
    public class OrderWithCustomerListPdfViewModel
    {
        public string OrderProductName { get; set; }
        public string OrderProductPiece { get; set; }
        public string CustomerId { get; set; }
        public ResultCustomerDto Customer { get; set; }
    }
}
