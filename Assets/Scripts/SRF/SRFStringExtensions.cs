using UnityEngine;

namespace SRF
{
    public static class SRFStringExtensions
    {
        // Methods
        public static string Fmt(string formatString, object[] args)
        {
            return System.String.Format(format:  formatString, args:  args);
        }
    
    }

}
