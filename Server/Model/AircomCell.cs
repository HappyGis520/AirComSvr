using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetPlan.Model
{
    [Serializable]
     public   class AircomCell
     {
        /// <summary>
        /// 扇区编号
        /// </summary>
        public  int CellID =13777;

        public string Celliid = string.Empty;

        public List<AirComAntennaType>  Antenners = new List<AirComAntennaType>();
     }
}
