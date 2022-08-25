using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelingDiaries.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    CouponId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouponCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.CouponId);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightId);
                });

            migrationBuilder.CreateTable(
                name: "HotelMini",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelMini", x => x.HotelId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderPlaced = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "place",
                columns: table => new
                {
                    PlaceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackagePrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_place", x => x.PlaceID);
                });

            migrationBuilder.CreateTable(
                name: "SearchFlights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchFlights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlightBooking",
                columns: table => new
                {
                    PassengerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassengerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CartID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdhaarId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfFlight = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FlightId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightBooking", x => x.PassengerId);
                    table.ForeignKey(
                        name: "FK_FlightBooking_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    PlaceId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_place_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "place",
                        principalColumn: "PlaceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "shoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_shoppingCartItems_place_PlaceID",
                        column: x => x.PlaceID,
                        principalTable: "place",
                        principalColumn: "PlaceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponId", "CouponCode", "value" },
                values: new object[,]
                {
                    { 1, "SAVE10", 10 },
                    { 2, "SAVE70", 70 },
                    { 3, "SUMMER50", 30 },
                    { 4, "HAPPY40", 40 }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "FlightName", "From", "Time", "To" },
                values: new object[,]
                {
                    { 1, "KingFisher", "Jaipur", new TimeSpan(0, 10, 0, 0, 0), "Mumbai" },
                    { 2, "KingFisher", "Mumbai", new TimeSpan(0, 10, 0, 0, 0), "Jaipur" },
                    { 3, "SpiceJet", "Jaipur", new TimeSpan(0, 17, 0, 0, 0), "Mumbai" },
                    { 4, "SpiceJet", "Mumbai", new TimeSpan(0, 17, 0, 0, 0), "Jaipur" },
                    { 5, "KingFisher", "Jaipur", new TimeSpan(0, 10, 0, 0, 0), "Delhi" },
                    { 6, "KingFisher", "Delhi", new TimeSpan(0, 10, 0, 0, 0), "Jaipur" },
                    { 7, "SpiceJet", "Jaipur", new TimeSpan(0, 17, 0, 0, 0), "Delhi" },
                    { 8, "SpiceJet", "Delhi", new TimeSpan(0, 17, 0, 0, 0), "Jaipur" },
                    { 9, "KingFisher", "Jaipur", new TimeSpan(0, 10, 0, 0, 0), "Chennai" },
                    { 10, "KingFisher", "Chennai", new TimeSpan(0, 10, 0, 0, 0), "Jaipur" },
                    { 11, "SpiceJet", "Jaipur", new TimeSpan(0, 17, 0, 0, 0), "Chennai" },
                    { 12, "SpiceJet", "Chennai", new TimeSpan(0, 17, 0, 0, 0), "Jaipur" },
                    { 13, "KingFisher", "Jaipur", new TimeSpan(0, 10, 0, 0, 0), "Jammu & Kashmir" },
                    { 14, "KingFisher", "Jammu & Kashmir", new TimeSpan(0, 10, 0, 0, 0), "Jaipur" },
                    { 15, "SpiceJet", "Jaipur", new TimeSpan(0, 17, 0, 0, 0), "Jammu & Kashmir" },
                    { 16, "SpiceJet", "Jammu & Kashmir", new TimeSpan(0, 17, 0, 0, 0), "Jaipur" },
                    { 17, "KingFisher", "Delhi", new TimeSpan(0, 10, 0, 0, 0), "Mumbai" },
                    { 18, "KingFisher", "Mumbai", new TimeSpan(0, 10, 0, 0, 0), "Delhi" },
                    { 19, "SpiceJet", "Delhi", new TimeSpan(0, 17, 0, 0, 0), "Mumbai" },
                    { 20, "SpiceJet", "Mumbai", new TimeSpan(0, 17, 0, 0, 0), "Delhi" },
                    { 21, "KingFisher", "Delhi", new TimeSpan(0, 10, 0, 0, 0), "Chennai" },
                    { 22, "KingFisher", "Chennai", new TimeSpan(0, 10, 0, 0, 0), "Delhi" },
                    { 23, "SpiceJet", "Delhi", new TimeSpan(0, 17, 0, 0, 0), "Chennai" },
                    { 24, "SpiceJet", "Chennai", new TimeSpan(0, 17, 0, 0, 0), "Delhi" },
                    { 25, "KingFisher", "Delhi", new TimeSpan(0, 10, 0, 0, 0), "Jammu & Kashmir" },
                    { 26, "KingFisher", "Jammu & Kashmir", new TimeSpan(0, 10, 0, 0, 0), "Delhi" },
                    { 27, "SpiceJet", "Delhi", new TimeSpan(0, 17, 0, 0, 0), "Jammu & Kashmir" },
                    { 28, "SpiceJet", "Jammu & Kashmir", new TimeSpan(0, 17, 0, 0, 0), "Delhi" },
                    { 29, "KingFisher", "Mumbai", new TimeSpan(0, 10, 0, 0, 0), "Chennai" },
                    { 30, "KingFisher", "Chennai", new TimeSpan(0, 10, 0, 0, 0), "Mumbai" },
                    { 31, "SpiceJet", "Mumbai", new TimeSpan(0, 17, 0, 0, 0), "Chennai" },
                    { 32, "SpiceJet", "Chennai", new TimeSpan(0, 17, 0, 0, 0), "Mumbai" },
                    { 33, "KingFisher", "Jammu & Kashmir", new TimeSpan(0, 10, 0, 0, 0), "Chennai" },
                    { 34, "KingFisher", "Chennai", new TimeSpan(0, 10, 0, 0, 0), "Jammu & Kashmir" },
                    { 35, "SpiceJet", "Jammu & Kashmir", new TimeSpan(0, 17, 0, 0, 0), "Chennai" },
                    { 36, "SpiceJet", "Chennai", new TimeSpan(0, 17, 0, 0, 0), "Jammu & Kashmir" },
                    { 37, "KingFisher", "Jammu & Kashmir", new TimeSpan(0, 10, 0, 0, 0), "Mumbai" },
                    { 38, "KingFisher", "Mumbai", new TimeSpan(0, 10, 0, 0, 0), "Jammu & Kashmir" }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "FlightName", "From", "Time", "To" },
                values: new object[,]
                {
                    { 39, "SpiceJet", "Jammu & Kashmir", new TimeSpan(0, 17, 0, 0, 0), "Mumbai" },
                    { 40, "SpiceJet", "Mumbai", new TimeSpan(0, 17, 0, 0, 0), "Jammu & Kashmir" }
                });

            migrationBuilder.InsertData(
                table: "place",
                columns: new[] { "PlaceID", "Description", "Image", "Image1", "Image2", "Image3", "PackagePrice", "PlaceName", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "Jammu and Kashmir is a union territory of India.It is situated in the northernmost part of India.The main languages that are used by the people of Jammu and Kashmir are Urdu, Dogri,and Kashmiri.Vaishno Devi and Amarnath are the major Hindu pilgrim centres in Jammu and Kashmir.", "https://img.freepik.com/free-photo/sunrise-dal-lake-kashmir-india_1232-4765.jpg?w=740&t=st=1660742921~exp=1660743521~hmac=0923b8734ac5a6599c2586a098052333909e7042b57dfa255f6ad38608a23014", "https://static.toiimg.com/thumb/62507186.cms?resizemode=75&width=1200&height=900", "https://www.tourmyindia.com/blog//wp-content/uploads/2014/02/Top-Things-to-Do-in-Jammu-and-Kashmir.jpg", "https://assets.thehansindia.com/h-upload/2021/12/04/1125042-kashmir.webp", 50000, "Jammu and Kashmir", "Jammu and Kashmir is a region administered by India as a union territory and consists of the southern portion of the larger Kashmir region." },
                    { 2, "Delhi is officially the National Capital Territory. NewDelhi is the capital of India.Delhi has an important structure like Humayun’s tomb, Old fort, Siri fort,Jama Masjid,Lotus temple monuments.Delhi – it’s not just a city but an emotion.Delhi has been the centre of a succession of mighty empires and powerful kingdoms. Numerous ruins scattered throughout the territory offer a constant reminder of the area’s history.", "https://cdn.britannica.com/37/189837-050-F0AF383E/New-Delhi-India-War-Memorial-arch-Sir.jpg", "http://static2.tripoto.com/media/filter/tst/img/15546/TripDocument/4126922057_8e74c08828_o.jpg", "https://cdn.britannica.com/92/189792-050-1B98CC71/Bara-Gumbad-mosque-Lodi-Gardens-Delhi.jpg", "https://media.istockphoto.com/photos/humayun-tomb-new-delhi-india-picture-id505239248?k=20&m=505239248&s=612x612&w=0&h=-VDBIaBQquH4MEiLgeCwzhndOAGhIBjKseW_trSmWqo=", 40000, "Delhi", "Delhi is a part of the National Capital Region, which has 12.5 million residents. The governance of Delhi is like that of a state in India." },
                    { 3, "Jaipur, popularly known as the Pink City of India, is the largest city in the state of RajasthanJaipur is the capital of state Rajasthan The main attraction of Jaipur is its archetypal architecture. The city was planned as per the Indian Vastu Shastra, a science that promotes well being and prosperity. The directions of all the streets and markets in Jaipur are East to West and North to South.Jai Singh II made sure that the entire Jaipur city was planned as per the Hindu architectural theory. ", "https://static.independent.co.uk/s3fs-public/thumbnails/image/2018/08/14/09/jaipur-hawa.jpg?quality=75&width=982&height=726&auto=webp", "https://www.micato.com/wp-content/uploads/2018/09/jaipur-1110x700.jpg", "https://assets.traveltriangle.com/blog/wp-content/uploads/2016/09/jal-mahal-cover-439.jpg", "https://image.shutterstock.com/image-photo/ancient-temple-ruins-gadi-sagar-260nw-786126286.jpg", 25000, "Jaipur", " Across the entire Rajasthan, Jaipur is known to be the biggest city. It is also popularly called the Pink City." },
                    { 4, "Mumbai was previously known as Bombay and it is the capital of Maharashtra.Mumbai is one of India’s largest cities which is also the financial and entertainment capital of India.Marathi is the main language of the state and Kabadi is the state sport.Gateway of India is the symbol of Mumbai.It is the tourists’ centre.One of the most iconic hotels of India, the Taj Mahal Palace is located in Mumbai.It is famous for Chhatrapati Shivaji Terminus.The city is known for its popular nightlife.", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Marine_Lines_Mumbai_2021.jpg/800px-Marine_Lines_Mumbai_2021.jpg", "https://www.holidify.com/images/bgImages/MUMBAI.jpg", "https://images.unsplash.com/photo-1529253355930-ddbe423a2ac7?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8bXVtYmFpfGVufDB8fDB8fA%3D%3D&w=1000&q=80", "https://assets.gqindia.com/photos/5f4df431de5e2aaea53dd83d/2:3/w_719,h_1079,c_limit/The-most-expensive-residential-spots-in-Mumbai-where-1-square-feet-costs-upwards-of-Rs-40,000.jpg", 30000, "Mumbai", "Mumbai (formerly called Bombay) is a densely populated city on India’s west coast." },
                    { 5, "Chennai,formerly Madras,city,capital of Tamil Nadu state,southern India,located on the Coromandel Coast of the Bay of Bengal.Known as the “Gateway to South India,”Chennai is located on the Coromandel Coast along the Bay of Bengal.It is included as one of the four metropolitan siblings of the country.It has a cultural and historical background that is both rich and vast.It thoroughly mixes up with the metropolis lifestyle perfectly.Besides,it is very famous for its South-Indian culture, museums from the British Era, monuments, temples, and so on.", "https://media.istockphoto.com/photos/detail-work-in-gopuram-hindu-temple-kapaleeshwarar-chennai-tamil-nadu-picture-id808900036?k=20&m=808900036&s=612x612&w=0&h=NLkFUtqGEnBgiSbtlhBF02CiZD9NZXbE0f3vccIwVnk=", "https://www.tralover.com/uploads/0000/1/2021/11/10/47193d1364680014c23ad25ff3b7e433.jpg", "https://upload.wikimedia.org/wikipedia/commons/3/32/Chennai_Central.jpg", "https://cdn.britannica.com/13/100813-050-708D93FE/Kapaleeswarar-temple-Hindu-Mylapore-Chennai-India-Tamil.jpg", 50000, "Chennai", " Chennai used to be known as Madras. It is considered as the capital of Tamil Nadu in the southern side of India." },
                    { 6, "Often referred to as the 'Venice of the East', the city of lakes Udaipur is located around azure water lakes and is hemmed in by lush green hills of Aravallis.In the southern part of Indian state of Rajasthan, Udaipur is a city situated 598 m above the sea level. It is the best place to holiday in Rajasthan.", "https://encrypted-tbn0.gstatic.com/licensed-image?q=tbn:ANd9GcTFsCN-yAXSGd3GOnUC1RTk9SoJZZzV3FatrT3F5GbpvYlNBrnS_1zT8vGahEfBjtEdQcqGE2kxoHHzb9JKQtZwJA", "https://encrypted-tbn0.gstatic.com/licensed-image?q=tbn:ANd9GcQo8hkt8FZrJLNZj7wjDuZcQB9agcf4gThIoggqhDhPibEvSneuOOvRlTxsqjMcjYdipSJpqBLp3N0etO9JCaTS6w", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSduhXFdsUOwyTksRnQ0bdfc8OS5DwZ-URk54QOk19NZ8b1X5JACNWld04laaIeU89OW6Bv1_IVbcu4780k7Qf9wg", "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRf8j4ypqtQVf6S0OemYc6Z2pxjDHGqv42KCF0q4YEMQzMy1Da8jTRZA2JJw9_uiLb-e9JiRs-LOVTZLUbHnp1V9A", 60000, "Udaipur", "Udaipur have three interconnected lakes - the Fateh Sagar Lake, the Lake Pichhola and the smaller Swaroop Sagar Lake; along with forts." },
                    { 7, "The capital city of Himachal Pradesh, Shimla is one of the most popular hill stations in India and is frequented by millions of tourists every year. It is named after Goddess Shyamala and is also known as Queen of Hills.It is the main center of the Himachal Pradesh for education, commercial and cultural activities. ", "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcT4kD5t0fRYjYnu84HCOw_njMju1U0kyiE-bnylocByjAnpUgSI_Q4FKGN_VFG8ltVCWSuQAHtKuynDV9RIgyAmcA", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTbnVF0NOdj-YFrrR-SL3DpOuLb3jW1GTe0B_NwmUr4tMIneoPeaafmJvNVJ1SHeXMd9hiVltWtaJhEpI7q_RXs3A", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRgMN4NEMf_7QT5XG5zfMJ484inUDyyj9CbDIF4Wl8enlgVPjSi6y8vLobBmybKEUHfqNqFibD2aipx1Nu2DpyBYA", "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcQJhxDEenevDBUakB4rpH3Qd5nXj-Z0EF7B9ZqytLnOomtIf9spTx3rgIABxkX1al0wl0yP1LPREh_LsXPnPEJ3jQ", 45000, "Shimla", "Shimla is a famous tourist place. Its main attractions are Mall Road, Jakhu Temple, Christ Church, Viceregal Lodge, and the Ridge." },
                    { 8, "Pune is beautiful and populated city located in Maharashtra state. Pune is 484.6 kilometer square in area and 6.8 million in population.Pune is at 9th rank in Indian most population cities.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQr_TZpX1Dbms0kv_Ed08d-3iivDOng9N-GtFXJ0nquKKc2LIl9Yc3xGL7DqQzbZvdcSxaCbwovAoEyyxDPvBE5mQ", "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcR_2rWxZXoLqruP0hnqVWoN6lnzdo4cjje-7dXo35alaCvfkibmBKPZWaaySvTfCT63p4q9onl15PBS_YppsU9E3w", "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSAXORxz7ARvTHda575bpo7eOyLo63MfU1LRK5Pnm3dHJEbRdHp7Ub0E3TV-MmG1PwEfpyvmF0YTCGuAVNDkxTFAw", "https://encrypted-tbn0.gstatic.com/licensed-image?q=tbn:ANd9GcRTutLL9SfNwHYq6JaJEG9GIt2QZm48c347b1lsCo5Kq8ml40oY5XFt1cN2IX9TR-S6fR98jP-K6ZHmhDO5QVVc0Q", 55000, "Pune", "In pune many cultural festivals are celebrates at big level such are Gudi Padwa, Gokul Ashtami, Dussehra, Banganga Festival, Diwali, etc." },
                    { 9, "Goa is a state of India on the southwestern coast of India.According to the area,it is the smallest state in India.It is spread over an area of 3,702 square kilometers.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTUaOWPMxwjrW4CeUf_4u_mZxWy-KMRXx5lldKKNXqNLPNQhzwggbgHSNxWxG46IWl-_w9xmAPZsryMRMfZc0NePQ", "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcSgxTtiTw3_qoV21j0bnkL7MI_tI3WOFiBmX3zyMKe-fsOOJQPZmnwEfo8Kwda_EGukoTkIKL0tjFJpF1cf20_QGA", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQL_kNISV4Vpkyw94bUaKqoHHVM50EMV_wVQOpGVO87rf7NW4mADM0AbivKcCtjgG1Y7GM7c9oaWjOQM2WKnvySGQ", "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcShVaXif5gsIBJSXk72HEAio07UW7wEJy4kcRbW2e9MQ382r7XhOzwgeZFijKTYHmKE4i3vBztLq3sF7bdff-3FXg", 44000, "Goa", "It is popular for its white sand, beaches, active nightlife, and places of worship." },
                    { 10, " Over 10 million people are residing in Bangalore. It has the third place in the most populous cities of India.It is located at a higher altitude in comparison with other big cities across India.It is the home of several prestigious industries,universities,and IT companies..", "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTyDc17WIH6fJ2Bq1q5p-QivcgFr0uE28asAslWkuxL_nHkJlJn6CYN773ltpMCQdgIAQC1CWj9XoBzTIrO6dAfvw", "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTSaI4hm_gUh90pjs8G-4WnL6EpCTQ7flsMvytw2UVrYXZR33ag23X1DVtHjl3vUu8wtKmOSTDD3CvY25cu8cICnw", "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTTyJYJx8UfJFi9saK8GiWU4TJfhmRgt8A-hZp5AKd-Sfve-ITQ0z29y4Jvy4v3wl4LnwxlicJ85W1jwyLvkbQwBQ", "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcScBKC3Xcxn-S795iAkpth3MxQIQODPkMs6oDMEY1EQD7s1svLCHT4iwvfdQ-G4P-ubTj4qqiGE75s6FgGBlo42xw", 66000, "Bangalore", " It is known as the city of the garden due to the presence of several beautiful parks and gardens. For instance: Cubbon Park, etc." },
                    { 11, "It's a gateway to many other places in the North East as well as a brimming tourist hub. Everything from the ancient temples, the wildlife sanctuaries, the scenic beauty of the Brahmaputra, and its unique culture give this place some of the best tourist places in Assam", "https://encrypted-tbn2.gstatic.com/licensed-image?q=tbn:ANd9GcQnLvsW86-_TQ9FAZ9zs3PVkIK1p4nrkpXBD3yNNn6CZemvW3TqCVVsYkbb-Ipf1pIIyFl6K29sL91s55QRQsoCUA", "https://encrypted-tbn3.gstatic.com/licensed-image?q=tbn:ANd9GcSZtFRRjGP2FJlLmjNnAjvrOpuGRxLHADSHUWjn8D4uQ9mb30HcMzi8RYdt2bH3DXJ18_iuZjv9TmO-Ti7yNNGGvg", "https://encrypted-tbn1.gstatic.com/licensed-image?q=tbn:ANd9GcSqhhniaEaIQj8QTjvUjx3bELpGgbTC0GYnQxLfMvkPFw6lJhjVXgUIyjOlalDWyY4QahHue8R9IZXtjuhoqOf1uA", "https://encrypted-tbn0.gstatic.com/licensed-image?q=tbn:ANd9GcQGagSj-KtGpX6qBOpjfrBCKo3Mn8QUgACUqTykHTteKxYkqPpa2Au1dEKdKfZgXoexLk1OZD7Ro6k32XCTZN-CFQ", 3000, "Assam ", "Assam is known for Assam tea and Assam silk. The state was the first site for oil drilling in Asia." },
                    { 12, "Named as one of the ten paradises of the world by National Geographic Traveler, Kerala is famous especially for its ecotourism initiatives and beautiful backwaters. Its unique culture and traditions, coupled with its varied demography, have made Kerala one of the most popular tourist destinations in the world.", "https://encrypted-tbn2.gstatic.com/licensed-image?q=tbn:ANd9GcSFwwA72JXDOvLShOsEvfiQGNd-0kuBTQrALemUs-BTrxpO23HcM95LJNA-c2HZnE_lNNpAnGzRs1DmYfg6U262JQ", "https://encrypted-tbn2.gstatic.com/licensed-image?q=tbn:ANd9GcQMI2CK4zFESUf62IMuKLzxaA-Jc1kBtAM_jid2VJxeWsiTZd8hxnYbAG8Ra0U4kgdxu_oUKKz-aRTHBNAfUHnz5A", "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQVgdyp5QZQ17x7YSH7G2YsCDRvvVosOsi8mnh0ruKXQ3T0za0Bi0ENc9t9qKjlmyg7UhlHKKdei0cm3ciGxsRf3g", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRJn4KgQ9rdECo9yUqdMm-TflABBdej_7O2G19oNrYu_IpQSWUtrqyt1bxHOFHpVEZfevfUaXPJ1CpIUFAWsQoImA", 28000, "Kerala", "Kerala is well-known for its mesmerizing backwaters, ecotourism initiatives, scenic beauty, amazing beaches, and mouthwatering cuisine." },
                    { 13, "The capital city of Telangana, Hyderabad is a popular tourist destination and presents its visitors with a mesmerising contrast of age old traditions, culture at one end and modern facilities, amenities of a metropolitan city at the other end. Hyderabad is one city, which has no dearth of tourist attractions.", "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcQUiCmrH7Ll3ReM5vtULA7cimCYVcsm3-xGSd1zlCHQutf61vC7Vv9HAnbZNvFJgDtUOZHHGvA1k94M_BmVXsOO_Q", "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTgSdCbZmR08x4Wz8JqcCIvbpwKiLnuQCjBYnYH48LjwYXA20lGPB6t6VPQiWS0Nd5RUIsdtedKTZFiWHmLQcuRLw", "https://encrypted-tbn2.gstatic.com/licensed-image?q=tbn:ANd9GcR1S1LJntyru5Tk5T6aWgRhEhrZkz61fjWknVkLewrjGCqCrPqydnZazgdaWjMc0ZKQN6JoLzh4oT5HA8ZjGfL5WQ", "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcSkuSYKJ2-H3T-BkcNaKn8UCo1ktCfC8YfA4S-SWssLmVh4ZWuzBSSHQeOb3OGVoRKGGFWqX1jDYhZ9acIq4j_Y_g", 20000, "Hyderabad", "The city is noted for its monuments which includes the masterpiece of Charminar and the fort of Golconda." },
                    { 14, "Gujarat, state of India, located on the country’s western coast, on the Arabian Sea. It encompasses the entire Kathiawar Peninsula (Saurashtra) as well as the surrounding area on the mainland..", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTLTmpMpieMNGwVN2IMti4cpSWnQ4xX-OkTWKoov_eMsAIAq2vPRz339h8RyPFs6qrkP0uAL-tH34fFgT-lSs48fw", "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcT_OVObGZbhZqKuSIGPfnH1pAyO3eA0hg2-U3bQLfGQQHfOKcfM-TJ6CkVpBw1fvws7_ZJFxBO2Lg8vWWiCC0nZQA", "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTdouHS07AInLf6Lwzy1vRxY5vS_4Rjp5jKyLz7lftUxnqeFcJqliBlb8WrzURfO1Hm9rCD18SqJXuVQL7zwbY3nA", "https://encrypted-tbn1.gstatic.com/licensed-image?q=tbn:ANd9GcQGvPeq-jOiRYm3_dpMP3upnAcSXA6XoZlmG4EnezV1b6SfRZ1iPpAyM9ePgrGPDUK9569L4JChIr2Sb1AJ4M4AOQ", 50900, "Gujarat", "Within Gujarat there are a wide variety of historic forts, palaces and places of historical importance in India's struggle for independence. " },
                    { 15, "Nainital is famous as Hill Station, Honeymoon Destination, Weekend Getaway, Hot Destination, Editors Choice, Christmas and New Year, Leisure, Cities, Town, Ropeways, Shopping, Boating, Yachting, Featured, Kids & family spots , Romantic, with over", "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRjV5sHXbNUpkWi3FuAk_O8nI9vMwTBoHrIsmCZw1DKDVDKutK5cy1gKRakpqcvhdnUbW40vya4kc-bxau6AB-1hg", "https://encrypted-tbn2.gstatic.com/licensed-image?q=tbn:ANd9GcQGSctI5RWvvo2rtNE1kXH6myPycCkC58qwfmMkW9yR5vyGvXH9m0k9D3yoS9e-0EklM53nNNn-HUoOTwUhMtoeDg", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTRpsWIiDkSQVeqkCQeOEonUl62dugDp-GTW9UhxEQdYgX1B5vtfF8e_OBnQA5_ZK9CzH8liV7sEPHyn6Xb-sgA3w", "https://encrypted-tbn2.gstatic.com/licensed-image?q=tbn:ANd9GcS5reC0YzLFNaes1RMpW-7h5Ee0zFAGHdCZJRf6O4ji3DtDNf9UpMU1QqOTc6XJllkhPDMBPMbNfR9xkFctPGu_XQ", 65000, "Nainital", "Nainital is famous for the Naini Lake. Some of the other places of tourist interest are the Mall, now known as the Govind Ballabh Pant Marg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FlightBooking_FlightId",
                table: "FlightBooking",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_PlaceId",
                table: "OrderDetails",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_shoppingCartItems_PlaceID",
                table: "shoppingCartItems",
                column: "PlaceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "FlightBooking");

            migrationBuilder.DropTable(
                name: "HotelMini");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "SearchFlights");

            migrationBuilder.DropTable(
                name: "shoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "place");
        }
    }
}
