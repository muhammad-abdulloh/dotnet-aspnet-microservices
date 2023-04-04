using System;

namespace Catalog.API
{
    public class WeatherForecast
    {
        /// <summary>
        /// datetime
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        ///  temperatur
        ///  davay bro
        /// </summary>

        public int TemperatureC { get; set; }

        /// <summary>
        /// faradey
        /// </summary>

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>
        /// xulosa desayam bo'lo'ras kerak
        /// </summary>

        public string Summary { get; set; }
    }
}
