using DesignPatterns.Delegates;
using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyContrast;
            filterHandler += filters.ApplyBrightness;
            processor.Process("", filterHandler);
        }
    }
}
