
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace Quete_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            String jsonToDeserialize = @"{
            'coord': {
                            'lon': -0.13,
                            'lat': 51.51
                      }
                                         }";

            Coordonnees coordonnees = JsonConvert.DeserializeObject<Coordonnees>(jsonToDeserialize);

            String jsonToDeserialize2 = @" {
            'weather': [
                                {
                'id': 300,
                                     'main': 'Drizzle',
                                     'description': 'light intensity drizzle',
                                     'icon': '09d'
                                },

                                {
                'id': 800,
                                    'main': 'Clear',
                                    'description': 'clear sky',
                                    'icon': '01n'
                                 }
                          ],
}";

            Weather weather = JsonConvert.DeserializeObject<Weather>(jsonToDeserialize2);

            String jsonToDeserialize3 = @" {

                    'base': 'stations'
}";

            BaseMeteo baseMeteo = JsonConvert.DeserializeObject<BaseMeteo>(jsonToDeserialize3);


            String jsonToDeserialize4 = @" {
                'main': {
                            'temp': 280.32,
                            'pressure': 1012,
                            'humidity': 81,
                            'temp_min': 279.15,
                            'temp_max': 281.15
                         }
}";
            MainMeteo mainMeteo = JsonConvert.DeserializeObject<MainMeteo>(jsonToDeserialize4);

            String jsonToDeserialize5 = @" {

                'visibility': 10000
}";
            Visibility visibility = JsonConvert.DeserializeObject<Visibility>(jsonToDeserialize5);

            String jsonToDeserialize6 = @" { 'wind': {
                        'speed': 4.1,
                        'deg': 80
                        }}";
            Wind wind = JsonConvert.DeserializeObject<Wind>(jsonToDeserialize6);

            String jsonToDeserialize7 = @" {'clouds': {
                             'all': 90
                          }}";
            Cloud cloud = JsonConvert.DeserializeObject<Cloud>(jsonToDeserialize7);

            String jsonToDeserialize8 = @" {  'dt': 1485789600}";
            Dt dt = JsonConvert.DeserializeObject<Dt>(jsonToDeserialize8);

            String jsonToDeserialize9 = @" { 'sys': {
                            'type': 1,
                            'id': 5091,
                            'message': 0.0103,
                            'country': 'GB',
                            'sunrise': 1485762037,
                            'sunset': 1485794875
                        }
    }";
            Sys sys = JsonConvert.DeserializeObject<Sys>(jsonToDeserialize9);

            String jsonToDeserialize10 = @" { 'id': 2643743}";
            Id id = JsonConvert.DeserializeObject<Id>(jsonToDeserialize10);

            String jsonToDeserialize11 = @" {'name': 'London'}";
            Name name = JsonConvert.DeserializeObject<Name>(jsonToDeserialize11);

            String jsonToDeserialize12 = @" {'cod' : 200}";
            Cod cod = JsonConvert.DeserializeObject<Cod>(jsonToDeserialize12);
     
        }

    }
}
