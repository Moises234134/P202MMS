using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P202MMS.Data
{
    #region Propiedades
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public int SerialNumber { get; set; }
        #endregion
    }
}
