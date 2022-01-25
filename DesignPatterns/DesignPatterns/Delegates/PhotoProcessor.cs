using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Delegates
{
    public class PhotoProcessor
    {
        public PhotoProcessor()
        {
            Process("");
        }
        public void Process(string path)
        {
            var photo = Photo.Load(path);
            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.ApplyResize(photo);

            photo.Save();

        }
    }
}
