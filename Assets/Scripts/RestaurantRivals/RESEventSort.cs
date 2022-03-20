using UnityEngine;

namespace RestaurantRivals
{
    public class RESEventSort : IComparer<WGEventHandler>
    {
        // Methods
        protected int GetSortOrder(string eventId)
        {
            var val_5 = 1;
            if((System.String.op_Equality(a:  eventId, b:  -1549997168)) == true)
            {
                    return (int)val_5;
            }
            
            val_5 = 2;
            if((System.String.op_Equality(a:  eventId, b:  -1298907488)) == true)
            {
                    return (int)val_5;
            }
            
            val_5 = 3;
            if((System.String.op_Equality(a:  eventId, b:  -1298907680)) == true)
            {
                    return (int)val_5;
            }
            
            bool val_4 = System.String.op_Equality(a:  eventId, b:  -1298908384);
            val_5 = 4;
            return (int)val_5;
        }
        public int Compare(WGEventHandler eventA, WGEventHandler eventB)
        {
            string val_1 = eventA.EventType;
            string val_3 = eventB.EventType;
            if((eventA.GetSortOrder(eventId:  eventA)) > (eventB.GetSortOrder(eventId:  eventB)))
            {
                    return 1;
            }
            
            string val_5 = eventA.EventType;
            string val_7 = eventB.EventType;
            if((eventA.GetSortOrder(eventId:  eventA)) < (eventB.GetSortOrder(eventId:  eventB)))
            {
                    0 = 0;
            }
            
            return (int)0;
        }
        public RESEventSort()
        {
        
        }
    
    }

}
