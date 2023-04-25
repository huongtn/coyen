using System.Drawing;

namespace DoChoiThongMinh.Models
{
    public class ProductListViewModel
    {
        public List<Product> topStars { get; set; }
        public List<Product> topSells { get; set; }
        public List<Product> news { get; set; }
        public List<Product> rcs { get; set; }
        public List<Product> camps { get; set; }
        public List<Product> others { get; set; }
    }

    public class ProductViewModel
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string  Description { set; get; }

        public int Cost { set; get; }
        public int Discount { set; get; }
        public int Qty { set; get; }
        public int Star { set; get; }
        public string Color { set; get; }
        public string Image { set; get; }
        public string Video { set; get; }
        public ProductViewModel(Product p)
        {
            ID = p.Id;
            Name = p.Name;
            Description = p.Description;
            Cost =(int)p.Cost;
            Discount = (int)p.Discount;
            Image = p.Images;
            Video = p.Video;
            Qty = (int)p.Qty;
            Color = p.Color;
            Star = (int)p.Star;
        }
    }

    public class CartViewModel
    {
        public Product Product { set; get; }
        public int Qty { set; get; }
    }
}
