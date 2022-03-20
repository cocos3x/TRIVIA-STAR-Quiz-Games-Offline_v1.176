using UnityEngine;

namespace WordForest
{
    public class MapItem : EncodableModel
    {
        // Fields
        public string type;
        public int id;
        public int status;
        
        // Methods
        public MapItem(string mType, int mId, int mStatus = 0)
        {
            this.type = mType;
            this.id = mId;
            this.status = mStatus;
        }
    
    }

}
