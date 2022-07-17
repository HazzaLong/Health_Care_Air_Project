using System;

namespace healthCareAirProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating instances of the courier_data
            courier_data americanAirlines_53 = new courier_data(09153, "Kidney", 72, "N.Y. JFK International", "F.L. Fort Myers International", "35° 2' 17 N and 78° 37' 33 W");
            courier_data americanAirlines_75 = new courier_data(09375, "Blood", 3, "O.H. Ohio International", "S.D. South Dakota International", "42° 37' 58 N and 90° 51' 28 W");
            //Console.WriteLine(americanAirlines_53.dest_inbound);
            //Console.WriteLine(americanAirlines_53.contents_temperature);

            User JohnLennon = new User("NowhereMan1965", "1234BangBangMaxwellsSilverHammer", "john_Lennon@thebeatles.com", 1125);
        }
    }

    //uninitialised proporties within courier_data class
    public class courier_data
    {
        public int flight_Number = 0;
        public string contents;
        public int contents_temperature;
        public string dest_inbound;
        public string dest_outbound;
        public string current_location;

        //if contents_temperature is for human organs should be between 68 and 92 F
        //if contents_temperature is for human blood, this should be between 2+ and 6+ C

        public courier_data(int flight_number, string contents, int contents_temperature, string dest_inbound, string dest_outbound, string current_location)
        {
            //this is a constructor for setting the correct parameters
            this.flight_Number = flight_Number;
            this.contents = contents;
            this.contents_temperature = contents_temperature;
            this.dest_inbound = dest_inbound;
            this.dest_outbound = dest_outbound;
            this.current_location = current_location;
        }
    }

    namespace UserClass
    {

        /// <summary>
        /// The user class
        /// <summary>

        public class User
        {
            public string userName;
            public string password;
            public string Email;
            public int AuthToken;


            public User(string username, string pass, string add, int token)
            {

                this.userName = username;
                this.password = pass;
                this.Email = add;
                this.AuthToken = token;

            }
        }

            class countries
            {
                public string courierCountries;

                string[] businessCountries = new string[] { "United States", "Japan", "United Kingdom", "Germany", "Sweden", "France", "Poland", "Lithuania", "Russia", "Ukraine" };

            }

            for(int i = 0; )
        }
    }








