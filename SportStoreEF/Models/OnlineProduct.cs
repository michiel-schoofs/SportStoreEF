namespace SportsStore.Models
{
    public class OnlineProduct : Product
    {
        public string ThumbNail { get; set; }

        protected OnlineProduct()
        {

        }
        public OnlineProduct(string name, decimal price, string thumbnail, string description = null) : base(name, price, description)
        {
            ThumbNail = thumbnail;
        }
    }

}