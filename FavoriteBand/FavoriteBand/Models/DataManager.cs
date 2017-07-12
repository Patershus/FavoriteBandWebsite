using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FavoriteBand.Models
{
    public static class DataManager
    {
        static List<Band> bands = new List<Band>
        {
            new Band{Id=1, Name="Queen", Description="Queen är en brittisk rockgrupp som bildades 1970.",
                AlbumList =  new List<string> { "Queen", "Queen2", "Sheer Heart Attack", "A Night at the Opera" } 
            },
            new Band{Id=2, Name="Oasis", Description="Oasis var ett brittiskt rockband, bildat 1991.",
                AlbumList =  new List<string> { "Definitely Maybe", "(What's the Story) Morning Glory?", "Be Here Now", "Standing on the Shoulder of Giants" }
            },
            new Band{Id=3, Name="The Strokes", Description="The Strokes är ett amerikanskt rockband från New York bildat 1999.",
                            AlbumList =  new List<string> { "Is this It", "Room on Fire", "First Impressions of Earth", "Angles" }},


        };

        public static Band GetBandById(int id)
        {
            return bands[id-1];
        }

        public static Band[] GetAllBands()
        {
            return bands.ToArray();
        }
    }
}
