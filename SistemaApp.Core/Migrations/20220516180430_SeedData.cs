using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaApp.Core.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Soft drinks, coffees, teas, beers, and ales", "Beverages" },
                    { 2, "Sweet and savory sauces, relishes, spreads, and seasonings", "Condiments" },
                    { 3, "Desserts, candies, and sweet breads", "Confections" },
                    { 4, "Cheeses", "Dairy Products" },
                    { 5, "Breads, crackers, pasta, and cereal", "Grains/Cereals" },
                    { 6, "Prepared meats", "Meat/Poultry" },
                    { 7, "Dried fruit and bean curd", "Produce" },
                    { 8, "Seaweed and fish", "Seafood" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "City", "ContactName", "Country", "CustomerName", "PostalCode" },
                values: new object[,]
                {
                    { 1, "Obere Str. 57", "Berlin", "Maria Anders", "Germany", "Alfreds Futterkiste", "12209" },
                    { 2, "Avda. de la Constitución 2222", "México D.F.", "Ana Trujillo", "Mexico", "Ana Trujillo Emparedados y helados", "05021" },
                    { 3, "Mataderos 2312", "México D.F.", "Antonio Moreno", "Mexico", "Antonio Moreno Taquería", "05023" },
                    { 4, "120 Hanover Sq.", "London", "Thomas Hardy", "UK", "Around the Horn", "WA1 1DP" },
                    { 5, "Berguvsvägen 8", "Luleå", "Christina Berglund", "Sweden", "Berglunds snabbköp", "S-958 22" },
                    { 6, "Forsterstr. 57", "Mannheim", "Hanna Moos", "Germany", "Blauer See Delikatessen", "68306" },
                    { 7, "24, place Kléber", "Strasbourg", "Frédérique Citeaux", "France", "Blondel père et fils", "67000" },
                    { 8, "C/ Araquil, 67", "Madrid", "Martín Sommer", "Spain", "Bólido Comidas preparadas", "28023" },
                    { 9, "12, rue des Bouchers", "Marseille", "Laurence Lebihans", "France", "Bon app'", "13008" },
                    { 10, "23 Tsawassen Blvd.", "Tsawassen", "Elizabeth Lincoln", "Canada", "Bottom-Dollar Marketse", "T2F 8M4" },
                    { 11, "Fauntleroy Circus", "London", "Victoria Ashworth", "UK", "B's Beverages", "EC2 5NT" },
                    { 12, "Cerrito 333", "Buenos Aires", "Patricio Simpson", "Argentina", "Cactus Comidas para llevar", "1010" },
                    { 13, "Sierras de Granada 9993", "México D.F.", "Francisco Chang", "Mexico", "Centro comercial Moctezuma", "05022" },
                    { 14, "Hauptstr. 29", "Bern", "Yang Wang", "Switzerland", "Chop-suey Chinese", "3012" },
                    { 15, "Av. dos Lusíadas, 23", "São Paulo", "Pedro Afonso", "Brazil", "Comércio Mineiro", "05432-043" },
                    { 16, "Berkeley Gardens 12 Brewery", "London", "Elizabeth Brown", "UK", "Consolidated Holdings", "WX1 6LT" },
                    { 17, "Walserweg 21", "Aachen", "Sven Ottlieb", "Germany", "Drachenblut Delikatessend", "52066" },
                    { 18, "67, rue des Cinquante Otages", "Nantes", "Janine Labrune", "France", "Du monde entier", "44000" },
                    { 19, "35 King George", "London", "Ann Devon", "UK", "Eastern Connection", "WX3 6FW" },
                    { 20, "Kirchgasse 6", "Graz", "Roland Mendel", "Austria", "Ernst Handel", "8010" },
                    { 21, "Rua Orós, 92", "São Paulo", "Aria Cruz", "Brazil", "Familia Arquibaldo", "05442-030" },
                    { 22, "C/ Moralzarzal, 86", "Madrid", "Diego Roel", "Spain", "FISSA Fabrica Inter. Salchichas S.A.", "28034" },
                    { 23, "184, chaussée de Tournai", "Lille", "Martine Rancé", "France", "Folies gourmandes", "59000" },
                    { 24, "Åkergatan 24", "Bräcke", "Maria Larsson", "Sweden", "Folk och fä HB", "S-844 67" },
                    { 25, "Berliner Platz 43", "München", "Peter Franken", "Germany", "Frankenversand", "80805" },
                    { 26, "54, rue Royale", "Nantes", "Carine Schmitt", "France", "France restauration", "44000" },
                    { 27, "Via Monte Bianco 34", "Torino", "Paolo Accorti", "Italy", "Franchi S.p.A.", "10100" },
                    { 28, "Jardim das rosas n. 32", "Lisboa", "Lino Rodriguez", "Portugal", "Furia Bacalhau e Frutos do Mar", "1675" },
                    { 29, "Rambla de Cataluña, 23", "Barcelona", "Eduardo Saavedra", "Spain", "Galería del gastrónomo", "08022" },
                    { 30, "C/ Romero, 33", "Sevilla", "José Pedro Freyre", "Spain", "Godos Cocina Típica", "41101" },
                    { 31, "Av. Brasil, 442", "Campinas", "André Fonseca", "Brazil", "Gourmet Lanchonetes", "04876-786" },
                    { 32, "2732 Baker Blvd.", "Eugene", "Howard Snyder", "USA", "Great Lakes Food Market", "97403" },
                    { 33, "5ª Ave. Los Palos Grandes", "Caracas", "Manuel Pereira", "Venezuela", "GROSELLA-Restaurante", "1081" },
                    { 34, "Rua do Paço, 67", "Rio de Janeiro", "Mario Pontes", "Brazil", "Hanari Carnes", "05454-876" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "City", "ContactName", "Country", "CustomerName", "PostalCode" },
                values: new object[,]
                {
                    { 35, "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Carlos Hernández", "Venezuela", "HILARIÓN-Abastos", "5022" },
                    { 36, "City Center Plaza 516 Main St.", "Elgin", "Yoshi Latimer", "USA", "Hungry Coyote Import Store", "97827" },
                    { 37, "8 Johnstown Road", "Cork", "Patricia McKenna", "Ireland", "Hungry Owl All-Night Grocers", "" },
                    { 38, "Garden House Crowther Way", "Cowes", "Helen Bennett", "UK", "Island Trading", "PO31 7PJ" },
                    { 39, "Maubelstr. 90", "Brandenburg", "Philip Cramer", "Germany", "Königlich Essen", "14776" },
                    { 40, "67, avenue de l'Europe", "Versailles", "Daniel Tonini", "France", "La corne d'abondance", "78000" },
                    { 41, "1 rue Alsace-Lorraine", "Toulouse", "Annette Roulet", "France", "La maison d'Asie", "31000" },
                    { 42, "1900 Oak St.", "Vancouver", "Yoshi Tannamuri", "Canada", "Laughing Bacchus Wine Cellars", "V3F 2K1" },
                    { 43, "12 Orchestra Terrace", "Walla Walla", "John Steel", "USA", "Lazy K Kountry Store", "99362" },
                    { 44, "Magazinweg 7", "Frankfurt a.M.", "Renate Messner", "Germany", "Lehmanns Marktstand", "60528" },
                    { 45, "87 Polk St. Suite 5", "San Francisco", "Jaime Yorres", "USA", "Let's Stop N Shop", "94117" },
                    { 46, "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Carlos González", "Venezuela", "LILA-Supermercado", "3508" },
                    { 47, "Ave. 5 de Mayo Porlamar", "I. de Margarita", "Felipe Izquierdo", "Venezuela", "LINO-Delicateses", "4980" },
                    { 48, "89 Chiaroscuro Rd.", "Portland", "Fran Wilson", "USA", "Lonesome Pine Restaurant", "97219" },
                    { 49, "Via Ludovico il Moro 22", "Bergamo", "Giovanni Rovelli", "Italy", "Magazzini Alimentari Riuniti", "24100" },
                    { 50, "Rue Joseph-Bens 532", "Bruxelles", "Catherine Dewey", "Belgium", "Maison Dewey", "B-1180" },
                    { 51, "43 rue St. Laurent", "Montréal", "Jean Fresnière", "Canada", "Mère Paillarde", "H1J 1C3" },
                    { 52, "Heerstr. 22", "Leipzig", "Alexander Feuer", "Germany", "Morgenstern Gesundkost", "04179" },
                    { 53, "South House 300 Queensbridge", "London", "Simon Crowther", "UK", "North/South", "SW7 1RZ" },
                    { 54, "Ing. Gustavo Moncada 8585 Piso 20-A", "Buenos Aires", "Yvonne Moncada", "Argentina", "Océano Atlántico Ltda.", "1010" },
                    { 55, "2743 Bering St.", "Anchorage", "Rene Phillips", "USA", "Old World Delicatessen", "99508" },
                    { 56, "Mehrheimerstr. 369", "Köln", "Henriette Pfalzheim", "Germany", "Ottilies Käseladen", "50739" },
                    { 57, "265, boulevard Charonne", "Paris", "Marie Bertrand", "France", "Paris spécialités", "75012" },
                    { 58, "Calle Dr. Jorge Cash 321", "México D.F.", "Guillermo Fernández", "Mexico", "Pericles Comidas clásicas", "05033" },
                    { 59, "Geislweg 14", "Salzburg", "Georg Pipps", "Austria", "Piccolo und mehr", "5020" },
                    { 60, "Estrada da saúde n. 58", "Lisboa", "Isabel de Castro", "Portugal", "Princesa Isabel Vinhoss", "1756" },
                    { 61, "Rua da Panificadora, 12", "Rio de Janeiro", "Bernardo Batista", "Brazil", "Que Delícia", "02389-673" },
                    { 62, "Alameda dos Canàrios, 891", "São Paulo", "Lúcia Carvalho", "Brazil", "Queen Cozinha", "05487-020" },
                    { 63, "Taucherstraße 10", "Cunewalde", "Horst Kloss", "Germany", "QUICK-Stop", "01307" },
                    { 64, "Av. del Libertador 900", "Buenos Aires", "Sergio Gutiérrez", "Argentina", "Rancho grande", "1010" },
                    { 65, "2817 Milton Dr.", "Albuquerque", "Paula Wilson", "USA", "Rattlesnake Canyon Grocery", "87110" },
                    { 66, "Strada Provinciale 124", "Reggio Emilia", "Maurizio Moroni", "Italy", "Reggiani Caseifici", "42100" },
                    { 67, "Av. Copacabana, 267", "Rio de Janeiro", "Janete Limeira", "Brazil", "Ricardo Adocicados", "02389-890" },
                    { 68, "Grenzacherweg 237", "Genève", "Michael Holz", "Switzerland", "Richter Supermarkt", "1203" },
                    { 69, "Gran Vía, 1", "Madrid", "Alejandra Camino", "Spain", "Romero y tomillo", "28001" },
                    { 70, "Erling Skakkes gate 78", "Stavern", "Jonas Bergulfsen", "Norway", "Santé Gourmet", "4110" },
                    { 71, "187 Suffolk Ln.", "Boise", "Jose Pavarotti", "USA", "Save-a-lot Markets", "83720" },
                    { 72, "90 Wadhurst Rd.", "London", "Hari Kumar", "UK", "Seven Seas Imports", "OX15 4NB" },
                    { 73, "Vinbæltet 34", "København", "Jytte Petersen", "Denmark", "Simons bistro", "1734" },
                    { 74, "25, rue Lauriston", "Paris", "Dominique Perrier", "France", "Spécialités du monde", "75016" },
                    { 75, "P.O. Box 555", "Lander", "Art Braunschweiger", "USA", "Split Rail Beer & Ale", "82520" },
                    { 76, "Boulevard Tirou, 255", "Charleroi", "Pascale Cartrain", "Belgium", "Suprêmes délices", "B-6000" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "City", "ContactName", "Country", "CustomerName", "PostalCode" },
                values: new object[,]
                {
                    { 77, "89 Jefferson Way Suite 2", "Portland", "Liz Nixon", "USA", "The Big Cheese", "97201" },
                    { 78, "55 Grizzly Peak Rd.", "Butte", "Liu Wong", "USA", "The Cracker Box", "59801" },
                    { 79, "Luisenstr. 48", "Münster", "Karin Josephs", "Germany", "Toms Spezialitäten", "44087" },
                    { 80, "Avda. Azteca 123", "México D.F.", "Miguel Angel Paolino", "Mexico", "Tortuga Restaurante", "05033" },
                    { 81, "Av. Inês de Castro, 414", "São Paulo", "Anabela Domingues", "Brazil", "Tradição Hipermercados", "05634-030" },
                    { 82, "722 DaVinci Blvd.", "Kirkland", "Helvetius Nagy", "USA", "Trail's Head Gourmet Provisioners", "98034" },
                    { 83, "Smagsløget 45", "Århus", "Palle Ibsen", "Denmark", "Vaffeljernet", "8200" },
                    { 84, "2, rue du Commerce", "Lyon", "Mary Saveley", "France", "Victuailles en stock", "69004" },
                    { 85, "59 rue de l'Abbaye", "Reims", "Paul Henriot", "France", "Vins et alcools Chevalier", "51100" },
                    { 86, "Adenauerallee 900", "Stuttgart", "Rita Müller", "Germany", "Die Wandernde Kuh", "70563" },
                    { 87, "Torikatu 38", "Oulu", "Pirkko Koskitalo", "Finland", "Wartian Herkku", "90110" },
                    { 88, "Rua do Mercado, 12", "Resende", "Paula Parente", "Brazil", "Wellington Importadora", "08737-363" },
                    { 89, "305 - 14th Ave. S. Suite 3B", "Seattle", "Karl Jablonski", "USA", "White Clover Markets", "98128" },
                    { 90, "Keskuskatu 45", "Helsinki", "Matti Karttunen", "Finland", "Wilman Kala", "21240" },
                    { 91, "ul. Filtrowa 68", "Walla", "Zbyszek", "Poland", "Wolski", "01-012" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BirthDate", "FirstName", "LastName", "Notes", "Photo" },
                values: new object[,]
                {
                    { 1, new DateTime(1968, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nancy", "Davolio", "Education includes a BA in psychology from Colorado State University. She also completed (The Art of the Cold Call). Nancy is a member of 'Toastmasters International'.", "EmpID1.pic" },
                    { 2, new DateTime(1952, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrew", "Fuller", "Andrew received his BTS commercial and a Ph.D. in international marketing from the University of Dallas. He is fluent in French and Italian and reads German. He joined the company as a sales representative, was promoted to sales manager and was then named vice president of sales. Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association.", "EmpID2.pic" },
                    { 3, new DateTime(1963, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janet", "Leverling", "Janet has a BS degree in chemistry from Boston College). She has also completed a certificate program in food retailing management. Janet was hired as a sales associate and was promoted to sales representative.", "EmpID3.pic" },
                    { 4, new DateTime(1958, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Margaret", "Peacock", "Margaret holds a BA in English literature from Concordia College and an MA from the American Institute of Culinary Arts. She was temporarily assigned to the London office before returning to her permanent post in Seattle.", "EmpID4.pic" },
                    { 5, new DateTime(1955, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven", "Buchanan", "Steven Buchanan graduated from St. Andrews University, Scotland, with a BSC degree. Upon joining the company as a sales representative, he spent 6 months in an orientation program at the Seattle office and then returned to his permanent post in London, where he was promoted to sales manager. Mr. Buchanan has completed the courses 'Successful Telemarketing' and 'International Sales Management'. He is fluent in French.", "EmpID5.pic" },
                    { 6, new DateTime(1963, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", "Suyama", "Michael is a graduate of Sussex University (MA, economics) and the University of California at Los Angeles (MBA, marketing). He has also taken the courses 'Multi-Cultural Selling' and 'Time Management for the Sales Professional'. He is fluent in Japanese and can read and write French, Portuguese, and Spanish.", "EmpID6.pic" },
                    { 7, new DateTime(1960, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert", "King", "Robert King served in the Peace Corps and traveled extensively before completing his degree in English at the University of Michigan and then joining the company. After completing a course entitled 'Selling in Europe', he was transferred to the London office.", "EmpID7.pic" },
                    { 8, new DateTime(1958, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura", "Callahan", "Laura received a BA in psychology from the University of Washington. She has also completed a course in business French. She reads and writes French.", "EmpID8.pic" },
                    { 9, new DateTime(1969, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anne", "Dodsworth", "Anne has a BA degree in English from St. Lawrence College. She is fluent in French and German.", "EmpID9.pic" },
                    { 10, new DateTime(1928, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam", "West", "An old chum.", "EmpID10.pic" }
                });

            migrationBuilder.InsertData(
                table: "Shippers",
                columns: new[] { "ShipperId", "ShipperName", "Phone" },
                values: new object[,]
                {
                    { 1, "Speedy Express", "(503) 555-9831" },
                    { 2, "United Package", "(503) 555-3199" },
                    { 3, "Federal Shipping", "(503) 555-9931" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "Address", "City", "ContactName", "Country", "SupplierName", "Phone", "PostalCode" },
                values: new object[,]
                {
                    { 1, "49 Gilbert St.", "Londona", "Charlotte Cooper", "UK", "Exotic Liquid", "(171) 555-2222", "EC1 4SD" },
                    { 2, "P.O. Box 78934", "New Orleans", "Shelley Burke", "USA", "New Orleans Cajun Delights", "(100) 555-4822", "70117" },
                    { 3, "707 Oxford Rd.", "Ann Arbor", "Regina Murphy", "USA", "Grandma Kelly's Homestead", "(313) 555-5735", "48104" },
                    { 4, "9-8 Sekimai Musashino-shi", "Tokyo", "Yoshi Nagase", "Japan", "Tokyo Traders", "(03) 3555-5011", "100" },
                    { 5, "Calle del Rosal 4", "Oviedo", "Antonio del Valle Saavedra", "Spain", "Cooperativa de Quesos 'Las Cabras'", "(98) 598 76 54", "33007" },
                    { 6, "92 Setsuko Chuo-ku", "Osaka", "Mayumi Ohno", "Japan", "Mayumi's", "(06) 431-7877", "545" },
                    { 7, "74 Rose St. Moonie Ponds", "Melbourne", "Ian Devling", "Australia", "Pavlova, Ltd.", "(03) 444-2343", "3058" },
                    { 8, "29 King's Way", "Manchester", "Peter Wilson", "UK", "Specialty Biscuits, Ltd.", "(161) 555-4448", "M14 GSD" },
                    { 9, "Kaloadagatan 13", "Göteborg", "Lars Peterson", "Sweden", "PB Knäckebröd AB", "031-987 65 43", "S-345 67" },
                    { 10, "Av. das Americanas 12.890", "São Paulo", "Carlos Diaz", "Brazil", "Refrescos Americanas LTDA", "(11) 555 4640", "5442" },
                    { 11, "Tiergartenstraße 5", "Berlin", "Petra Winkler", "Germany", "Heli Süßwaren GmbH & Co. KG", "(010) 9984510", "10785" },
                    { 12, "Bogenallee 51", "Frankfurt", "Martin Bein", "Germany", "Plutzer Lebensmittelgroßmärkte AG", "(069) 992755", "60439" },
                    { 13, "Frahmredder 112a", "Cuxhaven", "Sven Petersen", "Germany", "Nord-Ost-Fisch Handelsgesellschaft mbH", "(04721) 8713", "27478" },
                    { 14, "Viale Dante, 75", "Ravenna", "Elio Rossi", "Italy", "Formaggi Fortini s.r.l.", "(0544) 60323", "48100" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "Address", "City", "ContactName", "Country", "SupplierName", "Phone", "PostalCode" },
                values: new object[,]
                {
                    { 15, "Hatlevegen 5", "Sandvika", "Beate Vileid", "Norway", "Norske Meierier", "(0)2-953010", "1320" },
                    { 16, "3400 - 8th Avenue Suite 210", "Bend", "Cheryl Saylor", "USA", "Bigfoot Breweries", "(503) 555-9931", "97101" },
                    { 17, "Brovallavägen 231", "Stockholm", "Michael Björn", "Sweden", "Svensk Sjöföda AB", "08-123 45 67", "S-123 45" },
                    { 18, "203, Rue des Francs-Bourgeois", "Paris", "Guylène Nodier", "France", "Aux joyeux ecclésiastiques", "(1) 03.83.00.68", "75004" },
                    { 19, "Order Processing Dept. 2100 Paul Revere Blvd.", "Boston", "Robb Merchant", "USA", "New England Seafood Cannery", "(617) 555-3267", "02134" },
                    { 20, "471 Serangoon Loop, Suite #402", "Singapore", "Chandra Leka", "Singapore", "Leka Trading", "555-8787", "0512" },
                    { 21, "Lyngbysild Fiskebakken 10", "Lyngby", "Niels Petersen", "Denmark", "Lyngbysild", "43844108", "2800" },
                    { 22, "Verkoop Rijnweg 22", "Zaandam", "Dirk Luchte", "Netherlands", "Zaanse Snoepfabriek", "(12345) 1212", "9999 ZZ" },
                    { 23, "Valtakatu 12", "Lappeenranta", "Anne Heikkonen", "Finland", "Karkki Oy", "(953) 10956", "53120" },
                    { 24, "170 Prince Edward Parade Hunter's Hill", "Sydney", "Wendy Mackenzie", "Australia", "G'day, Mate", "(02) 555-5914", "2042" },
                    { 25, "2960 Rue St. Laurent", "Montréal", "Jean-Guy Lauzon", "Canada", "Ma Maison", "(514) 555-9022", "H1J 1C3" },
                    { 26, "Via dei Gelsomini, 153", "Salerno", "Giovanni Giudici", "Italy", "Pasta Buttini s.r.l.", "(089) 6547665", "84100" },
                    { 27, "22, rue H. Voiron", "Montceau", "Marie Delamare", "France", "Escargots Nouveaux", "85.57.00.07", "71300" },
                    { 28, "Bat. B 3, rue des Alpes", "Annecy", "Eliane Noz", "France", "Gai pâturage", "38.76.98.06", "74000" },
                    { 29, "148 rue Chasseur", "Ste-Hyacinthe", "Chantal Goulet", "Canada", "Forêts d'érables", "(514) 555-2955", "J2S 7S8" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "EmployeeId", "OrderDate", "ShipperId" },
                values: new object[,]
                {
                    { 10248, 90, 5, new DateTime(1996, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10249, 81, 6, new DateTime(1996, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10250, 34, 4, new DateTime(1996, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10251, 84, 3, new DateTime(1996, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10252, 76, 4, new DateTime(1996, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10253, 34, 3, new DateTime(1996, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10254, 14, 5, new DateTime(1996, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10255, 68, 9, new DateTime(1996, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10256, 88, 3, new DateTime(1996, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10257, 35, 4, new DateTime(1996, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10258, 20, 1, new DateTime(1996, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10259, 13, 4, new DateTime(1996, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10260, 55, 4, new DateTime(1996, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10261, 61, 4, new DateTime(1996, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10262, 65, 8, new DateTime(1996, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10263, 20, 9, new DateTime(1996, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10264, 24, 6, new DateTime(1996, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10265, 7, 2, new DateTime(1996, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10266, 87, 3, new DateTime(1996, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10267, 25, 4, new DateTime(1996, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10268, 33, 8, new DateTime(1996, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10269, 89, 5, new DateTime(1996, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10270, 87, 1, new DateTime(1996, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10271, 75, 6, new DateTime(1996, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10272, 65, 6, new DateTime(1996, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10273, 63, 3, new DateTime(1996, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10274, 85, 6, new DateTime(1996, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10275, 49, 1, new DateTime(1996, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10276, 80, 8, new DateTime(1996, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10277, 52, 2, new DateTime(1996, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10278, 5, 8, new DateTime(1996, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10279, 44, 8, new DateTime(1996, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10280, 5, 2, new DateTime(1996, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10281, 69, 4, new DateTime(1996, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10282, 69, 4, new DateTime(1996, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10283, 46, 3, new DateTime(1996, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10284, 44, 4, new DateTime(1996, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10285, 63, 1, new DateTime(1996, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10286, 63, 8, new DateTime(1996, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10287, 67, 8, new DateTime(1996, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10288, 66, 4, new DateTime(1996, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10289, 11, 7, new DateTime(1996, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "EmployeeId", "OrderDate", "ShipperId" },
                values: new object[,]
                {
                    { 10290, 15, 8, new DateTime(1996, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10291, 61, 6, new DateTime(1996, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10292, 81, 1, new DateTime(1996, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10293, 80, 1, new DateTime(1996, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10294, 65, 4, new DateTime(1996, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10295, 85, 2, new DateTime(1996, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10296, 46, 6, new DateTime(1996, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10297, 7, 5, new DateTime(1996, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10298, 37, 6, new DateTime(1996, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10299, 67, 4, new DateTime(1996, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10300, 49, 2, new DateTime(1996, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10301, 86, 8, new DateTime(1996, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10302, 76, 4, new DateTime(1996, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10303, 30, 7, new DateTime(1996, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10304, 80, 1, new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10305, 55, 8, new DateTime(1996, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10306, 69, 1, new DateTime(1996, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10307, 48, 2, new DateTime(1996, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10308, 2, 7, new DateTime(1996, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10309, 37, 3, new DateTime(1996, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10310, 77, 8, new DateTime(1996, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10311, 18, 1, new DateTime(1996, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10312, 86, 2, new DateTime(1996, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10313, 63, 2, new DateTime(1996, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10314, 65, 1, new DateTime(1996, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10315, 38, 4, new DateTime(1996, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10316, 65, 1, new DateTime(1996, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10317, 48, 6, new DateTime(1996, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10318, 38, 8, new DateTime(1996, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10319, 80, 7, new DateTime(1996, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10320, 87, 5, new DateTime(1996, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10321, 38, 3, new DateTime(1996, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10322, 58, 7, new DateTime(1996, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10323, 39, 4, new DateTime(1996, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10324, 71, 9, new DateTime(1996, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10325, 39, 1, new DateTime(1996, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10326, 8, 4, new DateTime(1996, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10327, 24, 2, new DateTime(1996, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10328, 28, 4, new DateTime(1996, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10329, 75, 4, new DateTime(1996, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10330, 46, 3, new DateTime(1996, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10331, 9, 9, new DateTime(1996, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "EmployeeId", "OrderDate", "ShipperId" },
                values: new object[,]
                {
                    { 10332, 51, 3, new DateTime(1996, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10333, 87, 5, new DateTime(1996, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10334, 84, 8, new DateTime(1996, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10335, 37, 7, new DateTime(1996, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10336, 60, 7, new DateTime(1996, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10337, 25, 4, new DateTime(1996, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10338, 55, 4, new DateTime(1996, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10339, 51, 2, new DateTime(1996, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10340, 9, 1, new DateTime(1996, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10341, 73, 7, new DateTime(1996, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10342, 25, 4, new DateTime(1996, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10343, 44, 4, new DateTime(1996, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10344, 89, 4, new DateTime(1996, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10345, 63, 2, new DateTime(1996, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10346, 65, 3, new DateTime(1996, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10347, 21, 4, new DateTime(1996, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10348, 86, 4, new DateTime(1996, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10349, 75, 7, new DateTime(1996, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10350, 41, 6, new DateTime(1996, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10351, 20, 1, new DateTime(1996, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10352, 28, 3, new DateTime(1996, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10353, 59, 7, new DateTime(1996, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10354, 58, 8, new DateTime(1996, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10355, 4, 6, new DateTime(1996, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10356, 86, 6, new DateTime(1996, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10357, 46, 1, new DateTime(1996, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10358, 41, 5, new DateTime(1996, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10359, 72, 5, new DateTime(1996, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10360, 7, 4, new DateTime(1996, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10361, 63, 1, new DateTime(1996, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10362, 9, 3, new DateTime(1996, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10363, 17, 4, new DateTime(1996, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10364, 19, 1, new DateTime(1996, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10365, 3, 3, new DateTime(1996, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10366, 29, 8, new DateTime(1996, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10367, 83, 7, new DateTime(1996, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10368, 20, 2, new DateTime(1996, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10369, 75, 8, new DateTime(1996, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10370, 14, 6, new DateTime(1996, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10371, 41, 1, new DateTime(1996, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10372, 62, 5, new DateTime(1996, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10373, 37, 4, new DateTime(1996, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "EmployeeId", "OrderDate", "ShipperId" },
                values: new object[,]
                {
                    { 10374, 91, 1, new DateTime(1996, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10375, 36, 3, new DateTime(1996, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10376, 51, 1, new DateTime(1996, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10377, 72, 1, new DateTime(1996, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10378, 24, 5, new DateTime(1996, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10379, 61, 2, new DateTime(1996, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10380, 37, 8, new DateTime(1996, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10381, 46, 3, new DateTime(1996, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10382, 20, 4, new DateTime(1996, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10383, 4, 8, new DateTime(1996, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10384, 5, 3, new DateTime(1996, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10385, 75, 1, new DateTime(1996, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10386, 21, 9, new DateTime(1996, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10387, 70, 1, new DateTime(1996, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10388, 72, 2, new DateTime(1996, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10389, 10, 4, new DateTime(1996, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10390, 20, 6, new DateTime(1996, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10391, 17, 3, new DateTime(1996, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10392, 59, 2, new DateTime(1996, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10393, 71, 1, new DateTime(1996, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10394, 36, 1, new DateTime(1996, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10395, 35, 6, new DateTime(1996, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10396, 25, 1, new DateTime(1996, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10397, 60, 5, new DateTime(1996, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10398, 71, 2, new DateTime(1996, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10399, 83, 8, new DateTime(1996, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10400, 19, 1, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10401, 65, 1, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10402, 20, 8, new DateTime(1997, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10403, 20, 4, new DateTime(1997, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10404, 49, 2, new DateTime(1997, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10405, 47, 1, new DateTime(1997, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10406, 62, 7, new DateTime(1997, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10407, 56, 2, new DateTime(1997, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10408, 23, 8, new DateTime(1997, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10409, 54, 3, new DateTime(1997, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10410, 10, 3, new DateTime(1997, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10411, 10, 9, new DateTime(1997, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10412, 87, 8, new DateTime(1997, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10413, 41, 3, new DateTime(1997, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10414, 21, 2, new DateTime(1997, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10415, 36, 3, new DateTime(1997, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "EmployeeId", "OrderDate", "ShipperId" },
                values: new object[,]
                {
                    { 10416, 87, 8, new DateTime(1997, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10417, 73, 4, new DateTime(1997, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10418, 63, 4, new DateTime(1997, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10419, 68, 4, new DateTime(1997, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10420, 88, 3, new DateTime(1997, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10421, 61, 8, new DateTime(1997, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10422, 27, 2, new DateTime(1997, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10423, 31, 6, new DateTime(1997, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10424, 51, 7, new DateTime(1997, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10425, 41, 6, new DateTime(1997, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10426, 29, 4, new DateTime(1997, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10427, 59, 4, new DateTime(1997, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10428, 66, 7, new DateTime(1997, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10429, 37, 3, new DateTime(1997, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10430, 20, 4, new DateTime(1997, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10431, 10, 4, new DateTime(1997, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10432, 75, 3, new DateTime(1997, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10433, 60, 3, new DateTime(1997, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10434, 24, 3, new DateTime(1997, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10435, 16, 8, new DateTime(1997, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10436, 7, 3, new DateTime(1997, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10437, 87, 8, new DateTime(1997, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10438, 79, 3, new DateTime(1997, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10439, 51, 6, new DateTime(1997, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10440, 71, 4, new DateTime(1997, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10441, 55, 3, new DateTime(1997, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10442, 20, 3, new DateTime(1997, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10443, 66, 8, new DateTime(1997, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Name", "Price", "SupplierId", "Unit" },
                values: new object[,]
                {
                    { 1, 1, "Chais", 18.0, 1, "10 boxes x 20 bags" },
                    { 2, 1, "Chang", 19.0, 1, "24 - 12 oz bottles" },
                    { 3, 2, "Aniseed Syrup", 10.0, 1, "12 - 550 ml bottles" },
                    { 4, 2, "Chef Anton's Cajun Seasoning", 22.0, 2, "48 - 6 oz jars" },
                    { 5, 2, "Chef Anton's Gumbo Mix", 21.350000000000001, 2, "36 boxes" },
                    { 6, 2, "Grandma's Boysenberry Spread", 25.0, 3, "12 - 8 oz jars" },
                    { 7, 7, "Uncle Bob's Organic Dried Pears", 30.0, 3, "12 - 1 lb pkgs." },
                    { 8, 2, "Northwoods Cranberry Sauce", 40.0, 3, "12 - 12 oz jars" },
                    { 9, 6, "Mishi Kobe Niku", 97.0, 4, "18 - 500 g pkgs." },
                    { 10, 8, "Ikura", 31.0, 4, "12 - 200 ml jars" },
                    { 11, 4, "Queso Cabrales", 21.0, 5, "1 kg pkg." },
                    { 12, 4, "Queso Manchego La Pastora", 38.0, 5, "10 - 500 g pkgs." },
                    { 13, 8, "Konbu", 6.0, 6, "2 kg box" },
                    { 14, 7, "Tofu", 23.25, 6, "40 - 100 g pkgs." }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Name", "Price", "SupplierId", "Unit" },
                values: new object[,]
                {
                    { 15, 2, "Genen Shouyu", 15.5, 6, "24 - 250 ml bottles" },
                    { 16, 3, "Pavlova", 17.449999999999999, 7, "32 - 500 g boxes" },
                    { 17, 6, "Alice Mutton", 39.0, 7, "20 - 1 kg tins" },
                    { 18, 8, "Carnarvon Tigers", 62.5, 7, "16 kg pkg." },
                    { 19, 3, "Teatime Chocolate Biscuits", 9.1999999999999993, 8, "10 boxes x 12 pieces" },
                    { 20, 3, "Sir Rodney's Marmalade", 81.0, 8, "30 gift boxes" },
                    { 21, 3, "Sir Rodney's Scones", 10.0, 8, "24 pkgs. x 4 pieces" },
                    { 22, 5, "Gustaf's Knäckebröd", 21.0, 9, "24 - 500 g pkgs." },
                    { 23, 5, "Tunnbröd", 9.0, 9, "12 - 250 g pkgs." },
                    { 24, 1, "Guaraná Fantástica", 4.5, 10, "12 - 355 ml cans" },
                    { 25, 3, "NuNuCa Nuß-Nougat-Creme", 14.0, 11, "20 - 450 g glasses" },
                    { 26, 3, "Gumbär Gummibärchen", 31.23, 11, "100 - 250 g bags" },
                    { 27, 3, "Schoggi Schokolade", 43.899999999999999, 11, "100 - 100 g pieces" },
                    { 28, 7, "Rössle Sauerkraut", 45.600000000000001, 12, "25 - 825 g cans" },
                    { 29, 6, "Thüringer Rostbratwurst", 123.79000000000001, 12, "50 bags x 30 sausgs." },
                    { 30, 8, "Nord-Ost Matjeshering", 25.890000000000001, 13, "10 - 200 g glasses" },
                    { 31, 4, "Gorgonzola Telino", 12.5, 14, "12 - 100 g pkgs" },
                    { 32, 4, "Mascarpone Fabioli", 32.0, 14, "24 - 200 g pkgs." },
                    { 33, 4, "Geitost", 2.5, 15, "500 g" },
                    { 34, 1, "Sasquatch Ale", 14.0, 16, "24 - 12 oz bottles" },
                    { 35, 1, "Steeleye Stout", 18.0, 16, "24 - 12 oz bottles" },
                    { 36, 8, "Inlagd Sill", 19.0, 17, "24 - 250 g jars" },
                    { 37, 8, "Gravad lax", 26.0, 17, "12 - 500 g pkgs." },
                    { 38, 1, "Côte de Blaye", 263.5, 18, "12 - 75 cl bottles" },
                    { 39, 1, "Chartreuse verte", 18.0, 18, "750 cc per bottle" },
                    { 40, 8, "Boston Crab Meat", 18.399999999999999, 19, "24 - 4 oz tins" },
                    { 41, 8, "Jack's New England Clam Chowder", 9.6500000000000004, 19, "12 - 12 oz cans" },
                    { 42, 5, "Singaporean Hokkien Fried Mee", 14.0, 20, "32 - 1 kg pkgs." },
                    { 43, 1, "Ipoh Coffee", 46.0, 20, "16 - 500 g tins" },
                    { 44, 2, "Gula Malacca", 19.449999999999999, 20, "20 - 2 kg bags" },
                    { 45, 8, "Røgede sild", 9.5, 21, "1k pkg." },
                    { 46, 8, "Spegesild", 12.0, 21, "4 - 450 g glasses" },
                    { 47, 3, "Zaanse koeken", 9.5, 22, "10 - 4 oz boxes" },
                    { 48, 3, "Chocolade", 12.75, 22, "10 pkgs." },
                    { 49, 3, "Maxilaku", 20.0, 23, "24 - 50 g pkgs." },
                    { 50, 3, "Valkoinen suklaa", 16.25, 23, "12 - 100 g bars" },
                    { 51, 7, "Manjimup Dried Apples", 53.0, 24, "50 - 300 g pkgs." },
                    { 52, 5, "Filo Mix", 7.0, 24, "16 - 2 kg boxes" },
                    { 53, 6, "Perth Pasties", 32.799999999999997, 24, "48 pieces" },
                    { 54, 6, "Tourtière", 7.4500000000000002, 25, "16 pies" },
                    { 55, 6, "Pâté chinois", 24.0, 25, "24 boxes x 2 pies" },
                    { 56, 5, "Gnocchi di nonna Alice", 38.0, 26, "24 - 250 g pkgs." }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Name", "Price", "SupplierId", "Unit" },
                values: new object[,]
                {
                    { 57, 5, "Ravioli Angelo", 19.5, 26, "24 - 250 g pkgs." },
                    { 58, 8, "Escargots de Bourgogne", 13.25, 27, "24 pieces" },
                    { 59, 4, "Raclette Courdavault", 55.0, 28, "5 kg pkg." },
                    { 60, 4, "Camembert Pierrot", 34.0, 28, "15 - 300 g rounds" },
                    { 61, 2, "Sirop d'érable", 28.5, 29, "24 - 500 ml bottles" },
                    { 62, 3, "Tarte au sucre", 49.299999999999997, 29, "48 pies" },
                    { 63, 2, "Vegie-spread", 43.899999999999999, 7, "15 - 625 g jars" },
                    { 64, 5, "Wimmers gute Semmelknödel", 33.25, 12, "20 bags x 4 pieces" },
                    { 65, 2, "Louisiana Fiery Hot Pepper Sauce", 21.050000000000001, 2, "32 - 8 oz bottles" },
                    { 66, 2, "Louisiana Hot Spiced Okra", 17.0, 2, "24 - 8 oz jars" },
                    { 67, 1, "Laughing Lumberjack Lager", 14.0, 16, "24 - 12 oz bottles" },
                    { 68, 3, "Scottish Longbreads", 12.5, 8, "10 boxes x 8 pieces" },
                    { 69, 4, "Gudbrandsdalsost", 36.0, 15, "10 kg pkg." },
                    { 70, 1, "Outback Lager", 15.0, 7, "24 - 355 ml bottles" },
                    { 71, 4, "Fløtemysost", 21.5, 15, "10 - 500 g pkgs." },
                    { 72, 4, "Mozzarella di Giovanni", 34.799999999999997, 14, "24 - 200 g pkgs." },
                    { 73, 8, "Röd Kaviar", 15.0, 17, "24 - 150 g jars" },
                    { 74, 7, "Longlife Tofu", 10.0, 4, "5 kg pkg." },
                    { 75, 1, "Rhönbräu Klosterbier", 7.75, 12, "24 - 0.5 l bottles" },
                    { 76, 1, "Lakkalikööri", 18.0, 23, "500 ml" },
                    { 77, 2, "Original Frankfurter grüne Soße", 13.0, 12, "12 boxes" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 10248, 11, 12 },
                    { 2, 10248, 42, 10 },
                    { 3, 10248, 72, 5 },
                    { 4, 10249, 14, 9 },
                    { 5, 10249, 51, 40 },
                    { 6, 10250, 41, 10 },
                    { 7, 10250, 51, 35 },
                    { 8, 10250, 65, 15 },
                    { 9, 10251, 22, 6 },
                    { 10, 10251, 57, 15 },
                    { 11, 10251, 65, 20 },
                    { 12, 10252, 20, 40 },
                    { 13, 10252, 33, 25 },
                    { 14, 10252, 60, 40 },
                    { 15, 10253, 31, 20 },
                    { 16, 10253, 39, 42 },
                    { 17, 10253, 49, 40 },
                    { 18, 10254, 24, 15 },
                    { 19, 10254, 55, 21 },
                    { 20, 10254, 74, 21 },
                    { 21, 10255, 2, 20 },
                    { 22, 10255, 16, 35 },
                    { 23, 10255, 36, 25 },
                    { 24, 10255, 59, 30 },
                    { 25, 10256, 53, 15 },
                    { 26, 10256, 77, 12 },
                    { 27, 10257, 27, 25 },
                    { 28, 10257, 39, 6 },
                    { 29, 10257, 77, 15 },
                    { 30, 10258, 2, 50 },
                    { 31, 10258, 5, 65 },
                    { 32, 10258, 32, 6 },
                    { 33, 10259, 21, 10 },
                    { 34, 10259, 37, 1 },
                    { 35, 10260, 41, 16 },
                    { 36, 10260, 57, 50 },
                    { 37, 10260, 62, 15 },
                    { 38, 10260, 70, 21 },
                    { 39, 10261, 21, 20 },
                    { 40, 10261, 35, 20 },
                    { 41, 10262, 5, 12 },
                    { 42, 10262, 7, 15 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 43, 10262, 56, 2 },
                    { 44, 10263, 16, 60 },
                    { 45, 10263, 24, 28 },
                    { 46, 10263, 30, 60 },
                    { 47, 10263, 74, 36 },
                    { 48, 10264, 2, 35 },
                    { 49, 10264, 41, 25 },
                    { 50, 10265, 17, 30 },
                    { 51, 10265, 70, 20 },
                    { 52, 10266, 12, 12 },
                    { 53, 10267, 40, 50 },
                    { 54, 10267, 59, 70 },
                    { 55, 10267, 76, 15 },
                    { 56, 10268, 29, 10 },
                    { 57, 10268, 72, 4 },
                    { 58, 10269, 33, 60 },
                    { 59, 10269, 72, 20 },
                    { 60, 10270, 36, 30 },
                    { 61, 10270, 43, 25 },
                    { 62, 10271, 33, 24 },
                    { 63, 10272, 20, 6 },
                    { 64, 10272, 31, 40 },
                    { 65, 10272, 72, 24 },
                    { 66, 10273, 10, 24 },
                    { 67, 10273, 31, 15 },
                    { 68, 10273, 33, 20 },
                    { 69, 10273, 40, 60 },
                    { 70, 10273, 76, 33 },
                    { 71, 10274, 71, 20 },
                    { 72, 10274, 72, 7 },
                    { 73, 10275, 24, 12 },
                    { 74, 10275, 59, 6 },
                    { 75, 10276, 10, 15 },
                    { 76, 10276, 13, 10 },
                    { 77, 10277, 28, 20 },
                    { 78, 10277, 62, 12 },
                    { 79, 10278, 44, 16 },
                    { 80, 10278, 59, 15 },
                    { 81, 10278, 63, 8 },
                    { 82, 10278, 73, 25 },
                    { 83, 10279, 17, 15 },
                    { 84, 10280, 24, 12 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 85, 10280, 55, 20 },
                    { 86, 10280, 75, 30 },
                    { 87, 10281, 19, 1 },
                    { 88, 10281, 24, 6 },
                    { 89, 10281, 35, 4 },
                    { 90, 10282, 30, 6 },
                    { 91, 10282, 57, 2 },
                    { 92, 10283, 15, 20 },
                    { 93, 10283, 19, 18 },
                    { 94, 10283, 60, 35 },
                    { 95, 10283, 72, 3 },
                    { 96, 10284, 27, 15 },
                    { 97, 10284, 44, 21 },
                    { 98, 10284, 60, 20 },
                    { 99, 10284, 67, 5 },
                    { 100, 10285, 1, 45 },
                    { 101, 10285, 40, 40 },
                    { 102, 10285, 53, 36 },
                    { 103, 10286, 35, 100 },
                    { 104, 10286, 62, 40 },
                    { 105, 10287, 16, 40 },
                    { 106, 10287, 34, 20 },
                    { 107, 10287, 46, 15 },
                    { 108, 10288, 54, 10 },
                    { 109, 10288, 68, 3 },
                    { 110, 10289, 3, 30 },
                    { 111, 10289, 64, 9 },
                    { 112, 10290, 5, 20 },
                    { 113, 10290, 29, 15 },
                    { 114, 10290, 49, 15 },
                    { 115, 10290, 77, 10 },
                    { 116, 10291, 13, 20 },
                    { 117, 10291, 44, 24 },
                    { 118, 10291, 51, 2 },
                    { 119, 10292, 20, 20 },
                    { 120, 10293, 18, 12 },
                    { 121, 10293, 24, 10 },
                    { 122, 10293, 63, 5 },
                    { 123, 10293, 75, 6 },
                    { 124, 10294, 1, 18 },
                    { 125, 10294, 17, 15 },
                    { 126, 10294, 43, 15 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 127, 10294, 60, 21 },
                    { 128, 10294, 75, 6 },
                    { 129, 10295, 56, 4 },
                    { 130, 10296, 11, 12 },
                    { 131, 10296, 16, 30 },
                    { 132, 10296, 69, 15 },
                    { 133, 10297, 39, 60 },
                    { 134, 10297, 72, 20 },
                    { 135, 10298, 2, 40 },
                    { 136, 10298, 36, 40 },
                    { 137, 10298, 59, 30 },
                    { 138, 10298, 62, 15 },
                    { 139, 10299, 19, 15 },
                    { 140, 10299, 70, 20 },
                    { 141, 10300, 66, 30 },
                    { 142, 10300, 68, 20 },
                    { 143, 10301, 40, 10 },
                    { 144, 10301, 56, 20 },
                    { 145, 10302, 17, 40 },
                    { 146, 10302, 28, 28 },
                    { 147, 10302, 43, 12 },
                    { 148, 10303, 40, 40 },
                    { 149, 10303, 65, 30 },
                    { 150, 10303, 68, 15 },
                    { 151, 10304, 49, 30 },
                    { 152, 10304, 59, 10 },
                    { 153, 10304, 71, 2 },
                    { 154, 10305, 18, 25 },
                    { 155, 10305, 29, 25 },
                    { 156, 10305, 39, 30 },
                    { 157, 10306, 30, 10 },
                    { 158, 10306, 53, 10 },
                    { 159, 10306, 54, 5 },
                    { 160, 10307, 62, 10 },
                    { 161, 10307, 68, 3 },
                    { 162, 10308, 69, 1 },
                    { 163, 10308, 70, 5 },
                    { 164, 10309, 4, 20 },
                    { 165, 10309, 6, 30 },
                    { 166, 10309, 42, 2 },
                    { 167, 10309, 43, 20 },
                    { 168, 10309, 71, 3 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 169, 10310, 16, 10 },
                    { 170, 10310, 62, 5 },
                    { 171, 10311, 42, 6 },
                    { 172, 10311, 69, 7 },
                    { 173, 10312, 28, 4 },
                    { 174, 10312, 43, 24 },
                    { 175, 10312, 53, 20 },
                    { 176, 10312, 75, 10 },
                    { 177, 10313, 36, 12 },
                    { 178, 10314, 32, 40 },
                    { 179, 10314, 58, 30 },
                    { 180, 10314, 62, 25 },
                    { 181, 10315, 34, 14 },
                    { 182, 10315, 70, 30 },
                    { 183, 10316, 41, 10 },
                    { 184, 10316, 62, 70 },
                    { 185, 10317, 1, 20 },
                    { 186, 10318, 41, 20 },
                    { 187, 10318, 76, 6 },
                    { 188, 10319, 17, 8 },
                    { 189, 10319, 28, 14 },
                    { 190, 10319, 76, 30 },
                    { 191, 10320, 71, 30 },
                    { 192, 10321, 35, 10 },
                    { 193, 10322, 52, 20 },
                    { 194, 10323, 15, 5 },
                    { 195, 10323, 25, 4 },
                    { 196, 10323, 39, 4 },
                    { 197, 10324, 16, 21 },
                    { 198, 10324, 35, 70 },
                    { 199, 10324, 46, 30 },
                    { 200, 10324, 59, 40 },
                    { 201, 10324, 63, 80 },
                    { 202, 10325, 6, 6 },
                    { 203, 10325, 13, 12 },
                    { 204, 10325, 14, 9 },
                    { 205, 10325, 31, 4 },
                    { 206, 10325, 72, 40 },
                    { 207, 10326, 4, 24 },
                    { 208, 10326, 57, 16 },
                    { 209, 10326, 75, 50 },
                    { 210, 10327, 2, 25 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 211, 10327, 11, 50 },
                    { 212, 10327, 30, 35 },
                    { 213, 10327, 58, 30 },
                    { 214, 10328, 59, 9 },
                    { 215, 10328, 65, 40 },
                    { 216, 10328, 68, 10 },
                    { 217, 10329, 19, 10 },
                    { 218, 10329, 30, 8 },
                    { 219, 10329, 38, 20 },
                    { 220, 10329, 56, 12 },
                    { 221, 10330, 26, 50 },
                    { 222, 10330, 72, 25 },
                    { 223, 10331, 54, 15 },
                    { 224, 10332, 18, 40 },
                    { 225, 10332, 42, 10 },
                    { 226, 10332, 47, 16 },
                    { 227, 10333, 14, 10 },
                    { 228, 10333, 21, 10 },
                    { 229, 10333, 71, 40 },
                    { 230, 10334, 52, 8 },
                    { 231, 10334, 68, 10 },
                    { 232, 10335, 2, 7 },
                    { 233, 10335, 31, 25 },
                    { 234, 10335, 32, 6 },
                    { 235, 10335, 51, 48 },
                    { 236, 10336, 4, 18 },
                    { 237, 10337, 23, 40 },
                    { 238, 10337, 26, 24 },
                    { 239, 10337, 36, 20 },
                    { 240, 10337, 37, 28 },
                    { 241, 10337, 72, 25 },
                    { 242, 10338, 17, 20 },
                    { 243, 10338, 30, 15 },
                    { 244, 10339, 4, 10 },
                    { 245, 10339, 17, 70 },
                    { 246, 10339, 62, 28 },
                    { 247, 10340, 18, 20 },
                    { 248, 10340, 41, 12 },
                    { 249, 10340, 43, 40 },
                    { 250, 10341, 33, 8 },
                    { 251, 10341, 59, 9 },
                    { 252, 10342, 2, 24 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 253, 10342, 31, 56 },
                    { 254, 10342, 36, 40 },
                    { 255, 10342, 55, 40 },
                    { 256, 10343, 64, 50 },
                    { 257, 10343, 68, 4 },
                    { 258, 10343, 76, 15 },
                    { 259, 10344, 4, 35 },
                    { 260, 10344, 8, 70 },
                    { 261, 10345, 8, 70 },
                    { 262, 10345, 19, 80 },
                    { 263, 10345, 42, 9 },
                    { 264, 10346, 17, 36 },
                    { 265, 10346, 56, 20 },
                    { 266, 10347, 25, 10 },
                    { 267, 10347, 39, 50 },
                    { 268, 10347, 40, 4 },
                    { 269, 10347, 75, 6 },
                    { 270, 10348, 1, 15 },
                    { 271, 10348, 23, 25 },
                    { 272, 10349, 54, 24 },
                    { 273, 10350, 50, 15 },
                    { 274, 10350, 69, 18 },
                    { 275, 10351, 38, 20 },
                    { 276, 10351, 41, 13 },
                    { 277, 10351, 44, 77 },
                    { 278, 10351, 65, 10 },
                    { 279, 10352, 24, 10 },
                    { 280, 10352, 54, 20 },
                    { 281, 10353, 11, 12 },
                    { 282, 10353, 38, 50 },
                    { 283, 10354, 1, 12 },
                    { 284, 10354, 29, 4 },
                    { 285, 10355, 24, 25 },
                    { 286, 10355, 57, 25 },
                    { 287, 10356, 31, 30 },
                    { 288, 10356, 55, 12 },
                    { 289, 10356, 69, 20 },
                    { 290, 10357, 10, 30 },
                    { 291, 10357, 26, 16 },
                    { 292, 10357, 60, 8 },
                    { 293, 10358, 24, 10 },
                    { 294, 10358, 34, 10 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 295, 10358, 36, 20 },
                    { 296, 10359, 16, 56 },
                    { 297, 10359, 31, 70 },
                    { 298, 10359, 60, 80 },
                    { 299, 10360, 28, 30 },
                    { 300, 10360, 29, 35 },
                    { 301, 10360, 38, 10 },
                    { 302, 10360, 49, 35 },
                    { 303, 10360, 54, 28 },
                    { 304, 10361, 39, 54 },
                    { 305, 10361, 60, 55 },
                    { 306, 10362, 25, 50 },
                    { 307, 10362, 51, 20 },
                    { 308, 10362, 54, 24 },
                    { 309, 10363, 31, 20 },
                    { 310, 10363, 75, 12 },
                    { 311, 10363, 76, 12 },
                    { 312, 10364, 69, 30 },
                    { 313, 10364, 71, 5 },
                    { 314, 10365, 11, 24 },
                    { 315, 10366, 65, 5 },
                    { 316, 10366, 77, 5 },
                    { 317, 10367, 34, 36 },
                    { 318, 10367, 54, 18 },
                    { 319, 10367, 65, 15 },
                    { 320, 10367, 77, 7 },
                    { 321, 10368, 21, 5 },
                    { 322, 10368, 28, 13 },
                    { 323, 10368, 57, 25 },
                    { 324, 10368, 64, 35 },
                    { 325, 10369, 29, 20 },
                    { 326, 10369, 56, 18 },
                    { 327, 10370, 1, 15 },
                    { 328, 10370, 64, 30 },
                    { 329, 10370, 74, 20 },
                    { 330, 10371, 36, 6 },
                    { 331, 10372, 20, 12 },
                    { 332, 10372, 38, 40 },
                    { 333, 10372, 60, 70 },
                    { 334, 10372, 72, 42 },
                    { 335, 10373, 58, 80 },
                    { 336, 10373, 71, 50 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 337, 10374, 31, 30 },
                    { 338, 10374, 58, 15 },
                    { 339, 10375, 14, 15 },
                    { 340, 10375, 54, 10 },
                    { 341, 10376, 31, 42 },
                    { 342, 10377, 28, 20 },
                    { 343, 10377, 39, 20 },
                    { 344, 10378, 71, 6 },
                    { 345, 10379, 41, 8 },
                    { 346, 10379, 63, 16 },
                    { 347, 10379, 65, 20 },
                    { 348, 10380, 30, 18 },
                    { 349, 10380, 53, 20 },
                    { 350, 10380, 60, 6 },
                    { 351, 10380, 70, 30 },
                    { 352, 10381, 74, 14 },
                    { 353, 10382, 5, 32 },
                    { 354, 10382, 18, 9 },
                    { 355, 10382, 29, 14 },
                    { 356, 10382, 33, 60 },
                    { 357, 10382, 74, 50 },
                    { 358, 10383, 13, 20 },
                    { 359, 10383, 50, 15 },
                    { 360, 10383, 56, 20 },
                    { 361, 10384, 20, 28 },
                    { 362, 10384, 60, 15 },
                    { 363, 10385, 7, 10 },
                    { 364, 10385, 60, 20 },
                    { 365, 10385, 68, 8 },
                    { 366, 10386, 24, 15 },
                    { 367, 10386, 34, 10 },
                    { 368, 10387, 24, 15 },
                    { 369, 10387, 28, 6 },
                    { 370, 10387, 59, 12 },
                    { 371, 10387, 71, 15 },
                    { 372, 10388, 45, 15 },
                    { 373, 10388, 52, 20 },
                    { 374, 10388, 53, 40 },
                    { 375, 10389, 10, 16 },
                    { 376, 10389, 55, 15 },
                    { 377, 10389, 62, 20 },
                    { 378, 10389, 70, 30 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 379, 10390, 31, 60 },
                    { 380, 10390, 35, 40 },
                    { 381, 10390, 46, 45 },
                    { 382, 10390, 72, 24 },
                    { 383, 10391, 13, 18 },
                    { 384, 10392, 69, 50 },
                    { 385, 10393, 2, 25 },
                    { 386, 10393, 14, 42 },
                    { 387, 10393, 25, 7 },
                    { 388, 10393, 26, 70 },
                    { 389, 10393, 31, 32 },
                    { 390, 10394, 13, 10 },
                    { 391, 10394, 62, 10 },
                    { 392, 10395, 46, 28 },
                    { 393, 10395, 53, 70 },
                    { 394, 10395, 69, 8 },
                    { 395, 10396, 23, 40 },
                    { 396, 10396, 71, 60 },
                    { 397, 10396, 72, 21 },
                    { 398, 10397, 21, 10 },
                    { 399, 10397, 51, 18 },
                    { 400, 10398, 35, 30 },
                    { 401, 10398, 55, 120 },
                    { 402, 10399, 68, 60 },
                    { 403, 10399, 71, 30 },
                    { 404, 10399, 76, 35 },
                    { 405, 10399, 77, 14 },
                    { 406, 10400, 29, 21 },
                    { 407, 10400, 35, 35 },
                    { 408, 10400, 49, 30 },
                    { 409, 10401, 30, 18 },
                    { 410, 10401, 56, 70 },
                    { 411, 10401, 65, 20 },
                    { 412, 10401, 71, 60 },
                    { 413, 10402, 23, 60 },
                    { 414, 10402, 63, 65 },
                    { 415, 10403, 16, 21 },
                    { 416, 10403, 48, 70 },
                    { 417, 10404, 26, 30 },
                    { 418, 10404, 42, 40 },
                    { 419, 10404, 49, 30 },
                    { 420, 10405, 3, 50 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 421, 10406, 1, 10 },
                    { 422, 10406, 21, 30 },
                    { 423, 10406, 28, 42 },
                    { 424, 10406, 36, 5 },
                    { 425, 10406, 40, 2 },
                    { 426, 10407, 11, 30 },
                    { 427, 10407, 69, 15 },
                    { 428, 10407, 71, 15 },
                    { 429, 10408, 37, 10 },
                    { 430, 10408, 54, 6 },
                    { 431, 10408, 62, 35 },
                    { 432, 10409, 14, 12 },
                    { 433, 10409, 21, 12 },
                    { 434, 10410, 33, 49 },
                    { 435, 10410, 59, 16 },
                    { 436, 10411, 41, 25 },
                    { 437, 10411, 44, 40 },
                    { 438, 10411, 59, 9 },
                    { 439, 10412, 14, 20 },
                    { 440, 10413, 1, 24 },
                    { 441, 10413, 62, 40 },
                    { 442, 10413, 76, 14 },
                    { 443, 10414, 19, 18 },
                    { 444, 10414, 33, 50 },
                    { 445, 10415, 17, 2 },
                    { 446, 10415, 33, 20 },
                    { 447, 10416, 19, 20 },
                    { 448, 10416, 53, 10 },
                    { 449, 10416, 57, 20 },
                    { 450, 10417, 38, 50 },
                    { 451, 10417, 46, 2 },
                    { 452, 10417, 68, 36 },
                    { 453, 10417, 77, 35 },
                    { 454, 10418, 2, 60 },
                    { 455, 10418, 47, 55 },
                    { 456, 10418, 61, 16 },
                    { 457, 10418, 74, 15 },
                    { 458, 10419, 60, 60 },
                    { 459, 10419, 69, 20 },
                    { 460, 10420, 9, 20 },
                    { 461, 10420, 13, 2 },
                    { 462, 10420, 70, 8 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 463, 10420, 73, 20 },
                    { 464, 10421, 19, 4 },
                    { 465, 10421, 26, 30 },
                    { 466, 10421, 53, 15 },
                    { 467, 10421, 77, 10 },
                    { 468, 10422, 26, 2 },
                    { 469, 10423, 31, 14 },
                    { 470, 10423, 59, 20 },
                    { 471, 10424, 35, 60 },
                    { 472, 10424, 38, 49 },
                    { 473, 10424, 68, 30 },
                    { 474, 10425, 55, 10 },
                    { 475, 10425, 76, 20 },
                    { 476, 10426, 56, 5 },
                    { 477, 10426, 64, 7 },
                    { 478, 10427, 14, 35 },
                    { 479, 10428, 46, 20 },
                    { 480, 10429, 50, 40 },
                    { 481, 10429, 63, 35 },
                    { 482, 10430, 17, 45 },
                    { 483, 10430, 21, 50 },
                    { 484, 10430, 56, 30 },
                    { 485, 10430, 59, 70 },
                    { 486, 10431, 17, 50 },
                    { 487, 10431, 40, 50 },
                    { 488, 10431, 47, 30 },
                    { 489, 10432, 26, 10 },
                    { 490, 10432, 54, 40 },
                    { 491, 10433, 56, 28 },
                    { 492, 10434, 11, 6 },
                    { 493, 10434, 76, 18 },
                    { 494, 10435, 2, 10 },
                    { 495, 10435, 22, 12 },
                    { 496, 10435, 72, 10 },
                    { 497, 10436, 46, 5 },
                    { 498, 10436, 56, 40 },
                    { 499, 10436, 64, 30 },
                    { 500, 10436, 75, 24 },
                    { 501, 10437, 53, 15 },
                    { 502, 10438, 19, 15 },
                    { 503, 10438, 34, 20 },
                    { 504, 10438, 57, 15 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 505, 10439, 12, 15 },
                    { 506, 10439, 16, 16 },
                    { 507, 10439, 64, 6 },
                    { 508, 10439, 74, 30 },
                    { 509, 10440, 2, 45 },
                    { 510, 10440, 16, 49 },
                    { 511, 10440, 29, 24 },
                    { 512, 10440, 61, 90 },
                    { 513, 10441, 27, 50 },
                    { 514, 10442, 11, 30 },
                    { 515, 10442, 54, 80 },
                    { 516, 10442, 66, 60 },
                    { 517, 10443, 11, 6 },
                    { 518, 10443, 28, 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10248);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10249);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10250);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10251);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10252);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10253);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10254);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10255);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10256);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10257);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10258);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10259);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10260);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10261);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10262);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10263);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10264);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10265);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10266);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10267);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10268);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10269);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10270);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10271);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10272);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10273);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10274);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10275);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10276);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10277);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10278);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10279);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10280);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10281);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10282);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10283);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10284);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10285);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10286);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10287);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10288);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10289);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10290);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10291);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10292);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10293);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10294);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10295);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10296);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10297);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10298);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10299);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10300);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10301);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10302);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10303);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10304);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10305);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10306);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10307);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10308);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10309);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10310);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10311);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10312);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10313);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10314);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10315);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10316);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10317);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10318);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10319);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10320);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10321);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10322);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10323);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10324);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10325);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10326);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10327);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10328);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10329);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10330);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10331);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10332);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10333);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10334);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10335);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10336);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10337);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10338);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10339);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10340);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10341);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10342);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10343);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10344);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10345);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10346);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10347);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10348);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10349);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10350);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10351);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10352);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10353);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10354);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10355);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10356);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10357);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10358);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10359);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10360);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10361);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10362);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10363);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10364);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10365);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10366);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10367);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10368);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10369);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10370);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10371);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10372);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10373);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10374);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10375);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10376);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10377);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10378);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10379);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10380);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10381);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10382);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10383);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10384);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10385);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10386);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10387);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10388);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10389);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10390);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10391);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10392);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10393);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10394);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10395);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10396);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10397);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10398);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10399);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10400);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10401);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10402);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10403);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10404);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10405);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10406);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10407);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10408);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10409);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10410);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10411);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10412);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10413);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10414);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10415);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10416);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10417);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10418);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10419);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10420);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10421);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10422);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10423);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10424);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10425);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10426);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10427);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10428);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10429);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10430);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10431);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10432);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10433);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10434);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10435);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10436);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10437);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10438);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10439);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10440);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10441);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10442);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10443);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Shippers",
                keyColumn: "ShipperId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shippers",
                keyColumn: "ShipperId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shippers",
                keyColumn: "ShipperId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: 29);
        }
    }
}
