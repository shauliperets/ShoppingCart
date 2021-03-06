namespace Backend.Models
{
    public class ProductModel
    {
        int id;
        string name;
        string description;
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

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.name = description;
            }
        }

        public short Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public string Image
        {
            get
            {
                return this.image;
            }
            set
            {
                this.image = value;
            }
        }
    }
}