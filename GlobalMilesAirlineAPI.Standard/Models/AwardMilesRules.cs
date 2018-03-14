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
    public class AwardMilesRules : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.AwardTypeEnum awardType;
        private int baseRatio;
        private int checkinRatio;
        private int checkoutRatio;
        private int surveyRatio;

        /// <summary>
        /// The type of the award base. The possible values are 'distance_based' and 'fair_based'.
        /// </summary>
        [JsonProperty("award_type", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.AwardTypeEnum AwardType 
        { 
            get 
            {
                return this.awardType; 
            } 
            set 
            {
                this.awardType = value;
                onPropertyChanged("AwardType");
            }
        }

        /// <summary>
        /// The ratio for calculating base mile from distance or fair. Possible value is an integer between 1 and 100.
        /// </summary>
        [JsonProperty("base_ratio")]
        public int BaseRatio 
        { 
            get 
            {
                return this.baseRatio; 
            } 
            set 
            {
                this.baseRatio = value;
                onPropertyChanged("BaseRatio");
            }
        }

        /// <summary>
        /// The additional mile ratio for a check-in operation. Possible value as an integer between 0 and 100.
        /// </summary>
        [JsonProperty("checkin_ratio")]
        public int CheckinRatio 
        { 
            get 
            {
                return this.checkinRatio; 
            } 
            set 
            {
                this.checkinRatio = value;
                onPropertyChanged("CheckinRatio");
            }
        }

        /// <summary>
        /// The additional mile ratio for a check-out operation. Possible value as an integer between 0 and 100.
        /// </summary>
        [JsonProperty("checkout_ratio")]
        public int CheckoutRatio 
        { 
            get 
            {
                return this.checkoutRatio; 
            } 
            set 
            {
                this.checkoutRatio = value;
                onPropertyChanged("CheckoutRatio");
            }
        }

        /// <summary>
        /// The additional mile ratio for a survey. Possible value as an integer between 0 and 100.
        /// </summary>
        [JsonProperty("survey_ratio")]
        public int SurveyRatio 
        { 
            get 
            {
                return this.surveyRatio; 
            } 
            set 
            {
                this.surveyRatio = value;
                onPropertyChanged("SurveyRatio");
            }
        }
    }
} 