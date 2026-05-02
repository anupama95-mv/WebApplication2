namespace WebApplication2.Models
{
    public class DataModelsClass
    {
    }
    public class GetProductPageFourDataIP
    {
        public int? Id { get; set; }
    }
    public class SaveProductPageFourDataIP
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? Price { get; set; }
    }
    public class GetProductPageFourDataOP {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

    }
}
