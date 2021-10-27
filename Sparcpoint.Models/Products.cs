using System;
using System.Collections.Generic;
using System.Text;

namespace Sparcpoint.Models
{
    /// <summary>
    /// Product Class which is based on the Database Product table
    /// </summary>
    public class Products
    {
        public int InstanceId { get; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ProductImageUris { get; set; }

        public string ValidSkus { get; set; }

        public DateTime CreatedTimestamp { get; set; }

        public List<ProductAttributes> Attributes { get; set; }

        public List<Categories> Categories { get; set; }
    }
}
