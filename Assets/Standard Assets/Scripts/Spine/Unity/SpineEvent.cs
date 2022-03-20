using UnityEngine;

namespace Spine.Unity
{
    public class SpineEvent : SpineAttributeBase
    {
        // Methods
        public SpineEvent(string startsWith = "", string dataField = "", bool includeNone = True)
        {
            mem[1152921510920334108] = dataField;
            mem[1152921510920334112] = startsWith;
            mem[1152921510920334116] = includeNone;
        }
    
    }

}
