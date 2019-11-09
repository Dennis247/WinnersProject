namespace WinnersProject.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WinnersProject.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WinnersProject.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WinnersProject.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            List<District> districtsSeed = new List<District>();
            List<Branch> branchesSeed = new List<Branch>();

            districtsSeed.AddRange(new List<District> {
                new District("DISTRICT 1","PST. ECHABOR","",""),
                new District("DISTRICT 2","PST. MICAH","",""),
                new District("DISTRICT 3","PST. OBEGHE","",""),
                new District("DISTRICT 4","","",""),
                new District("DISTRICT 5","","",""),
                new District("DISTRICT 6","","",""),
                new District("DISTRICT 7","","",""),
                new District("DISTRICT 8","","",""),
                new District("DISTRICT 9","","",""),
                new District("DISTRICT 10","","",""),
                new District("DISTRICT 11","","",""),
                new District("DISTRICT 12","","",""),
                new District("DISTRICT 13","","",""),
                new District("DISTRICT 14","","",""),
             });

            branchesSeed.AddRange(new List<Branch> {
               new Branch(1,"KOTOKOTO L/OUT"),
               new Branch(1,"KEPAS FILLING STATION"),
               new Branch(1,"RIGHT HAND SIDE OF ORHUWHORUN"),

               new Branch(2,"MOWETE"),
               new Branch(2,"ORHUWHORUN JUNCTION"),
               new Branch(2,"ORHUWHORUN JUNCTION"),
               new Branch(2,"BORO"),
               new Branch(2,"NEW YORK"),
               new Branch(2,"HARBOUR MARKET (RIGHT SIDE)"),

               new Branch(3,"LEFT SIDE OF ORHUWHORUN ROAD"),
               new Branch(3,"ORHUWHORUN JUNCTION"),
               new Branch(3,"OLD EKETE ROAD"),
               new Branch(3,"EPHRAIM"),
               new Branch(3,"VISA"),
               new Branch(3,"R & J JUNCTION"),


               new Branch(4,"OVWIAN TO THE LEFT FROM CON OIL"),
               new Branch(4,"ODIETE"),
               new Branch(4,"SAUDJE"),
               new Branch(4,"EMEJOR"),
               new Branch(4,"JUBILEE"),
               new Branch(4,"IFAKA"),
               new Branch(4,"MATERNITY ROAD"),
               new Branch(4,"JIGBALE"),
               new Branch(4,"OGODOGUN"),



               new Branch(5,"ORUGBO PLAZA"),
               new Branch(5,"EXPRESS JUNCTION"),
               new Branch(5,"ORHUWHORUN JUNCTION"),
               new Branch(5,"NBTC ROAD"),
               new Branch(5,"IZOMO"),
               new Branch(5,"PEABODY"),

                new Branch(6,"EXPRESS JUNCTION TO THE LEFT"),
                new Branch(6,"UFUOMA STREET"),
                new Branch(6,"IGBIKI LAYOUT"),
                new Branch(6,"UTUAMA"),
                new Branch(6,"ONOS SCHOOL"),
                new Branch(6,"UJEVWU"),

               new Branch(7,"EKETE INLAND"),
               new Branch(7,"POLICE STATION"),
               new Branch(7,"NEW LAYOUT"),
               new Branch(7,"HOSPITAL ROAD"),
               new Branch(7,"OKU LAYOUT"),
               new Branch(7,"FREE INDEED STREET"),

               new Branch(8,"LAGOS ROAD"),
               new Branch(8,"ABUJA ROAD"),
               new Branch(8,"2ND GATE"),
               new Branch(8,"KANO ROAD"),
               new Branch(8,"MALUFASHI"),
               new Branch(8,"SECTOR F"),
               new Branch(8,"IBADAN ROAD"),




               new Branch(9,"PORT HARCOURT ROAD"),
               new Branch(9,"SCHOOL 2 AND 3"),
               new Branch(9,"RESERVOIR - ECOBANK, CHILDREN CLINIC AREA"),
               new Branch(9,"T.H.S"),
               new Branch(9,"SHELL QUARTERS"),
               new Branch(9,"MOBILE CAMP"),
           

               new Branch(10,"CAMP EXTENSION"),
               new Branch(10,"PERMANENT CAMP"),
               new Branch(10,"MOWETE"),
               new Branch(10,"IGBOGIDI"),
               new Branch(10,"BRUME ESTATE"),
               new Branch(10,"OPUTU ESTATE"),
               new Branch(10,"EMU BAKERY"),
               new Branch(10,"POLICE POST"),

               new Branch(11,"CELE STREET"),
               new Branch(11,"USIEFRUN JUNCTION"),
               new Branch(11,"USIEFRUN ROAD BEFORE RAILWAY"),


               new Branch(12,"ORHUWHORUN TOWN"),
               new Branch(12,"EPIS SCHOOL AREA"),
               new Branch(12,"OKU LAYOUT"),
               new Branch(12,"UGBUGHERE"),
               new Branch(12,"ALAKA ROAD"),
               new Branch(12,"OLD EGINI ROAD"),


               new Branch(13,"USIEFRUN ROAD"),
               new Branch(13,"OWHRODE ROAD"),
               new Branch(13,"OBUGHERE QUARTERS"),
               new Branch(13,"OJIKAPATA"),
               new Branch(13,"AFTER RAILWAY"),

                new Branch(14,"EKETE WATERSIDE"),
               new Branch(14,"OTOKUTU"),
               new Branch(14,"OKPAKA"),
            });



       // context.Districts.AddRange(districtsSeed);
       //  context.Branches.AddRange(branchesSeed);
         //  context.SaveChanges();

        }
    }
}
