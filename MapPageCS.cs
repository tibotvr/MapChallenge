using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MapAppChallene
{
    class MapPageCS : ContentPage
    {
        public MapPageCS()
        {
            var customMap = new CustomMap
            {
                MapType = MapType.Street,
                WidthRequest = App.ScreenWidth,
                HeightRequest = App.ScreenHeight
            };
            var pinDUniv = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(48.625890, 2.439853),
                Label = "IBGBI Evry",
                Address = "23 Boulevard de France, 91037 Évry",
                Id = "Université d'Evry",
                Url = "site web de de l'univ"
            };

            var pinDNsa = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(39.109171, -76.771268),
                Label = "National Securtiy Agency",
                Address = "9800 Savage Rd #6623, Fort Meade, MD 20755, USA",
                Id = "NSA ",
                Url = "site web de l'NSA"
            };

            customMap.CustomPins = new List<CustomPin> { pinDUniv };
            customMap.Pins.Add(pinDUniv);
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(48.625890, 2.439853), Distance.FromMiles(1.0)));

            customMap.CustomPins = new List<CustomPin> { pinDNsa };
            customMap.Pins.Add(pinDNsa);
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(39.109171, -76.771268), Distance.FromMiles(1.0)));


            Content = customMap;
        }
    }
}
