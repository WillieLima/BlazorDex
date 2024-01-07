using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDex.Models
{
    public class Stat
        {
            public int base_stat { get; set; }
            public int effort { get; set; }
            public Stat2 stat { get; set; }
        }
}