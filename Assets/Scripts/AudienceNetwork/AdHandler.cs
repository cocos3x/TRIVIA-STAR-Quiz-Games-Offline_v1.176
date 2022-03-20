using UnityEngine;

namespace AudienceNetwork
{
    public class AdHandler : MonoBehaviour
    {
        // Fields
        private static readonly System.Collections.Generic.Queue<System.Action> executeOnMainThreadQueue;
        
        // Methods
        public void ExecuteOnMainThread(System.Action action)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            System.Threading.Monitor.Enter(obj:  AudienceNetwork.AdHandler.executeOnMainThreadQueue, lockTaken: ref  bool val_1 = true);
            val_3 = null;
            val_3 = null;
            AudienceNetwork.AdHandler.executeOnMainThreadQueue.Enqueue(item:  action);
            if(0 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  AudienceNetwork.AdHandler.executeOnMainThreadQueue);
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        private void Update()
        {
            var val_3;
            var val_4;
            var val_5;
            var val_3 = 0;
            do
            {
                label_15:
                val_3 = null;
                val_3 = null;
                if((AudienceNetwork.AdHandler.executeOnMainThreadQueue + 20) <= 0)
            {
                    return;
            }
            
                val_4 = null;
                val_4 = null;
                System.Threading.Monitor.Enter(obj:  AudienceNetwork.AdHandler.executeOnMainThreadQueue, lockTaken: ref  bool val_1 = true);
                val_5 = null;
                val_5 = null;
                System.Action val_2 = AudienceNetwork.AdHandler.executeOnMainThreadQueue.Dequeue();
                val_3 = val_3 + 1;
                mem2[0] = 50;
                if(0 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  AudienceNetwork.AdHandler.executeOnMainThreadQueue);
            }
            
                if(val_3 != 1)
            {
                    var val_4 = 1152921514482767192 + ((0 + 1)) << 2;
                if(val_3 > 1)
            {
                    0 = 1;
            }
            
                val_4 = val_4 - 50;
                val_4 = val_4 >> 5;
                val_4 = 1 & val_4;
                val_3 = val_3 - val_4;
            }
            
            }
            while(AudienceNetwork.AdHandler.executeOnMainThreadQueue == 0);
            
            AudienceNetwork.AdHandler.executeOnMainThreadQueue.Invoke();
            goto label_15;
        }
        public void RemoveFromParent()
        {
            UnityEngine.Object.Destroy(obj:  1286109680);
        }
        public AdHandler()
        {
        
        }
        private static AdHandler()
        {
            System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_1 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
            AudienceNetwork.AdHandler.executeOnMainThreadQueue = null;
        }
    
    }

}
