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
    public class NewMemberResponse : Response 
    {
        // These fields hold the values for the public properties.
        private string ffpNumber;
        private Models.TierTypeEnum? tierType;
        private List<Models.ExtraInfoTypeEnum> needExtraInfo;

        /// <summary>
        /// Card number of frequent flyer.
        /// </summary>
        [JsonProperty("ffp_number")]
        public string FfpNumber 
        { 
            get 
            {
                return this.ffpNumber; 
            } 
            set 
            {
                this.ffpNumber = value;
                onPropertyChanged("FfpNumber");
            }
        }

        /// <summary>
        /// Type of tiers.
        /// </summary>
        [JsonProperty("tier_type", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.TierTypeEnum? TierType 
        { 
            get 
            {
                return this.tierType; 
            } 
            set 
            {
                this.tierType = value;
                onPropertyChanged("TierType");
            }
        }

        /// <summary>
        /// If the provided information is not enough to create a ffp member, this field can use to get new information. The possible values are language, gender, birthday, nationality, national_id_number, academic_title, address, country, city, area, zip_code, password. We will collect the additional information from user and will enhance the first request and will send it again.
        /// </summary>
        [JsonProperty("need_extra_info", ItemConverterType = typeof(StringValuedEnumConverter))]
        public List<Models.ExtraInfoTypeEnum> NeedExtraInfo 
        { 
            get 
            {
                return this.needExtraInfo; 
            } 
            set 
            {
                this.needExtraInfo = value;
                onPropertyChanged("NeedExtraInfo");
            }
        }
    }
} 