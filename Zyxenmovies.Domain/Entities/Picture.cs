using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Zyxenmovies.Domain.Entities
{
    public class Picture
    {
              public int idPicture { get; set; }

        public string titlePicture { get; set; }

        public string directorPicture { get; set; }

        public string generoPicture { get; set; }

        public int puntuacionMovie { get; set; }

        public int ratingPicture { get; set; }

        public int publicacionPicture { get; set; }
    }
}