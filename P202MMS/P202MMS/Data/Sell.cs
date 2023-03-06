using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P202MMS.Data
{
    public class Sell
    {
        #region propiedades
        public int Id { get; set; }
        public int Folio { get; set; }
        public int customerId { get; set; }
        public DateTime SellDate { get; set; }
        
        #endregion

    }
}
