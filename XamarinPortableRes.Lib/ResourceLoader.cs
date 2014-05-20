using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace XamarinPortableRes.Lib
{
    public static class ResourceLoader
    {
        static internal string[] Names { get; set; }
        static internal Assembly Assembly { get; set; }

        public static System.IO.Stream GetObject(string resourceName)
        {
            if (ResourceLoader.Assembly == null)
            {
                ResourceLoader.Assembly = typeof(ResourceLoader).GetTypeInfo().Assembly;
                ResourceLoader.Names = ResourceLoader.Assembly.GetManifestResourceNames();
            }
            try
            {
                string path = ResourceLoader.Names.First(x => x.EndsWith(resourceName, StringComparison.CurrentCultureIgnoreCase));
                return ResourceLoader.Assembly.GetManifestResourceStream(path);
            }
            catch
            {
                return null;
            }
        }
    }
    /// <summary>
    /// Modify Resources class
    /// etc. XamarinPortableRes.Lib.Resources.MarkBlue.png -> MarkBlue.png
    /// </summary>
    public class Resources
    {
        public static System.IO.Stream MarkBlue
        {
            get { return ResourceLoader.GetObject("MarkBlue.png"); }
        }
        public static System.IO.Stream MarkGreen
        {
            get { return ResourceLoader.GetObject("MarkGreen.png"); }
        }
        public static System.IO.Stream MarkNone
        {
            get { return ResourceLoader.GetObject("MarkNone.png"); }
        }
        public static System.IO.Stream MarkOrange
        {
            get { return ResourceLoader.GetObject("MarkOrange.png"); }
        }
        public static System.IO.Stream MarkPurple
        {
            get { return ResourceLoader.GetObject("MarkPurple.png"); }
        }
        public static System.IO.Stream MarkRed
        {
            get { return ResourceLoader.GetObject("MarkRed.png"); }
        }
    }
}
