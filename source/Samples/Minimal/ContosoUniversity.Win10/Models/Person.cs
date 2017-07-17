using OnePlat.Mvvm.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public abstract class Person : ModelBase
    {
        private string lastName;
        private string firstMidName;

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName
        {
            get { return this.lastName; }
            set { this.SetProperty<string>(ref this.lastName, value); }
        }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName
        {
            get { return this.firstMidName; }
            set { this.SetProperty<string>(ref this.firstMidName, value); }
        }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
    }
}
