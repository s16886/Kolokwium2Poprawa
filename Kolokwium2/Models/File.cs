using System;
using System.Collections.Generic;

#nullable disable

namespace Kolokwium2.Models
{
    public partial class File
    {
        public int FileId { get; set; }
        public int TeamId { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public int FileSize { get; set; }

        public virtual Team Team { get; set; }
    }
}
