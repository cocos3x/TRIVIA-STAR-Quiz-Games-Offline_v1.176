using UnityEngine;

namespace WordForest
{
    public class WFOEventSort : IComparer<WGEventHandler>
    {
        // Methods
        protected int GetSortOrder(string eventId)
        {
            var val_10;
            uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  eventId);
            if(val_1 > 2902602938)
            {
                goto label_1;
            }
            
            if(val_1 > 999457290)
            {
                goto label_2;
            }
            
            if(val_1 == 145907821)
            {
                goto label_3;
            }
            
            if(val_1 != 999457290)
            {
                    return 999;
            }
            
            val_10 = System.String.op_Equality(a:  eventId, b:  -1549997168);
            goto label_18;
            label_1:
            if(val_1 > 3244402182)
            {
                goto label_6;
            }
            
            if(val_1 == 3165936380)
            {
                goto label_7;
            }
            
            if(val_1 != 3244402182)
            {
                    return 999;
            }
            
            val_10 = System.String.op_Equality(a:  eventId, b:  -1425319472);
            goto label_18;
            label_2:
            if(val_1 == 2902602938)
            {
                goto label_10;
            }
            
            if(val_1 != 1751534916)
            {
                    return 999;
            }
            
            val_10 = System.String.op_Equality(a:  eventId, b:  -1298907680);
            goto label_18;
            label_6:
            if(val_1 == 3671570374)
            {
                goto label_13;
            }
            
            if(val_1 != 4210228650)
            {
                    return 999;
            }
            
            val_10 = System.String.op_Equality(a:  eventId, b:  -1266462304);
            goto label_18;
            label_3:
            val_10 = System.String.op_Equality(a:  eventId, b:  -1266461296);
            goto label_18;
            label_7:
            val_10 = System.String.op_Equality(a:  eventId, b:  -1298909328);
            goto label_18;
            label_10:
            val_10 = System.String.op_Equality(a:  eventId, b:  -1280644912);
            goto label_18;
            label_13:
            val_10 = System.String.op_Equality(a:  eventId, b:  -1298907488);
            label_18:
            if(val_10 == false)
            {
                    2 = 999;
            }
            
            return 999;
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
        public WFOEventSort()
        {
        
        }
    
    }

}
