/*
 * GlobalMilesAirlineAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using GlobalMilesAirlineAPI.Standard.Controllers;
using GlobalMilesAirlineAPI.Standard.Http.Client;
using GlobalMilesAirlineAPI.Standard.Utilities;

namespace GlobalMilesAirlineAPI.Standard
{
    public partial class GlobalMilesAirlineAPIClient
    {

        /// <summary>
        /// Singleton access to Members controller
        /// </summary>
        public MembersController Members
        {
            get
            {
                return MembersController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Flights controller
        /// </summary>
        public FlightsController Flights
        {
            get
            {
                return FlightsController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public GlobalMilesAirlineAPIClient() { }
        #endregion
    }
}