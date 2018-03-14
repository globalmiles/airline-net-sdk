/*
 * GlobalMilesAirlineAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
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
    public class Response : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string status;
        private string message;

        /// <summary>
        /// The status of the request. It is always 'ok' for successful responses.
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// The message for the unsuccessful request. It is always null for successful responses.
        /// </summary>
        [JsonProperty("message")]
        public string Message 
        { 
            get 
            {
                return this.message; 
            } 
            set 
            {
                this.message = value;
                onPropertyChanged("Message");
            }
        }
    }
} 