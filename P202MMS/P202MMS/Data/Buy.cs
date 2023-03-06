using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P202MMS.Data
{
    public class Buy
    {
        #region propiedades
        public int Id { get; set; }
        public int Folio { get; set; }
        public int ProviderId { get; set; }
        public DateTime BuyDate { get; set; }

        #endregion
    }
}
