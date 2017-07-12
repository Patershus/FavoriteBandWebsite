using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FavoriteBand.Models
{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> AlbumList { get; set; }
        public string ImgPath { get; set; }





    }
}
