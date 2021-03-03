namespace Backend.Models
{
    public class ProductModel
    {
        int id;
        string name;
        short price;
        string image;

        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public short Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }
    }
}