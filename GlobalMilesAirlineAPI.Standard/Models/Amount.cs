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
    public class Amount : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string currencyCode;
        private double mvalue;

        /// <summary>
        /// ISO 4217 currency code of the amount.
        /// </summary>
        [JsonProperty("currency_code")]
        public string CurrencyCode 
        { 
            get 
            {
                return this.currencyCode; 
            } 
            set 
            {
                this.currencyCode = value;
                onPropertyChanged("CurrencyCode");
            }
        }

        /// <summary>
        /// A decimal value with two decimals in the string representation of amount.
        /// </summary>
        [JsonProperty("value")]
        public double Value 
        { 
            get 
            {
                return this.mvalue; 
            } 
            set 
            {
                this.mvalue = value;
                onPropertyChanged("Value");
            }
        }
    }
} 