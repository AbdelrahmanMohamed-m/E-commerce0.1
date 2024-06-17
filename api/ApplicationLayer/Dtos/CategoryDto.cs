namespace api.ApplicationLayer.Dtos
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = "";
        public List<ProductCategoryDto> Products { get; set; } = [];

    }
}