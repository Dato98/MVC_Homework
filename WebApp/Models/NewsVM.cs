using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public static class NewsVM
    {
        public static List<News> data = new List<News>()
        {
            new News()
            {
                ID = 1,
                Title = "Title1",
                TitleGeo = "სათაური1",
                Description = "adgia sad jaisd asdoa kasd gjlasd kasld ",
                DesctiptionGeo = "ასდ კჯასჯლდკ აჯსდ ასლდჯ ასდ ასდლ ა",
                Tumb = "1.png",
                Slag = "dsada-dds-asdas-dsadd-fdd-dffda"
            },
            new News()
            {
                ID = 2,
                Title = "Title2",
                TitleGeo = "სათაური2",
                Description = "adgia sad jaisd asdoa kasd gjlasd kasld ",
                DesctiptionGeo = "ფდგფდ სდდდ ბვცცც ასლდჯ ასდ ასდლ ა",
                Tumb = "1.png",
                Slag = "ghbb-rr-wfd-kjhj-ghj-dffda"
            },
            new News()
            {
                ID = 3,
                Title = "Title3",
                TitleGeo = "სათაური3",
                Description = "adgia sad jaisd asdoa kasd gjlasd kasld ",
                DesctiptionGeo = "ასდ კჯასჯლდკ აჯსდ ასლდჯ ასდ ასდლ ა",
                Tumb = "1.png",
                Slag = "bvb-jhhfg-gggg-dsadd-fdd-dffda"
            }
        };
    }
}
