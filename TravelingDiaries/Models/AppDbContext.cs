using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelingDiaries.Models;

namespace TravelingDiaries.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        //coupon
        public DbSet<Coupon> Coupons { get; set; }



        //cart tables
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }


        //places
        public DbSet<Place> place { get; set; }

        public DbSet<ShoppingCartItem> shoppingCartItems { get; set; }


        //flights
        public DbSet<Flight> Flights { get; set; }

        public DbSet<SearchFlight> SearchFlights { get; set; }

        public DbSet<FlightBooking> FlightBooking { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //seeding data for the places
            modelBuilder.Entity<Place>().HasData(new Place
            {
                PlaceID = 1,
                ShortDescription = "Jammu and Kashmir is a region administered by India as a union territory and consists of the southern portion of the larger Kashmir region.",

                PlaceName = "Jammu and Kashmir",
                Description = "Jammu and Kashmir is a union territory of India.It is situated in the northernmost part of India.The main languages that are used by the people of Jammu and Kashmir are Urdu, Dogri,and Kashmiri.Vaishno Devi and Amarnath are the major Hindu pilgrim centres in Jammu and Kashmir.",
                Image = "https://img.freepik.com/free-photo/sunrise-dal-lake-kashmir-india_1232-4765.jpg?w=740&t=st=1660742921~exp=1660743521~hmac=0923b8734ac5a6599c2586a098052333909e7042b57dfa255f6ad38608a23014",
                Image1 = "https://static.toiimg.com/thumb/62507186.cms?resizemode=75&width=1200&height=900",
                Image2 = "https://www.tourmyindia.com/blog//wp-content/uploads/2014/02/Top-Things-to-Do-in-Jammu-and-Kashmir.jpg",
                Image3 = "https://assets.thehansindia.com/h-upload/2021/12/04/1125042-kashmir.webp",
                PackagePrice = 50000

            }); ;
            modelBuilder.Entity<Place>().HasData(new Place
            {
                PlaceID = 2,
                PlaceName = "Delhi",
                ShortDescription = "Delhi is a part of the National Capital Region, which has 12.5 million residents. The governance of Delhi is like that of a state in India.",
                Description = "Delhi is officially the National Capital Territory. NewDelhi is the capital of India.Delhi has an important structure like Humayun’s tomb, Old fort, Siri fort,Jama Masjid,Lotus temple monuments.Delhi – it’s not just a city but an emotion.Delhi has been the centre of a succession of mighty empires and powerful kingdoms. Numerous ruins scattered throughout the territory offer a constant reminder of the area’s history.",
                Image = "https://cdn.britannica.com/37/189837-050-F0AF383E/New-Delhi-India-War-Memorial-arch-Sir.jpg",
                Image1 = "http://static2.tripoto.com/media/filter/tst/img/15546/TripDocument/4126922057_8e74c08828_o.jpg",
                Image2 = "https://cdn.britannica.com/92/189792-050-1B98CC71/Bara-Gumbad-mosque-Lodi-Gardens-Delhi.jpg",
                Image3 = "https://media.istockphoto.com/photos/humayun-tomb-new-delhi-india-picture-id505239248?k=20&m=505239248&s=612x612&w=0&h=-VDBIaBQquH4MEiLgeCwzhndOAGhIBjKseW_trSmWqo=",
                PackagePrice = 40000

            });
            modelBuilder.Entity<Place>().HasData(new Place
            {
                PlaceID = 3,
                PlaceName = "Jaipur",
                ShortDescription = " Across the entire Rajasthan, Jaipur is known to be the biggest city. It is also popularly called the Pink City.",
                Description = "Jaipur, popularly known as the Pink City of India, is the largest city in the state of RajasthanJaipur is the capital of state Rajasthan The main attraction of Jaipur is its archetypal architecture. The city was planned as per the Indian Vastu Shastra, a science that promotes well being and prosperity. The directions of all the streets and markets in Jaipur are East to West and North to South.Jai Singh II made sure that the entire Jaipur city was planned as per the Hindu architectural theory. ",
                Image = "https://static.independent.co.uk/s3fs-public/thumbnails/image/2018/08/14/09/jaipur-hawa.jpg?quality=75&width=982&height=726&auto=webp",
                Image1 = "https://www.micato.com/wp-content/uploads/2018/09/jaipur-1110x700.jpg",
                Image2 = "https://assets.traveltriangle.com/blog/wp-content/uploads/2016/09/jal-mahal-cover-439.jpg",
                Image3 = "https://image.shutterstock.com/image-photo/ancient-temple-ruins-gadi-sagar-260nw-786126286.jpg",
                PackagePrice = 25000

            });

            modelBuilder.Entity<Place>().HasData(new Place
            {
                PlaceID = 4,
                PlaceName = "Mumbai",
                ShortDescription = "Mumbai (formerly called Bombay) is a densely populated city on India’s west coast.",
                Description = "Mumbai was previously known as Bombay and it is the capital of Maharashtra.Mumbai is one of India’s largest cities which is also the financial and entertainment capital of India.Marathi is the main language of the state and Kabadi is the state sport.Gateway of India is the symbol of Mumbai.It is the tourists’ centre.One of the most iconic hotels of India, the Taj Mahal Palace is located in Mumbai.It is famous for Chhatrapati Shivaji Terminus.The city is known for its popular nightlife.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Marine_Lines_Mumbai_2021.jpg/800px-Marine_Lines_Mumbai_2021.jpg"
                ,
                Image1 = "https://www.holidify.com/images/bgImages/MUMBAI.jpg",
                Image2 = "https://images.unsplash.com/photo-1529253355930-ddbe423a2ac7?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8bXVtYmFpfGVufDB8fDB8fA%3D%3D&w=1000&q=80",
                Image3 = "https://assets.gqindia.com/photos/5f4df431de5e2aaea53dd83d/2:3/w_719,h_1079,c_limit/The-most-expensive-residential-spots-in-Mumbai-where-1-square-feet-costs-upwards-of-Rs-40,000.jpg",
                PackagePrice = 30000
            });
            modelBuilder.Entity<Place>().HasData(new Place
            {
                PlaceID = 5,
                PlaceName = "Chennai",
                ShortDescription = " Chennai used to be known as Madras. It is considered as the capital of Tamil Nadu in the southern side of India.",
                Description = "Chennai,formerly Madras,city,capital of Tamil Nadu state,southern India,located on the Coromandel Coast of the Bay of Bengal.Known as the “Gateway to South India,”Chennai is located on the Coromandel Coast along the Bay of Bengal.It is included as one of the four metropolitan siblings of the country.It has a cultural and historical background that is both rich and vast.It thoroughly mixes up with the metropolis lifestyle perfectly.Besides,it is very famous for its South-Indian culture, museums from the British Era, monuments, temples, and so on.",
                Image = "https://media.istockphoto.com/photos/detail-work-in-gopuram-hindu-temple-kapaleeshwarar-chennai-tamil-nadu-picture-id808900036?k=20&m=808900036&s=612x612&w=0&h=NLkFUtqGEnBgiSbtlhBF02CiZD9NZXbE0f3vccIwVnk="
                ,
                Image1 = "https://www.tralover.com/uploads/0000/1/2021/11/10/47193d1364680014c23ad25ff3b7e433.jpg",
                Image2 = "https://upload.wikimedia.org/wikipedia/commons/3/32/Chennai_Central.jpg",
                Image3 = "https://cdn.britannica.com/13/100813-050-708D93FE/Kapaleeswarar-temple-Hindu-Mylapore-Chennai-India-Tamil.jpg",
                PackagePrice = 50000

            });
            modelBuilder.Entity<Place>().HasData(new Place
            {
                PlaceID = 6,
                ShortDescription = "Udaipur have three interconnected lakes - the Fateh Sagar Lake, the Lake Pichhola and the smaller Swaroop Sagar Lake; along with forts.",

                PlaceName = "Udaipur",
                Description = "Often referred to as the 'Venice of the East', the city of lakes Udaipur is located around azure water lakes and is hemmed in by lush green hills of Aravallis.In the southern part of Indian state of Rajasthan, Udaipur is a city situated 598 m above the sea level. It is the best place to holiday in Rajasthan.",
                Image = "https://encrypted-tbn0.gstatic.com/licensed-image?q=tbn:ANd9GcTFsCN-yAXSGd3GOnUC1RTk9SoJZZzV3FatrT3F5GbpvYlNBrnS_1zT8vGahEfBjtEdQcqGE2kxoHHzb9JKQtZwJA",
                Image1 = "https://encrypted-tbn0.gstatic.com/licensed-image?q=tbn:ANd9GcQo8hkt8FZrJLNZj7wjDuZcQB9agcf4gThIoggqhDhPibEvSneuOOvRlTxsqjMcjYdipSJpqBLp3N0etO9JCaTS6w",
                Image2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSduhXFdsUOwyTksRnQ0bdfc8OS5DwZ-URk54QOk19NZ8b1X5JACNWld04laaIeU89OW6Bv1_IVbcu4780k7Qf9wg",
                Image3 = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRf8j4ypqtQVf6S0OemYc6Z2pxjDHGqv42KCF0q4YEMQzMy1Da8jTRZA2JJw9_uiLb-e9JiRs-LOVTZLUbHnp1V9A",
                PackagePrice = 60000

            });
            modelBuilder.Entity<Place>().HasData(new Place
            {
                PlaceID = 7,
                ShortDescription = "Shimla is a famous tourist place. Its main attractions are Mall Road, Jakhu Temple, Christ Church, Viceregal Lodge, and the Ridge.",

                PlaceName = "Shimla",
                Description = "The capital city of Himachal Pradesh, Shimla is one of the most popular hill stations in India and is frequented by millions of tourists every year. It is named after Goddess Shyamala and is also known as Queen of Hills.It is the main center of the Himachal Pradesh for education, commercial and cultural activities. ",
                Image = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcT4kD5t0fRYjYnu84HCOw_njMju1U0kyiE-bnylocByjAnpUgSI_Q4FKGN_VFG8ltVCWSuQAHtKuynDV9RIgyAmcA",
                Image1 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTbnVF0NOdj-YFrrR-SL3DpOuLb3jW1GTe0B_NwmUr4tMIneoPeaafmJvNVJ1SHeXMd9hiVltWtaJhEpI7q_RXs3A",
                Image2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRgMN4NEMf_7QT5XG5zfMJ484inUDyyj9CbDIF4Wl8enlgVPjSi6y8vLobBmybKEUHfqNqFibD2aipx1Nu2DpyBYA",
                Image3 = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcQJhxDEenevDBUakB4rpH3Qd5nXj-Z0EF7B9ZqytLnOomtIf9spTx3rgIABxkX1al0wl0yP1LPREh_LsXPnPEJ3jQ",
                PackagePrice = 45000

            });

            modelBuilder.Entity<Place>().HasData(new Place
            {
                PlaceID = 8,
                ShortDescription = "In pune many cultural festivals are celebrates at big level such are Gudi Padwa, Gokul Ashtami, Dussehra, Banganga Festival, Diwali, etc.",

                PlaceName = "Pune",
                Description = "Pune is beautiful and populated city located in Maharashtra state. Pune is 484.6 kilometer square in area and 6.8 million in population.Pune is at 9th rank in Indian most population cities.",
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQr_TZpX1Dbms0kv_Ed08d-3iivDOng9N-GtFXJ0nquKKc2LIl9Yc3xGL7DqQzbZvdcSxaCbwovAoEyyxDPvBE5mQ",
                Image1 = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcR_2rWxZXoLqruP0hnqVWoN6lnzdo4cjje-7dXo35alaCvfkibmBKPZWaaySvTfCT63p4q9onl15PBS_YppsU9E3w",
                Image2 = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSAXORxz7ARvTHda575bpo7eOyLo63MfU1LRK5Pnm3dHJEbRdHp7Ub0E3TV-MmG1PwEfpyvmF0YTCGuAVNDkxTFAw",
                Image3 = "https://encrypted-tbn0.gstatic.com/licensed-image?q=tbn:ANd9GcRTutLL9SfNwHYq6JaJEG9GIt2QZm48c347b1lsCo5Kq8ml40oY5XFt1cN2IX9TR-S6fR98jP-K6ZHmhDO5QVVc0Q",
                PackagePrice = 55000

            });
            modelBuilder.Entity<Place>().HasData(new Place
            {
                PlaceID = 9,
                ShortDescription = "It is popular for its white sand, beaches, active nightlife, and places of worship.",

                PlaceName = "Goa",
                Description = "Goa is a state of India on the southwestern coast of India.According to the area,it is the smallest state in India.It is spread over an area of 3,702 square kilometers.",
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTUaOWPMxwjrW4CeUf_4u_mZxWy-KMRXx5lldKKNXqNLPNQhzwggbgHSNxWxG46IWl-_w9xmAPZsryMRMfZc0NePQ",
                Image1 = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcSgxTtiTw3_qoV21j0bnkL7MI_tI3WOFiBmX3zyMKe-fsOOJQPZmnwEfo8Kwda_EGukoTkIKL0tjFJpF1cf20_QGA",
                Image2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQL_kNISV4Vpkyw94bUaKqoHHVM50EMV_wVQOpGVO87rf7NW4mADM0AbivKcCtjgG1Y7GM7c9oaWjOQM2WKnvySGQ",
                Image3 = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcShVaXif5gsIBJSXk72HEAio07UW7wEJy4kcRbW2e9MQ382r7XhOzwgeZFijKTYHmKE4i3vBztLq3sF7bdff-3FXg",
                PackagePrice = 44000

            });
            modelBuilder.Entity<Place>().HasData(new Place
            {
                PlaceID = 10,
                ShortDescription = " It is known as the city of the garden due to the presence of several beautiful parks and gardens. For instance: Cubbon Park, etc.",

                PlaceName = "Bangalore",
                Description = " Over 10 million people are residing in Bangalore. It has the third place in the most populous cities of India.It is located at a higher altitude in comparison with other big cities across India.It is the home of several prestigious industries,universities,and IT companies..",
                Image = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTyDc17WIH6fJ2Bq1q5p-QivcgFr0uE28asAslWkuxL_nHkJlJn6CYN773ltpMCQdgIAQC1CWj9XoBzTIrO6dAfvw",
                Image1 = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTSaI4hm_gUh90pjs8G-4WnL6EpCTQ7flsMvytw2UVrYXZR33ag23X1DVtHjl3vUu8wtKmOSTDD3CvY25cu8cICnw",
                Image2 = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTTyJYJx8UfJFi9saK8GiWU4TJfhmRgt8A-hZp5AKd-Sfve-ITQ0z29y4Jvy4v3wl4LnwxlicJ85W1jwyLvkbQwBQ",
                Image3 = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcScBKC3Xcxn-S795iAkpth3MxQIQODPkMs6oDMEY1EQD7s1svLCHT4iwvfdQ-G4P-ubTj4qqiGE75s6FgGBlo42xw",
                PackagePrice = 66000

            });
            modelBuilder.Entity<Place>().HasData(new Place
            {
                PlaceID = 11,
                ShortDescription = "Assam is known for Assam tea and Assam silk. The state was the first site for oil drilling in Asia.",

                PlaceName = "Assam ",
                Description = "It's a gateway to many other places in the North East as well as a brimming tourist hub. Everything from the ancient temples, the wildlife sanctuaries, the scenic beauty of the Brahmaputra, and its unique culture give this place some of the best tourist places in Assam",
                Image = "https://encrypted-tbn2.gstatic.com/licensed-image?q=tbn:ANd9GcQnLvsW86-_TQ9FAZ9zs3PVkIK1p4nrkpXBD3yNNn6CZemvW3TqCVVsYkbb-Ipf1pIIyFl6K29sL91s55QRQsoCUA",
                Image1 = "https://encrypted-tbn3.gstatic.com/licensed-image?q=tbn:ANd9GcSZtFRRjGP2FJlLmjNnAjvrOpuGRxLHADSHUWjn8D4uQ9mb30HcMzi8RYdt2bH3DXJ18_iuZjv9TmO-Ti7yNNGGvg",
                Image2 = "https://encrypted-tbn1.gstatic.com/licensed-image?q=tbn:ANd9GcSqhhniaEaIQj8QTjvUjx3bELpGgbTC0GYnQxLfMvkPFw6lJhjVXgUIyjOlalDWyY4QahHue8R9IZXtjuhoqOf1uA",
                Image3 = "https://encrypted-tbn0.gstatic.com/licensed-image?q=tbn:ANd9GcQGagSj-KtGpX6qBOpjfrBCKo3Mn8QUgACUqTykHTteKxYkqPpa2Au1dEKdKfZgXoexLk1OZD7Ro6k32XCTZN-CFQ",
                PackagePrice = 3000
                

            });
            modelBuilder.Entity<Place>().HasData(new Place
            {
                PlaceID = 12,
                ShortDescription = "Kerala is well-known for its mesmerizing backwaters, ecotourism initiatives, scenic beauty, amazing beaches, and mouthwatering cuisine.",

                PlaceName = "Kerala",
                Description = "Named as one of the ten paradises of the world by National Geographic Traveler, Kerala is famous especially for its ecotourism initiatives and beautiful backwaters. Its unique culture and traditions, coupled with its varied demography, have made Kerala one of the most popular tourist destinations in the world.",
                Image = "https://encrypted-tbn2.gstatic.com/licensed-image?q=tbn:ANd9GcSFwwA72JXDOvLShOsEvfiQGNd-0kuBTQrALemUs-BTrxpO23HcM95LJNA-c2HZnE_lNNpAnGzRs1DmYfg6U262JQ",
                Image1 = "https://encrypted-tbn2.gstatic.com/licensed-image?q=tbn:ANd9GcQMI2CK4zFESUf62IMuKLzxaA-Jc1kBtAM_jid2VJxeWsiTZd8hxnYbAG8Ra0U4kgdxu_oUKKz-aRTHBNAfUHnz5A",
                Image2 = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQVgdyp5QZQ17x7YSH7G2YsCDRvvVosOsi8mnh0ruKXQ3T0za0Bi0ENc9t9qKjlmyg7UhlHKKdei0cm3ciGxsRf3g",
                Image3 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRJn4KgQ9rdECo9yUqdMm-TflABBdej_7O2G19oNrYu_IpQSWUtrqyt1bxHOFHpVEZfevfUaXPJ1CpIUFAWsQoImA",
                PackagePrice = 28000
            });
            modelBuilder.Entity<Place>().HasData(new Place
            {
                PlaceID = 13,
                ShortDescription = "The city is noted for its monuments which includes the masterpiece of Charminar and the fort of Golconda.",

                PlaceName = "Hyderabad",
                Description = "The capital city of Telangana, Hyderabad is a popular tourist destination and presents its visitors with a mesmerising contrast of age old traditions, culture at one end and modern facilities, amenities of a metropolitan city at the other end. Hyderabad is one city, which has no dearth of tourist attractions.",
                Image = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcQUiCmrH7Ll3ReM5vtULA7cimCYVcsm3-xGSd1zlCHQutf61vC7Vv9HAnbZNvFJgDtUOZHHGvA1k94M_BmVXsOO_Q",
                Image1 = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTgSdCbZmR08x4Wz8JqcCIvbpwKiLnuQCjBYnYH48LjwYXA20lGPB6t6VPQiWS0Nd5RUIsdtedKTZFiWHmLQcuRLw",
                Image2 = "https://encrypted-tbn2.gstatic.com/licensed-image?q=tbn:ANd9GcR1S1LJntyru5Tk5T6aWgRhEhrZkz61fjWknVkLewrjGCqCrPqydnZazgdaWjMc0ZKQN6JoLzh4oT5HA8ZjGfL5WQ",
                Image3 = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcSkuSYKJ2-H3T-BkcNaKn8UCo1ktCfC8YfA4S-SWssLmVh4ZWuzBSSHQeOb3OGVoRKGGFWqX1jDYhZ9acIq4j_Y_g",
                PackagePrice = 20000

            });
            modelBuilder.Entity<Place>().HasData(new Place
            {
                PlaceID = 14,
                ShortDescription = "Within Gujarat there are a wide variety of historic forts, palaces and places of historical importance in India's struggle for independence. ",

                PlaceName = "Gujarat",
                Description = "Gujarat, state of India, located on the country’s western coast, on the Arabian Sea. It encompasses the entire Kathiawar Peninsula (Saurashtra) as well as the surrounding area on the mainland..",
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTLTmpMpieMNGwVN2IMti4cpSWnQ4xX-OkTWKoov_eMsAIAq2vPRz339h8RyPFs6qrkP0uAL-tH34fFgT-lSs48fw",
                Image1 = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcT_OVObGZbhZqKuSIGPfnH1pAyO3eA0hg2-U3bQLfGQQHfOKcfM-TJ6CkVpBw1fvws7_ZJFxBO2Lg8vWWiCC0nZQA",
                Image2 = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTdouHS07AInLf6Lwzy1vRxY5vS_4Rjp5jKyLz7lftUxnqeFcJqliBlb8WrzURfO1Hm9rCD18SqJXuVQL7zwbY3nA",
                Image3 = "https://encrypted-tbn1.gstatic.com/licensed-image?q=tbn:ANd9GcQGvPeq-jOiRYm3_dpMP3upnAcSXA6XoZlmG4EnezV1b6SfRZ1iPpAyM9ePgrGPDUK9569L4JChIr2Sb1AJ4M4AOQ",
                PackagePrice = 50900

            });
            modelBuilder.Entity<Place>().HasData(new Place
            {
                PlaceID = 15,
                ShortDescription = "Nainital is famous for the Naini Lake. Some of the other places of tourist interest are the Mall, now known as the Govind Ballabh Pant Marg",

                PlaceName = "Nainital",
                Description = "Nainital is famous as Hill Station, Honeymoon Destination, Weekend Getaway, Hot Destination, Editors Choice, Christmas and New Year, Leisure, Cities, Town, Ropeways, Shopping, Boating, Yachting, Featured, Kids & family spots , Romantic, with over",
                Image = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRjV5sHXbNUpkWi3FuAk_O8nI9vMwTBoHrIsmCZw1DKDVDKutK5cy1gKRakpqcvhdnUbW40vya4kc-bxau6AB-1hg",
                Image1 = "https://encrypted-tbn2.gstatic.com/licensed-image?q=tbn:ANd9GcQGSctI5RWvvo2rtNE1kXH6myPycCkC58qwfmMkW9yR5vyGvXH9m0k9D3yoS9e-0EklM53nNNn-HUoOTwUhMtoeDg",
                Image2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTRpsWIiDkSQVeqkCQeOEonUl62dugDp-GTW9UhxEQdYgX1B5vtfF8e_OBnQA5_ZK9CzH8liV7sEPHyn6Xb-sgA3w",
                Image3 = "https://encrypted-tbn2.gstatic.com/licensed-image?q=tbn:ANd9GcS5reC0YzLFNaes1RMpW-7h5Ee0zFAGHdCZJRf6O4ji3DtDNf9UpMU1QqOTc6XJllkhPDMBPMbNfR9xkFctPGu_XQ",
                PackagePrice = 65000

            });
            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 1,
                FlightName = "KingFisher",
                From = "Jaipur",
                To = "Mumbai",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 2,
                FlightName = "KingFisher",
                From = "Mumbai",
                To = "Jaipur",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 3,
                FlightName = "SpiceJet",
                From = "Jaipur",
                To = "Mumbai",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 4,
                FlightName = "SpiceJet",
                From = "Mumbai",
                To = "Jaipur",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 5,
                FlightName = "KingFisher",
                From = "Jaipur",
                To = "Delhi",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 6,
                FlightName = "KingFisher",
                From = "Delhi",
                To = "Jaipur",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 7,
                FlightName = "SpiceJet",
                From = "Jaipur",
                To = "Delhi",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 8,
                FlightName = "SpiceJet",
                From = "Delhi",
                To = "Jaipur",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 9,
                FlightName = "KingFisher",
                From = "Jaipur",
                To = "Chennai",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 10,
                FlightName = "KingFisher",
                From = "Chennai",
                To = "Jaipur",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 11,
                FlightName = "SpiceJet",
                From = "Jaipur",
                To = "Chennai",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 12,
                FlightName = "SpiceJet",
                From = "Chennai",
                To = "Jaipur",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 13,
                FlightName = "KingFisher",
                From = "Jaipur",
                To = "Jammu & Kashmir",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 14,
                FlightName = "KingFisher",
                From = "Jammu & Kashmir",
                To = "Jaipur",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 15,
                FlightName = "SpiceJet",
                From = "Jaipur",
                To = "Jammu & Kashmir",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 16,
                FlightName = "SpiceJet",
                From = "Jammu & Kashmir",
                To = "Jaipur",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 17,
                FlightName = "KingFisher",
                From = "Delhi",
                To = "Mumbai",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 18,
                FlightName = "KingFisher",
                From = "Mumbai",
                To = "Delhi",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 19,
                FlightName = "SpiceJet",
                From = "Delhi",
                To = "Mumbai",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 20,
                FlightName = "SpiceJet",
                From = "Mumbai",
                To = "Delhi",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 21,
                FlightName = "KingFisher",
                From = "Delhi",
                To = "Chennai",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 22,
                FlightName = "KingFisher",
                From = "Chennai",
                To = "Delhi",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 23,
                FlightName = "SpiceJet",
                From = "Delhi",
                To = "Chennai",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 24,
                FlightName = "SpiceJet",
                From = "Chennai",
                To = "Delhi",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 25,
                FlightName = "KingFisher",
                From = "Delhi",
                To = "Jammu & Kashmir",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 26,
                FlightName = "KingFisher",
                From = "Jammu & Kashmir",
                To = "Delhi",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 27,
                FlightName = "SpiceJet",
                From = "Delhi",
                To = "Jammu & Kashmir",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 28,
                FlightName = "SpiceJet",
                From = "Jammu & Kashmir",
                To = "Delhi",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 29,
                FlightName = "KingFisher",
                From = "Mumbai",
                To = "Chennai",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 30,
                FlightName = "KingFisher",
                From = "Chennai",
                To = "Mumbai",
                Time = new TimeSpan(10, 00
                , 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 31,
                FlightName = "SpiceJet",
                From = "Mumbai",
                To = "Chennai",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 32,
                FlightName = "SpiceJet",
                From = "Chennai",
                To = "Mumbai",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 33,
                FlightName = "KingFisher",
                From = "Jammu & Kashmir",
                To = "Chennai",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 34,
                FlightName = "KingFisher",
                From = "Chennai",
                To = "Jammu & Kashmir",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 35,
                FlightName = "SpiceJet",
                From = "Jammu & Kashmir",
                To = "Chennai",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 36,
                FlightName = "SpiceJet",
                From = "Chennai",
                To = "Jammu & Kashmir",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 37,
                FlightName = "KingFisher",
                From = "Jammu & Kashmir",
                To = "Mumbai",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 38,
                FlightName = "KingFisher",
                From = "Mumbai",
                To = "Jammu & Kashmir",
                Time = new TimeSpan(10, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 39,
                FlightName = "SpiceJet",
                From = "Jammu & Kashmir",
                To = "Mumbai",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Flight>().HasData(new Flight
            {

                FlightId = 40,
                FlightName = "SpiceJet",
                From = "Mumbai",
                To = "Jammu & Kashmir",
                Time = new TimeSpan(17, 00, 00)
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 1,
                CouponCode="SAVE10",
                value=10
            });
              modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 2,
                CouponCode="SAVE70",
                value=70
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 3,
                CouponCode = "SUMMER50",
                value = 30
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 4,
                CouponCode = "HAPPY40",
                value = 40
            });







        }

        public DbSet<TravelingDiaries.Models.HotelMini>? HotelMini { get; set; }
    }
}
