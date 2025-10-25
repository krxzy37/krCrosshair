using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.Json;

namespace krCrosshair
{
    internal class CrosshairProfile
    {
        public required string Name { get; set; }
        public required string FilePath { get; set; }
        public int Size { get; set; }
    }
}
