using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarsServiceRecords.Models
{
    public abstract class Service
    {
        /// <summary>
        /// Date of the service was made
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Car milaege when the service was made
        /// </summary>
        public int Milaege { get; set; }
    }
}
