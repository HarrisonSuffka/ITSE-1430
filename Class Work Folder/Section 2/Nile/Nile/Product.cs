﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
    /// <summary>Represents A Product.</summary>
    /// <remarks>This will represent a product with other stuff.</remarks>
    public class Product
    {
        public readonly Product None = new Product();

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

        public const decimal DiscontinuedDiscount = 0.10M;

        /// <summary> Gets the discounted price if item is discontinued </summary>
        public decimal DiscountedPrice
        {
            get
            {
                //if (this.IsDiscontinued)
                if (IsDiscontinued)
                    return Price * DiscontinuedDiscount;

                return Price;
            }
        }

        private string _name;
        private string _description;


        public int ICanOnlySetIt { get; private set; }
        public int ICanOnlySetIt2 { get; }

        private readonly double _someValueICanNotChange = 10;

    }
}
