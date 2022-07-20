using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatihCdCenter.Model
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MovieSummary { get; set; }
        public string MovieDuration { get; set; }
        public bool IsTVSeries { get; set; }
        public string BannerPatch { get; set; }
    }
}
