using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesFlyoutManager : SLCWindowManager<SLC.Social.Leagues.LeaguesFlyoutManager>
    {
        // Properties
        protected override System.Type myWindowType { get; }
        
        // Methods
        protected override System.Type get_myWindowType()
        {
            return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(441585664)});
        }
        public LeaguesFlyoutManager()
        {
        
        }
    
    }

}
