using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class UserModel
    {
        int id;
        string firstName;
        string lastName;
        string password;
        string email;

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

        [Required]
        [StringLength(255)]
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        
            set
            {
                this.lastName = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
        
            set
            {
                this.password = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
        
            set
            {
                this.email = value;
            }
        }
    }
}