using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
    /// <summary>Represents A Product.</summary>
    /// <remarks>This will represent a product with other stuff.</remarks>
    public class Product : IValidatableObject
    {

       // public readonly Product None = new Product();

        public int Id { get; set; }

        /// <summary>Gets or sets the name</summary>
        /// <value> Never return null.</value>
        public string Name
        {
            //string get_Name()
            get { return _name; }
            //void set_name (string value )
            set {_name = value; }
        }

        /// <summary>Gets or sets the description</summary>
        public string Description
        {
            get  { return _description ?? ""; }
            set  { _description = value?.Trim(); }
        }


        /// <summary>Gets or sets the price</summary>
        public decimal Price { get; set; } = 0;
        //public decimal Price
        //{
        //    get { return _price; }
        //    set { _price = value; }
        //}

        /// <summary>Determines if discontinued</summary>
        public bool IsDiscontinued { get; set; }
        //{
        //    get { return _isDiscontinued; }
        //    set { _isDiscontinued = value; }
        //}

        public const decimal DiscontinuedDiscountRate = 0.10M;

        /// <summary> Gets the discounted price if item is discontinued </summary>
        public decimal DiscountedPrice
        {
            get
            {
                //if (this.IsDiscontinued)
                if (IsDiscontinued)
                    return Price * DiscontinuedDiscountRate;

                return Price;
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public int[] Sizes
        {
            get 
            {
                var copySizes = new int[_sizes.Length];
                Array.Copy(_sizes, copySizes, _sizes.Length);

                return copySizes;
            }
        }

        public int[] _sizes { get; private set; }

        /// <summary> Validates the object </summary>
        /// <returns> The error message or null </returns>
        //public virtual string Validate()
        //{
        //    //Name cannot be empty
        //    if (String.IsNullOrEmpty(Name))
        //        return "Name cannot be empty.";

        //    //Price > 0
        //    if (Price < 0)
        //        return "Price must be >= 0 ";

        //    return null;
        //}
        //Not Needed because item below was added

        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            //var errors = new List<ValidationResult>();

            //Name cannot be empty
            if (String.IsNullOrEmpty(Name))
                yield return new ValidationResult("Name cannot be empty.", new[] { nameof(Name) });
            //errors.Add(new ValidationResult("Name cannot be empty.", new[] { nameof(Name) }));

            //Price > 0
            if (Price < 0)
                yield return new ValidationResult("Price must be >= 0 ", new[] { nameof(Price) });
            //errors.Add(new ValidationResult("Price must be >= 0 ", new[] { nameof(Price) }));

            //return errors;
        }

        private string _name;
        private string _description;


        //public int ICanOnlySetIt { get; private set; }
        //public int ICanOnlySetIt2 { get; }

        //private readonly double _someValueICanNotChange = 10;

    }
}
