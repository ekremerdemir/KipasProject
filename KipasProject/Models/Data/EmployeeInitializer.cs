using KipasProject.Models.Context;
using KipasProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KipasProject.Models.Data
{
    public class EmployeeInitializer<T> : DropCreateDatabaseIfModelChanges<EmployeDbContext>
    {
        protected override void Seed(EmployeDbContext context)
        {

            IList<Employee> list = new List<Employee>();

            {


                list.Add(new Employee()
                {
                    ID = 1,
                    FirstName = "John",
                    LastName = "Heart",
                    Prefix = "Mr.",
                    Position = "CEO",
                    BirthDate = DateTime.Parse("1964/03/16"),
                    HireDate = DateTime.Parse("1995/01/15"),
                    Notes = "John has been in the Audio/Video industry since 1990. He has led DevAv as its CEO since 2003.\r\n\r\nWhen not working hard as the CEO, John loves to golf and bowl. He once bowled a perfect game of 300.",
                    Address = "351 S Hill St.",
                    CityID = 5,

                });
                list.Add(new Employee()
                {
                    ID = 2,
                    FirstName = "Olivia",
                    LastName = "Peyton",
                    Prefix = "Mrs.",
                    Position = "Sales Assistant",
                    BirthDate = DateTime.Parse("1981/06/03"),
                    HireDate = DateTime.Parse("2012/05/14"),
                    Notes = "Olivia loves to sell. She has been selling DevAV products since 2012. \r\n\r\nOlivia was homecoming queen in high school. She is expecting her first child in 6 months. Good Luck Olivia.",
                    Address = "807 W Paseo Del Mar",
                    CityID = 5,

                });
                list.Add(new Employee()
                {
                    ID = 3,
                    FirstName = "Robert",
                    LastName = "Reagan",
                    Prefix = "Mr.",
                    Position = "CMO",
                    BirthDate = DateTime.Parse("1974/09/07"),
                    HireDate = DateTime.Parse("2002/11/08"),
                    Notes = "Robert was recently voted the CMO of the year by CMO Magazine. He is a proud member of the DevAV Management Team.\r\n\r\nRobert is a championship BBQ chef, so when you get the chance ask him for his secret recipe.",
                    Address = "4 Westmoreland Pl.",
                    CityID = 4,

                });
                list.Add(new Employee()
                {
                    ID = 4,
                    FirstName = "Greta",
                    LastName = "Sims",
                    Prefix = "Ms.",
                    Position = "HR Manager",
                    BirthDate = DateTime.Parse("1977/11/22"),
                    HireDate = DateTime.Parse("1998/04/23"),
                    Notes = "Greta has been DevAV's HR Manager since 2003. She joined DevAV from Sonee Corp.\r\n\r\nGreta is currently training for the NYC marathon. Her best marathon time is 4 hours. Go Greta.",
                    Address = "1700 S Grandview Dr.",
                    CityID = 11,

                });
                list.Add(new Employee()
                {
                    ID = 5,
                    FirstName = "Brett",
                    LastName = "Wade",
                    Prefix = "Mr.",
                    Position = "IT Manager",
                    BirthDate = DateTime.Parse("1968/12/01"),
                    HireDate = DateTime.Parse("2009/03/06"),
                    Notes = "Brett came to DevAv from Microsoft and has led our IT department since 2012.\r\n\r\nWhen he is not working hard for DevAV, he coaches Little League (he was a high school pitcher).",
                    Address = "1120 Old Mill Rd.",
                    CityID = 13,

                });
                list.Add(new Employee()
                {
                    ID = 6,
                    FirstName = "Sandra",
                    LastName = "Johnson",
                    Prefix = "Mrs.",
                    Position = "Controller",
                    BirthDate = DateTime.Parse("1974/11/15"),
                    HireDate = DateTime.Parse("2005/05/11"),
                    Notes = "Sandra is a CPA and has been our controller since 2008. She loves to interact with staff so if you've not met her, be certain to say hi.\r\n\r\nSandra has 2 daughters both of whom are accomplished gymnasts.",
                    Address = "4600 N Virginia Rd.",
                    CityID = 44,

                });
                list.Add(new Employee()
                {
                    ID = 7,
                    FirstName = "Kevin",
                    LastName = "Carter",
                    Prefix = "Mr.",
                    Position = "Shipping Manager",
                    BirthDate = DateTime.Parse("1978/01/09"),
                    HireDate = DateTime.Parse("2009/08/11"),
                    Notes = "Kevin is our hard-working shipping manager and has been helping that department work like clockwork for 18 months.\r\n\r\nWhen not in the office, he is usually on the basketball court playing pick-up games.",
                    Address = "424 N Main St.",
                    CityID = 5,

                });
                list.Add(new Employee()
                {
                    ID = 8,
                    FirstName = "Cynthia",
                    LastName = "Stanwick",
                    Prefix = "Ms.",
                    Position = "HR Assistant",
                    BirthDate = DateTime.Parse("1985/06/05"),
                    HireDate = DateTime.Parse("2008/03/24"),
                    Notes = "Cindy joined us in 2008 and has been in the HR department for 2 years. \r\n\r\nShe was recently awarded employee of the month. Way to go Cindy!",
                    Address = "2211 Bonita Dr.",
                    CityID = 4,

                });
                list.Add(new Employee()
                {
                    ID = 9,
                    FirstName = "Kent",
                    LastName = "Samuelson",
                    Prefix = "Dr.",
                    Position = "Ombudsman",
                    BirthDate = DateTime.Parse("1972/09/11"),
                    HireDate = DateTime.Parse("2009/04/22"),
                    Notes = "As our ombudsman, Kent is on the front-lines solving customer problems and helping our partners address issues out in the field.    He is a classically trained musician and is a member of the Chamber Orchestra.",
                    Address = "12100 Mora Dr",
                    CityID = 26,

                });
                list.Add(new Employee()
                {
                    ID = 10,
                    FirstName = "Taylor",
                    LastName = "Riley",
                    Prefix = "Mr.",
                    Position = "Network Admin",
                    BirthDate = DateTime.Parse("1982/08/14"),
                    HireDate = DateTime.Parse("2012/04/14"),
                    Notes = "If you are like the rest of us at DevAV, then you've probably reached out for help from Taylor. He does a great job as a member of our IT department.",
                    Address = "7776 Torreyson Dr",
                    CityID = 5,


                });
                list.Add(new Employee()
                {
                    ID = 11,
                    FirstName = "Sam",
                    LastName = "Hill",
                    Prefix = "Mr.",
                    Position = "Sales Assistant",
                    BirthDate = DateTime.Parse("1984/02/17"),
                    HireDate = DateTime.Parse("2012/02/01"),
                    Notes = "Sammy is proud to be a member of the DevAV team. He joined the team in 2012 and has been in the sales department from the beginning.\r\n\r\nHe has just picked up golf so you can find him on the links every weekend.",
                    Address = "645 Prospect Crescent",
                    CityID = 11,

                });
                list.Add(new Employee()
                {
                    ID = 12,
                    FirstName = "Kelly",
                    LastName = "Rodriguez",
                    Prefix = "Ms.",
                    Position = "Support Assistant",
                    BirthDate = DateTime.Parse("1988/05/11"),
                    HireDate = DateTime.Parse("2012/10/13"),
                    Notes = "Kelly loves people and that's why she joined DevAV's support department. One of the funniest people in the company, she does stand-up on the weekends at the Laugh Factory.",
                    Address = "1601 W Mountain St.",
                    CityID = 5,

                });
                list.Add(new Employee()
                {
                    ID = 13,
                    FirstName = "Natalie",
                    LastName = "Maguirre",
                    Prefix = "Mrs.",
                    Position = "Trainer",
                    BirthDate = DateTime.Parse("1977/10/07"),
                    HireDate = DateTime.Parse("2008/06/19"),
                    Notes = "Natalie travels the US and teaches our partners how to explain the benefits of our products to customers.\r\n\r\nShe is a proud wife and mom and volunteers her time at the elementary school.",
                    Address = "6400 E Bixby Hill Rd",
                    CityID = 29,

                });
                list.Add(new Employee()
                {
                    ID = 14,
                    FirstName = "Walter",
                    LastName = "Hobbs",
                    Prefix = "Mr.",
                    Position = "Programmer",
                    BirthDate = DateTime.Parse("1984/12/24"),
                    HireDate = DateTime.Parse("2011/02/17"),
                    Notes = "Walter has been developing apps and websites for DevAV since 2011. His passion is software and if you ever walk by his desk, you'll know why.\r\n\r\nWally once worked 72 hours straight - writing code and fixing bugs.",
                    Address = "10385 Shadow Oak Dr",
                    CityID = 13,

                });







                foreach (Employee employee in list)
                    context.Employees.Add(employee);
                base.Seed(context);

            }


            {
                IList<City> Citylist = new List<City>();
                Citylist.Add(new City()
                {
                    CityID = 4,
                    Name = "Arkansas"
                });

                Citylist.Add(new City()
                {
                    CityID = 5,
                    Name = "California"
                });

                Citylist.Add(new City()
                {
                    CityID = 11,
                    Name = "Georgia"
                });
                Citylist.Add(new City()
                {
                    CityID = 13,
                    Name = "Idaho"
                });
                Citylist.Add(new City()
                {
                    CityID = 26,
                    Name = "Missouri"
                });
                Citylist.Add(new City()
                {
                    CityID = 29,
                    Name = "Nevada"
                });
                Citylist.Add(new City()
                {
                    CityID = 44,
                    Name = "Utah"
                });




                foreach (City city1 in Citylist)
                {
                    context.Cities.Add(city1);
                }


                base.Seed(context);



            }





        }
    }
}