using StarCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCinema.Repo
{
    public class Repo_CovertPhoto
    {
        public List<ImagesforCover> GetAll() {
            return new List<ImagesforCover>
            { 
                       new ImagesforCover
                       {
                         FilePath1 = "../../Images/Cover Images/stargif.gif",
                         FilePath2 = "../../Images/CMS.png",
                       },
            };
        }
    }
}
