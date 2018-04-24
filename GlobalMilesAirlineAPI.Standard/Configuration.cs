using System.Collections.Generic;
using System.Text;
using GlobalMilesAirlineAPI.Standard.Utilities;
using GlobalMilesAirlineAPI.Standard.Models;
namespace GlobalMilesAirlineAPI.Standard
{
    public partial class Configuration
    {

        public enum Environments
        {
            //Cloud Environment
            CLOUD,
        }
        public enum Servers
        {
            DEFAULT,
        }

        //The current environment being used
        public static Environments Environment = Environments.CLOUD;

        //A map of environments and their corresponding servers/baseurls
        public static Dictionary<Environments, Dictionary<Servers, string>> EnvironmentsMap =
            new Dictionary<Environments, Dictionary<Servers, string>>
            {
                { 
                    Environments.CLOUD,new Dictionary<Servers, string>
                    {
                        { Servers.DEFAULT,"https://test1.api.globalmiles.com" },
                    }
                },
            };

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        internal static List<KeyValuePair<string, object>> GetBaseURIParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList; 
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <param name="alias">Default value:DEFAULT</param>
        /// <return>Returns the baseurl</return>
        internal static string GetBaseURI(Servers alias = Servers.DEFAULT)
        {
            StringBuilder Url =  new StringBuilder(EnvironmentsMap[Environment][alias]);
            APIHelper.AppendUrlWithTemplateParameters(Url, GetBaseURIParameters());
            return Url.ToString();        
        }
    }
}