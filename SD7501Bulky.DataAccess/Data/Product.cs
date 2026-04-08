namespace BulkyWeb.Data
{
    internal class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public int ListPrice { get; set; }
        public int Price { get; set; }
        public int Price50 { get; set; }
        public int Price100 { get; set; }
    }
}