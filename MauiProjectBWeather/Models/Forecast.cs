using System;
using System.Collections.Generic;
using System.Text;

namespace MauiProjectBWeather.Models
{
    public class Forecast : IEnumerable<Forecast>
    {
        public string City { get; set; }
        public List<ForecastItem> Items { get; set; }

        public Forecast() { }

        public IEnumerator<Forecast> GetEnumerator()
        {
            yield return this;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
