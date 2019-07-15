/*
 * GlobalMilesAirlineAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using GlobalMilesAirlineAPI.Standard;
using GlobalMilesAirlineAPI.Standard.Utilities;


namespace GlobalMilesAirlineAPI.Standard.Models
{
    public class FlightMax : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string airline;
        private string cabinType;
        private string flightNumber;
        private string pnr;
        private string ticketNumber;
        private string departureAirport;
        private string arrivalAirport;
        private string departureDateTime;
        private string arrivalDateTime;
        private Models.Amount totalAmount;
        private int? distance;

        /// <summary>
        /// IATA code for airline company.
        /// </summary>
        [JsonProperty("airline")]
        public string Airline 
        { 
            get 
            {
                return this.airline; 
            } 
            set 
            {
                this.airline = value;
                onPropertyChanged("Airline");
            }
        }

        /// <summary>
        /// Cabin type of the flight.
        /// </summary>
        [JsonProperty("cabin_type")]
        public string CabinType 
        { 
            get 
            {
                return this.cabinType; 
            } 
            set 
            {
                this.cabinType = value;
                onPropertyChanged("CabinType");
            }
        }

        /// <summary>
        /// Number of the flight.
        /// </summary>
        [JsonProperty("flight_number")]
        public string FlightNumber 
        { 
            get 
            {
                return this.flightNumber; 
            } 
            set 
            {
                this.flightNumber = value;
                onPropertyChanged("FlightNumber");
            }
        }

        /// <summary>
        /// Passenger name record of the flight.
        /// </summary>
        [JsonProperty("pnr")]
        public string Pnr 
        { 
            get 
            {
                return this.pnr; 
            } 
            set 
            {
                this.pnr = value;
                onPropertyChanged("Pnr");
            }
        }

        /// <summary>
        /// Ticket number of the passenger.
        /// </summary>
        [JsonProperty("ticket_number")]
        public string TicketNumber 
        { 
            get 
            {
                return this.ticketNumber; 
            } 
            set 
            {
                this.ticketNumber = value;
                onPropertyChanged("TicketNumber");
            }
        }

        /// <summary>
        /// IATA code for the departure airport.
        /// </summary>
        [JsonProperty("departure_airport")]
        public string DepartureAirport 
        { 
            get 
            {
                return this.departureAirport; 
            } 
            set 
            {
                this.departureAirport = value;
                onPropertyChanged("DepartureAirport");
            }
        }

        /// <summary>
        /// IATA code for the  arrival airport.
        /// </summary>
        [JsonProperty("arrival_airport")]
        public string ArrivalAirport 
        { 
            get 
            {
                return this.arrivalAirport; 
            } 
            set 
            {
                this.arrivalAirport = value;
                onPropertyChanged("ArrivalAirport");
            }
        }

        /// <summary>
        /// ISO 8601 date and time in UTC for departure time.
        /// </summary>
        [JsonProperty("departure_date_time")]
        public string DepartureDateTime 
        { 
            get 
            {
                return this.departureDateTime; 
            } 
            set 
            {
                this.departureDateTime = value;
                onPropertyChanged("DepartureDateTime");
            }
        }

        /// <summary>
        /// ISO 8601 date and time in UTC for arrival time.
        /// </summary>
        [JsonProperty("arrival_date_time")]
        public string ArrivalDateTime 
        { 
            get 
            {
                return this.arrivalDateTime; 
            } 
            set 
            {
                this.arrivalDateTime = value;
                onPropertyChanged("ArrivalDateTime");
            }
        }

        /// <summary>
        /// A complex object for the amount of the flight including currency and value.
        /// </summary>
        [JsonProperty("total_amount")]
        public Models.Amount TotalAmount 
        { 
            get 
            {
                return this.totalAmount; 
            } 
            set 
            {
                this.totalAmount = value;
                onPropertyChanged("TotalAmount");
            }
        }

        /// <summary>
        /// The distance between departure and arrival airports.
        /// </summary>
        [JsonProperty("distance")]
        public int? Distance 
        { 
            get 
            {
                return this.distance; 
            } 
            set 
            {
                this.distance = value;
                onPropertyChanged("Distance");
            }
        }
    }
} 