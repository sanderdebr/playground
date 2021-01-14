using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        private string _productName;
        public string ProductName
        {
            get => _productName.InsertSpaces();
            set => _productName = value;
        }

        public override string ToString() => ProductName;

        public string Log() => $"{ProductId}: {_productName} Detail: {ProductDescription} Status: {EntityState.ToString()}";

        /// <summary>
        /// Validates the product
        /// </summary>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
