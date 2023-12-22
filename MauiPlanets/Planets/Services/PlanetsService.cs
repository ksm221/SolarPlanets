using Planets.Models;

namespace Planets.Services
{

    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. It is a terrestrial planet with a heavily cratered surface due to overlapping impact events. These features are well preserved since the planet has no geological activity and an extremely tenuous atmosphere called an exosphere. Despite being the smallest planet in the Solar System with a mean diameter of 4,880 km (3,030 mi), 38% of that of Earth, Mercury is dense enough to have roughly the same surface gravity as Mars. Mercury has a dynamic magnetic field with a strength about 1% of that of Earth's and has no natural satellites.",
                //AccentColorStart = Color.
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/pia19422-mercury.jpg"
                }
            },

            new()
            {
                Name = "Venus",
                Subtitle = "Brightest star",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun." +
                "It is a rocky planet with the densest atmosphere of all the rocky bodies in the Solar System, and the only one with a mass and size that is close to that of its orbital neighbour Earth."+
                "Orbiting inferiorly (inside of Earth's orbit), it appears in Earth's sky always close to the Sun, as either a \"morning star\" or an \"evening star\".Venus is the second planet from the Sun." + 
                "It is a rocky planet with the densest atmosphere of all the rocky bodies in the Solar System, and the only one with a mass and size that is close to that of its orbital neighbour Earth." + 
                "Orbiting inferiorly (inside of Earth's orbit), it appears in Earth's sky always close to the Sun, as either a \"morning star\" or an \"evening star\".",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/b/b2/Venus_2_Approach_Image.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Venus_globe.jpg/1024px-Venus_globe.jpg",
                    "https://dnd2oi6izkvoi.cloudfront.net/img/iea/7qOYd58Ww3/venus-might-have-oceans-of-water-trapped-inside-its-crust.jpg"
                }
            },

            new()
            {
                Name = "Earth",
                Subtitle = "Our Home",
                HeroImage = "earth.png",
                Description =  "Earth is the third planet from the Sun and the only astronomical object known to harbor life." + 
                 "This is enabled by Earth being a water world, the only one in the Solar System sustaining liquid surface water."+ 
                 "Almost all of Earth's water is contained in its global ocean, covering 70.8% of Earth's crust." + 
                 "The remaining 29.2% of Earth's crust is land, most of which is located in the form of continental landmasses within one hemisphere, Earth's land hemisphere." + 
                 "Most of Earth's land is somewhat humid and covered by vegetation, while large sheets of ice at Earth's polar deserts retain more water than Earth's groundwater, lakes, rivers and atmospheric water combined." + 
                 "Earth's crust consists of slowly moving tectonic plates, which interact to produce mountain ranges, volcanoes, and earthquakes." + 
                 "Earth has a liquid outer core that generates a magnetosphere capable of deflecting most of the destructive solar winds and cosmic radiation.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://images.unsplash.com/photo-1614730321146-b6fa6a46bcb4?q=80&w=1000&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxleHBsb3JlLWZlZWR8MXx8fGVufDB8fHx8fA%3D%3D",
                    "https://akm-img-a-in.tosshub.com/indiatoday/images/story/202303/earth-4439728_960_720-sixteen_nine.jpg?VersionId=kZJbwk_Kd9K36im4Xxd08YrnS87DsQMQ"

                }
            },

            new()
            {
                Name = "Mars",
                Subtitle = "Red planet",
                HeroImage = "mars.png",
                Description = "Mars is the fourth planet and the furthest terrestrial planet from the Sun." + 
                  "The reddish color of its surface is due to finely grained iron(III) oxide dust in the soil, giving it the nickname \"the Red Planet\". " +
                  "Mars's radius is second smallest among the planets in the Solar System at 3,389.5 km (2,106 mi)." +  
                  "The Martian dichotomy is visible on the surface: on average, the terrain on Mars's northern hemisphere is flatter and lower than its southern hemisphere." + 
                  "Mars has a thin atmosphere made primarily of carbon dioxide, and two irregularly shaped natural satellites, Phobos and Deimos.",
                AccentColorStart = Color.FromArgb("#A52A2A"),
                AccentColorEnd = Color.FromArgb("#913831"),
                Images = new()
                {
                    "https://cdn.mos.cms.futurecdn.net/Q4UQ2bWADBXqrRy9H3PcTo.jpg",
                    "https://c02.purpledshub.com/uploads/sites/41/2023/07/mars-thumbnail-fb84d10.jpg",
                    "https://miro.medium.com/v2/resize:fit:1358/1*2n6yiV0A8p8Lyk55gId23Q.jpeg"

                }
            },

            new()
            {
                Name = "Jupiter",
                Subtitle = "God planet",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. It is a gas giant with a mass more than two and a half times that of all the other planets in the Solar System combined, and slightly less than one one-thousandth the mass of the Sun. Jupiter orbits the Sun at a distance of 5.20 AU (778.5 Gm) with an orbital period of 11.86 years. Jupiter is the third brightest natural object in the Earth's night sky after the Moon and Venus, and it has been observed since prehistoric times. It was named after Jupiter, the chief deity of ancient Roman religion.",
                AccentColorStart = Color.FromArgb("#A52A2A"),
                AccentColorEnd = Color.FromArgb("#913831"),
                Images = new()
                {
                    "https://t4.ftcdn.net/jpg/00/04/94/63/360_F_4946384_BOhNRo9oXd0KiN38sWXwIB72Rh8rzcv1.jpg",
                   

                }
            },

            new()
            {
                Name = "Saturn",
                Subtitle = "Ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and the second-largest in the Solar System, after Jupiter."+
                    "It is a gas giant with an average radius of about nine-and-a-half times that of Earth."+
                    "It has only one-eighth the average density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#808080"),
                AccentColorEnd = Color.FromArgb("#778899"),
                Images = new()
                {
                    "https://media.cnn.com/api/v1/images/stellar/prod/230210173346-hubble-saturn-rings-spokes.jpg?c=16x9&q=h_720,w_1280,c_fill",
                    "https://t3.ftcdn.net/jpg/03/41/81/22/360_F_341812269_QJzsDM9n0oN8XgL765xR1jleTdHKRhzi.jpg",
                    "https://stsci-opo.org/STScI-01EVSVE3VNSYF8J7J7AZ4P6NB8.jpg"


                }
            },

            new()
            {
                Name = "Uranus",
                Subtitle = "Coldest planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. It is a gaseous cyan-coloured ice giant." + 
                     "Most of the planet is made of water, ammonia, and methane in a supercritical phase of matter, which in astronomy is called 'ice' or volatiles." + 
                     "The planet's atmosphere has a complex layered cloud structure and has the lowest minimum temperature of 49 K (−224 °C; −371 °F) out of all the Solar System's planets." +
                     "It has a marked axial tilt of 97.8° with a retrograde rotation rate of 17 hours." +
                     "This means that in an 84-Earth-year orbital period around the Sun, its poles get around 42 years of continuous sunlight, followed by 42 years of continuous darkness.",
                AccentColorStart = Color.FromArgb("#808080"),
                AccentColorEnd = Color.FromArgb("#778899"),
                Images = new()
                {
                    "https://www.funkidslive.com/wp-content/uploads/2022/10/yto1u-i1pvi-1024x585.jpg",
                    "https://universemagazine.com/wp-content/uploads/2022/06/4-3.jpg",
                    "https://www.astronomy.com/wp-content/uploads/sites/2/2023/03/Uranussideways.jpg?fit=600%2C394"

                }
            },

            new()
            {
                Name = "Neptune",
                Subtitle = "Roman God",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth and farthest planet from the Sun. It is the fourth-largest planet in the Solar System by diameter, the third-most-massive planet, and the densest giant planet."+ 
                     "It is 17 times the mass of Earth, and slightly more massive than its near-twin Uranus. Neptune is denser and physically smaller than Uranus because its greater mass causes more gravitational compression of its atmosphere."+
                     "Being composed primarily of gases and liquids, it has no well-defined solid surface. The planet orbits the Sun once every 164.8 years at an orbital distance of 30.1 astronomical units (4.5 billion kilometres; 2.8 billion miles)."+
                     "It is named after the Roman god of the sea and has the astronomical symbol ♆, representing Neptune's trident.",
                AccentColorStart = Color.FromArgb("#808080"),
                AccentColorEnd = Color.FromArgb("#778899"),
                Images = new()
                {
                    "https://img.freepik.com/premium-photo/planet-neptune-space-blue-planet-space_868719-83.jpg",
                    "https://img.freepik.com/premium-photo/3d-render-planet-neptune-blue-black-space-background_398034-224.jpg",
                    "https://i.guim.co.uk/img/static/sys-images/Admin/BkFill/Default_image_group/2011/7/8/1310128645424/Neptune-007.jpg?width=465&dpr=1&s=none"

                }
            },

            new()
            {
                Name = "Pluto",
                Subtitle = "Roman god of the underworld.",
                HeroImage = "pluto.png",
                Description = "Pluto is a complex and mysterious world with mountains, valleys, plains, craters, and apparently even glaciers. Discovered in 1930, Pluto was long considered our solar system's ninth planet. But after the discovery that many similar, intriguing worlds inhabit the distant region beyond Neptune known as the Kuiper Belt, icy Pluto was reclassified as a dwarf planet.",
                AccentColorStart = Color.FromArgb("#87CEFA"),
                AccentColorEnd = Color.FromArgb("#6495ED"),
                Images = new()
                {
                    "https://science.nasa.gov/_ipx/animated_true&w_2048&f_webp/https://images-assets.nasa.gov/image/PIA20037/PIA20037~orig.jpg%3Fw=1041%26h=717%26fit=clip%26crop=faces%252Cfocalpoint",
                    "https://smd-cms.nasa.gov/wp-content/uploads/2023/04/137119main2_hst_pluto1_516-jpg.webp?w=2048&format=webp",
                    "https://smd-cms.nasa.gov/wp-content/uploads/2023/04/hubble-discoveries-highlights-pluto-moons-jpg.webp?w=2048&format=webp"


                }
            },
            
            new()
            {
                Name = "Ceres",
                Subtitle = "Roman goddess of corn and harvests",
                HeroImage = "ceres.png",
                Description = "Dwarf planet Ceres is the largest object in the asteroid belt between Mars and Jupiter," +
                " and it's the only dwarf planet located in the inner solar system. It was the first member of the asteroid belt to be discovered" +
                " when Giuseppe Piazzi spotted it in 1801. When NASA's Dawn arrived in 2015, Ceres became the first dwarf planet to be explored by a spacecraft." +
                " Called an asteroid for many years, Ceres is so much bigger and so different from its rocky neighbors that scientists classified it as a dwarf planet in 2006." +
                " Even though Ceres comprises 25% of the asteroid belt's total mass, Pluto is still 14 times more massive.\r\n\r\nCeres is named for the Roman goddess of corn and harvests. The word cereal comes from the same name.",
                AccentColorStart = Color.FromArgb("#87CEFA"),
                AccentColorEnd = Color.FromArgb("#6495ED"),
                Images = new()
                {

                    "https://planetary.s3.amazonaws.com/web/assets/pictures/20160101_PIA20182.jpg",
                    "https://sos.noaa.gov/ftp_mirror/astronomy/ceres/media/thumbnail_big.jpg",
                    "https://t4.ftcdn.net/jpg/02/71/55/83/360_F_271558355_8LIj6WkuPUSSeIPKD0VwE645F6Ooipch.jpg"


                }
            },

            new()
            {
                Name = "Haumea",
                Subtitle = "Hawaiian goddess of fertility",
                HeroImage = "haumea.png",
                Description = "Haumea is roughly the same size as Pluto. It is one of the fastest rotating large objects in our solar system." +
                " The fast spin distorts Haumea's shape, making this dwarf planet look like a football." +
                " Everything we know about Haumea is from observations with ground-based telescopes from around the world.",
                AccentColorStart = Color.FromArgb("#87CEFA"),
                AccentColorEnd = Color.FromArgb("#6495ED"),
                Images = new()
                {

                    "https://www.usatoday.com/gcdn/-mm-/e54ae159c6af9eefa473e2b823987e51d93a9ee0/c=0-606-3991-2861/local/-/media/2017/10/11/USATODAY/USATODAY/636433277086394454-2017-06-07303A-haumea-350.jpg?width=3200&height=1809&fit=crop&format=pjpg&auto=webp",
                    "https://astrophotographylens.com/cdn/shop/articles/Haumea.jpg?v=1693095371"

                }
            },

            new()
            {
                Name = "MakeMake",
                Subtitle = "Rapanui god of fertility.",
                HeroImage = "makemake.png",
                Description = "Makemake, along with fellow dwarf planets Pluto, Eris, and Haumea, is located in the Kuiper Belt," +
                " a donut-shaped region of icy bodies beyond the orbit of Neptune. Makemake is slightly smaller than Pluto," +
                " and is the second-brightest object in the Kuiper Belt as seen from Earth while Pluto is the brightest." +
                " It takes about 305 Earth years for this dwarf planet to make one trip around the Sun." +
                " Makemake holds an important place in the history of solar system studies because it was one of the objects" +
                " – along with Eris – whose discovery prompted the International Astronomical Union to reconsider the definition of a planet, and to create the new group of dwarf planets.",
                AccentColorStart = Color.FromArgb("#87CEFA"),
                AccentColorEnd = Color.FromArgb("#6495ED"),
                Images = new()
                {

                    "https://www.windows2universe.org/our_solar_system/dwarf_planets/images/makemake_size_sm.jpg",
                    "https://www.universetoday.com/wp-content/uploads/2008/07/Makemake-1280x720.jpg"

                }
            },

            new()
            {
                Name = "Eris",
                Subtitle = " Greek goddess of discord and strife",
                HeroImage = "eris.png",
                Description = "At first, Eris appeared to be larger than Pluto. "+
                "This triggered a debate in the scientific community that led to the International Astronomical Union's decision in 2006 " +
                "to clarify the definition of a planet. Pluto, Eris, and other similar objects are now classified as dwarf planets.\r\n\r\n"+
                "Eris was discovered on Jan. 5, 2005, from data obtained on Oct. 21, 2003, during a Palomar Observatory survey " +
                "of the outer solar system by Mike Brown, a professor of planetary astronomy at the California Institute of Technology, " +
                "Chad Trujillo of the Gemini Observatory and David Rabinowitz of Yale University.",
                AccentColorStart = Color.FromArgb("#87CEFA"),
                AccentColorEnd = Color.FromArgb("#6495ED"),
                Images = new()
                {

                    "https://smd-cms.nasa.gov/wp-content/uploads/2023/06/Artists_c_oncept_of_Eris_and_Dysnomia_far_from_the_Sun-jpeg.webp?w=640&format=webp",
                    "https://upload.wikimedia.org/wikipedia/commons/5/5b/Eris_and_dysnomia2.jpg"

                }
            }

        };


        public static List<Planet> GetFeaturedPlanet()
        {
            var random = new Random();
            var randomizedPlaents = planets.OrderBy(item => random.Next());

            return randomizedPlaents.Take(3).ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;

    }
}
