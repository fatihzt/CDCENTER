using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatihCdCenter.Model
{
    public class TVSeries
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TVSeriesSummary { get; set; }
        public string TVSeriesSeason { get; set; }
        public bool IsFinish { get; set; }

    }
}
