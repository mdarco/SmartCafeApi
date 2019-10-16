using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartCafe.Postgres.Migrations
{
    public partial class initialseedproductsproductsubcategoriesorders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "allergens", "description", "is_promo", "is_recommended", "name", "price_with_vat" },
                values: new object[,]
                {
                    { new[] { "kikiriki", "badem" }, "Uganda", false, false, "Sleek Wooden Chips", 872.886938449408000m },
                    { new[] { "kikiriki" }, "navigate Syrian Arab Republic didactic", false, false, "Rustic Soft Shoes", 187.480656051766000m },
                    { new[] { "kikiriki" }, "proactive", false, false, "Gorgeous Granite Bacon", 189.642953309064000m },
                    { new[] { "kikiriki" }, "Home Loan Account", true, true, "Handmade Frozen Ball", 394.019497741954000m },
                    { new[] { "kikiriki" }, "Enterprise-wide", false, false, "Incredible Wooden Shoes", 348.602111147997000m },
                    { new[] { "kikiriki" }, "reintermediate methodologies Intranet", false, false, "Rustic Wooden Pizza", 219.020170727288000m },
                    { new[] { "badem" }, "withdrawal", false, false, "Fantastic Fresh Shirt", 29.7425314922549000m },
                    { new[] { "badem" }, "Plastic magenta", true, true, "Rustic Plastic Fish", 761.231554095276000m },
                    { new[] { "kikiriki", "badem" }, "Gorgeous Granite Towels withdrawal", true, false, "Practical Frozen Chair", 423.95240274442000m },
                    { new[] { "kikiriki" }, "teal", false, true, "Tasty Fresh Chicken", 126.783077664107000m },
                    { new[] { "kikiriki" }, "Response Borders quantify", true, true, "Sleek Fresh Shirt", 217.586628728354000m },
                    { new[] { "badem" }, "program payment", false, true, "Unbranded Frozen Pizza", 676.874955965614000m },
                    { new[] { "lešnik", "badem" }, "Awesome Kenyan Shilling", true, true, "Small Concrete Bacon", 661.15647911148000m },
                    { new[] { "kikiriki" }, "Factors", false, false, "Fantastic Concrete Chicken", 665.092521656813000m },
                    { new[] { "lešnik", "badem" }, "Ergonomic Plastic Soap Extensions RSS", true, false, "Incredible Metal Fish", 568.300987392804000m },
                    { new[] { "kikiriki" }, "Fantastic Concrete Cheese next-generation", false, false, "Generic Concrete Hat", 6.25116704322918000m },
                    { new[] { "lešnik", "badem" }, "motivating recontextualize", true, true, "Practical Steel Cheese", 49.2896992011413000m },
                    { new[] { "kikiriki" }, "info-mediaries", true, false, "Handmade Granite Hat", 321.549113058275000m },
                    { new[] { "kikiriki", "badem" }, "Licensed Metal Mouse back-end", false, false, "Fantastic Frozen Soap", 97.645391289911000m },
                    { new[] { "badem" }, "Soft", true, true, "Awesome Plastic Fish", 66.3635079126635000m },
                    { new[] { "kikiriki", "badem" }, "reboot", true, true, "Handcrafted Rubber Shirt", 650.998427370097000m },
                    { new[] { "lešnik", "badem" }, "lavender", false, false, "Unbranded Rubber Fish", 543.515426359845000m },
                    { new[] { "kikiriki", "badem" }, "Palau Unbranded Frozen Shoes", true, false, "Incredible Steel Bacon", 210.448388573922000m },
                    { new[] { "kikiriki", "lešnik" }, "Ports auxiliary", true, true, "Handmade Granite Cheese", 889.344430011392000m },
                    { new[] { "kikiriki" }, "purple", false, false, "Ergonomic Fresh Mouse", 846.641520898156000m },
                    { new[] { "badem", "lešnik" }, "Rubber", true, false, "Licensed Rubber Chair", 571.813557563263000m },
                    { new[] { "kikiriki" }, "CFA Franc BEAC Baby RAM", true, false, "Intelligent Metal Ball", 676.162297686638000m },
                    { new[] { "lešnik", "kikiriki" }, "implementation navigate", false, true, "Small Rubber Pizza", 337.297884904453000m },
                    { new[] { "kikiriki" }, "Cambridgeshire product", false, false, "Intelligent Rubber Keyboard", 600.183340534653000m },
                    { new[] { "kikiriki", "badem" }, "orange", true, true, "Intelligent Wooden Mouse", 95.9425662159652000m },
                    { new[] { "lešnik", "badem" }, "indexing Advanced", true, true, "Refined Wooden Pants", 448.965895664397000m },
                    { new[] { "kikiriki" }, "Cambridgeshire Lights Fantastic", true, true, "Sleek Fresh Salad", 110.445494814983000m },
                    { new[] { "lešnik" }, "Neck", false, true, "Unbranded Concrete Bike", 781.895902371917000m },
                    { new[] { "kikiriki" }, "program", false, false, "Handcrafted Wooden Chips", 647.891857497344000m },
                    { new[] { "kikiriki" }, "Burgs Gabon", true, true, "Licensed Granite Pants", 6.58137165316444000m },
                    { new[] { "lešnik" }, "Hryvnia IB", true, true, "Incredible Granite Table", 584.343535632055000m },
                    { new[] { "lešnik" }, "B2C neural scale", false, true, "Generic Metal Chips", 974.09946982474000m },
                    { new[] { "kikiriki", "lešnik" }, "New Leu withdrawal azure", false, true, "Practical Rubber Tuna", 432.989868537052000m },
                    { new[] { "kikiriki" }, "input", true, false, "Licensed Steel Shirt", 618.646073908846000m },
                    { new[] { "kikiriki", "lešnik" }, "Cameroon Granite De-engineered", false, true, "Rustic Metal Pants", 90.7269143921914000m },
                    { new[] { "badem", "kikiriki" }, "Soft Markets Vista", false, false, "Practical Granite Car", 970.693345167997000m },
                    { new[] { "badem", "lešnik" }, "plum Buckinghamshire data-warehouse", true, false, "Handcrafted Plastic Mouse", 972.452411415266000m },
                    { new[] { "kikiriki" }, "Oklahoma Refined Steel Mouse", true, true, "Ergonomic Metal Pizza", 643.150511031575000m },
                    { new[] { "badem", "lešnik" }, "circuit TCP", true, false, "Small Concrete Sausages", 294.590179014294000m },
                    { new[] { "kikiriki" }, "Bridge", true, true, "Gorgeous Granite Pizza", 193.488714840956000m },
                    { new[] { "kikiriki" }, "Future Seychelles Rupee", false, false, "Handcrafted Frozen Soap", 836.342681588764000m },
                    { new[] { "kikiriki" }, "compressing", false, false, "Gorgeous Frozen Chicken", 255.524669892865000m },
                    { new[] { "kikiriki" }, "open architecture indigo deposit", false, true, "Unbranded Wooden Chips", 399.6312350033000m },
                    { new[] { "lešnik", "badem" }, "Rubber Frozen", false, true, "Incredible Concrete Tuna", 769.229780309475000m },
                    { new[] { "kikiriki" }, "optimal deposit productize", false, false, "Fantastic Rubber Mouse", 406.595196764262000m },
                    { new[] { "badem" }, "hardware Grocery, Kids & Kids open system", true, true, "Generic Metal Bacon", 56.14416350431000m },
                    { new[] { "kikiriki" }, "Afghani", false, true, "Incredible Rubber Pants", 214.756028361039000m },
                    { new[] { "kikiriki" }, "JSON B2B Gabon", true, true, "Tasty Wooden Bike", 850.589542580112000m },
                    { new[] { "lešnik", "kikiriki" }, "Generic Concrete Car", true, false, "Tasty Granite Bike", 281.236750204692000m },
                    { new[] { "kikiriki", "lešnik" }, "Island user-facing", true, false, "Awesome Steel Computer", 304.346460990769000m },
                    { new[] { "lešnik", "badem" }, "revolutionize Tasty Fresh Computer", false, false, "Ergonomic Cotton Bacon", 492.056267099481000m },
                    { new[] { "lešnik" }, "parallelism withdrawal Investment Account", true, true, "Licensed Wooden Computer", 616.20575683946000m },
                    { new[] { "badem" }, "Home & Grocery quantify", true, true, "Tasty Concrete Salad", 264.694413759138000m },
                    { new[] { "kikiriki" }, "invoice", true, false, "Tasty Steel Shirt", 577.785702225652000m },
                    { new[] { "kikiriki" }, "system Engineer", false, false, "Tasty Granite Shirt", 409.624190726142000m },
                    { new[] { "kikiriki" }, "silver", true, true, "Sleek Rubber Shoes", 843.492578176545000m },
                    { new[] { "kikiriki" }, "Automotive & Electronics Montenegro", false, true, "Gorgeous Fresh Fish", 81.1766703059788000m },
                    { new[] { "kikiriki" }, "Rubber Gibraltar Pound Idaho", false, false, "Practical Steel Chair", 701.875798265392000m },
                    { new[] { "kikiriki", "badem" }, "eco-centric magenta", true, false, "Fantastic Wooden Tuna", 488.334485557086000m },
                    { new[] { "badem" }, "quantifying capacity", true, true, "Refined Wooden Chips", 573.87665546214000m },
                    { new[] { "kikiriki" }, "Bedfordshire", false, true, "Handmade Wooden Hat", 270.584369204279000m },
                    { new[] { "kikiriki" }, "innovative Garden, Baby & Games", false, true, "Refined Cotton Shirt", 842.125500013179000m },
                    { new[] { "kikiriki" }, "Gardens quantifying Awesome", false, false, "Sleek Steel Salad", 814.439348790068000m },
                    { new[] { "kikiriki" }, "Group", true, true, "Awesome Wooden Soap", 748.153017716554000m },
                    { new[] { "lešnik" }, "Director Fantastic Frozen Fish", true, false, "Sleek Plastic Salad", 569.547917027747000m },
                    { new[] { "badem" }, "Accountability synthesizing", false, false, "Sleek Steel Chicken", 23.7438702135085000m },
                    { new[] { "lešnik", "badem" }, "Rubber", true, true, "Sleek Steel Soap", 906.031973150574000m },
                    { new[] { "kikiriki" }, "Refined", false, false, "Sleek Concrete Bike", 442.433614489824000m },
                    { new[] { "badem" }, "Fantastic Metal Computer Tennessee Money Market Account", false, true, "Intelligent Cotton Gloves", 218.016418729916000m },
                    { new[] { "kikiriki", "lešnik" }, "Forks black Clothing, Electronics & Grocery", true, false, "Handmade Metal Bike", 822.884162339794000m },
                    { new[] { "lešnik" }, "Concrete Graphic Interface Handcrafted", true, false, "Practical Steel Hat", 482.267384176267000m },
                    { new[] { "kikiriki", "badem" }, "New York", false, true, "Rustic Rubber Towels", 152.305598907315000m },
                    { new[] { "kikiriki" }, "SSL Planner", false, false, "Intelligent Concrete Pants", 726.1748633935000m },
                    { new[] { "kikiriki", "badem" }, "COM", true, true, "Handmade Fresh Bacon", 934.573860342882000m },
                    { new[] { "badem", "lešnik" }, "HTTP", true, false, "Awesome Plastic Chips", 624.972580291784000m },
                    { new[] { "lešnik" }, "Innovative", false, false, "Fantastic Concrete Computer", 249.300500494102000m },
                    { new[] { "kikiriki" }, "Dominican Peso", false, false, "Rustic Metal Soap", 472.953015692976000m },
                    { new[] { "kikiriki" }, "Practical Granite Fish connect uniform", true, true, "Handmade Wooden Chair", 389.165290812573000m },
                    { new[] { "kikiriki" }, "Exclusive", true, true, "Tasty Steel Gloves", 763.144644332651000m },
                    { new[] { "kikiriki" }, "Taka", false, false, "Handcrafted Fresh Pants", 26.207264524981000m },
                    { new[] { "kikiriki" }, "Dynamic Niue Tunnel", true, false, "Practical Soft Soap", 480.837147906812000m },
                    { new[] { "kikiriki", "badem" }, "content cultivate interface", true, false, "Handcrafted Rubber Keyboard", 90.0823469693225000m },
                    { new[] { "lešnik", "badem" }, "Games, Grocery & Electronics THX", true, true, "Licensed Frozen Tuna", 396.157105637787000m },
                    { new[] { "kikiriki" }, "Personal Loan Account Buckinghamshire portals", false, true, "Fantastic Concrete Pants", 255.923392835969000m },
                    { new[] { "kikiriki" }, "Row Bedfordshire redundant", true, true, "Practical Concrete Bacon", 442.507116330092000m },
                    { new[] { "lešnik" }, "Buckinghamshire", false, true, "Handcrafted Concrete Ball", 688.078402396328000m },
                    { new[] { "kikiriki", "badem" }, "Corners Officer payment", false, false, "Practical Concrete Soap", 111.779141291873000m },
                    { new[] { "kikiriki", "badem" }, "expedite", true, true, "Rustic Rubber Table", 118.774066268827000m },
                    { new[] { "lešnik" }, "portals Tonga invoice", true, true, "Practical Fresh Tuna", 784.678290497828000m },
                    { new[] { "lešnik" }, "Kentucky EXE", false, false, "Rustic Rubber Car", 455.612551633088000m },
                    { new[] { "badem", "lešnik" }, "Music & Home Grocery, Books & Home", true, false, "Refined Granite Shirt", 558.104182387751000m },
                    { new[] { "kikiriki", "badem" }, "Gorgeous Wooden Mouse panel", false, false, "Incredible Steel Car", 499.056815402143000m },
                    { new[] { "lešnik" }, "Games, Clothing & Movies Sleek Concrete Towels", false, false, "Rustic Steel Fish", 934.879282924756000m },
                    { new[] { "kikiriki" }, "deploy", true, true, "Intelligent Metal Soap", 841.82738505389000m },
                    { new[] { "lešnik", "badem" }, "override hacking", false, false, "Unbranded Concrete Towels", 416.049195647263000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 100);
        }
    }
}
