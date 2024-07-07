using MongoDb.Dtos.CategoryDtos;

namespace MongoDb.Models
{
    public class ProductWithCategoryListExcelViewModel
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string CategoryId { get; set; }
        public ResultCategoryDto Category { get; set; }
    }
}
