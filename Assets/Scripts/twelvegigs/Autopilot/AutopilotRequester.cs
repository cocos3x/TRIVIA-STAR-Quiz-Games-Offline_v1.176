using UnityEngine;

namespace twelvegigs.Autopilot
{
    public class AutopilotRequester : MonoBehaviour
    {
        // Fields
        private twelvegigs.net.JsonApiRequester apiRequester;
        private string screenshotServerUrl;
        private string eventServerUrl;
        private int cachedEvents;
        private bool screenshotRunning;
        private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> events;
        private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> screenshots;
        private System.DateTime startSession;
        private bool initialize;
        
        // Methods
        public void Start()
        {
            System.DateTime val_3;
            System.DateTime val_1 = System.DateTime.UtcNow;
            this.startSession = val_3;
            this.events = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.screenshots = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Action val_6 = new System.Action(object:  1117216720, method:  new IntPtr(1117191696));
            this.initialize = true;
            this.apiRequester = new twelvegigs.net.JsonApiRequester(ServerURL:  this.eventServerUrl, dequeueHandler:  7454720, logStuff:  false, adminServerURL:  0, throwExceptionsOnRequestFailures:  false);
        }
        public void SendEvent(System.Collections.Generic.Dictionary<string, object> eventData, bool sendImmediately = False)
        {
            if(this.initialize == false)
            {
                    return;
            }
            
            string val_1 = this.startSession.ToString();
            eventData.Add(key:  1117312912, value:  this.startSession);
            35639751 = this.events;
            35639751.Add(item:  eventData);
            if(sendImmediately != true)
            {
                    if(eventData <= this.cachedEvents)
            {
                    return;
            }
            
            }
            
            this.SendEvents();
        }
        public void TakeScreenshot(long actionTimestamp, string uniqueTag, string game)
        {
            if(this.initialize != false)
            {
                    System.Collections.IEnumerator val_2 = this.Screenshot(actionTimestamp:  actionTimestamp, uniqueTag:  uniqueTag, game:  game);
                UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  1117477680);
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PauseAutomation(pause:  false);
        }
        private System.Collections.IEnumerator Screenshot(long actionTimestamp, string uniqueTag, string game)
        {
            var val_1;
            typeof(AutopilotRequester.<Screenshot>d__12).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(AutopilotRequester.<Screenshot>d__12).__il2cppRuntimeField_10 = this;
                typeof(AutopilotRequester.<Screenshot>d__12).__il2cppRuntimeField_18 = R2;
                typeof(AutopilotRequester.<Screenshot>d__12).__il2cppRuntimeField_1C = uniqueTag;
                typeof(AutopilotRequester.<Screenshot>d__12).__il2cppRuntimeField_20 = game;
            }
            else
            {
                    mem[16] = this;
                mem[28] = uniqueTag;
                mem[24] = R2;
                mem[32] = game;
            }
            
            typeof(AutopilotRequester.<Screenshot>d__12).__il2cppRuntimeField_24 = val_1;
        }
        private System.Collections.IEnumerator SendScreenshots()
        {
            object val_1 = new System.Object();
            typeof(AutopilotRequester.<SendScreenshots>d__13).__il2cppRuntimeField_8 = 0;
            typeof(AutopilotRequester.<SendScreenshots>d__13).__il2cppRuntimeField_10 = this;
        }
        private void AddScreenShoot(long actionTimestamp, string uniqueTag, string game, byte[] file)
        {
            WordPets.WPTPetTile val_2;
            string val_5;
            var val_6;
            val_5 = uniqueTag;
            val_6 = R2;
            if(this.initialize == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(null != 0)
            {
                    Add(key:  1117859312, value:  13205504);
            }
            else
            {
                    Add(key:  1117859312, value:  13205504);
            }
            
            val_6 = 1152921510535002416;
            Add(key:  1117859424, value:  game);
            if(null != 0)
            {
                    Add(key:  1117859520, value:  val_2);
            }
            else
            {
                    Add(key:  1117859520, value:  val_2);
            }
            
            Add(key:  -233819456, value:  file);
            val_5 = this.screenshots;
            val_5.Add(item:  78753792);
            if(this.screenshotRunning != true)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_3 = this.SendScreenshots();
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  1117887696);
        }
        private void SendEvents()
        {
            System.Collections.Generic.List<ZooTile> val_1 = new System.Collections.Generic.List<ZooTile>(collection:  this.events);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(null != 0)
            {
                    Add(key:  1956399680, value:  80883712);
            }
            else
            {
                    Add(key:  1956399680, value:  80883712);
            }
            
            Add(key:  2112633200, value:  -1821882608);
            this.apiRequester.DoPost(path:  1956399680, postBody:  78753792, onCompleteFunction:  0, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
            this.events.Clear();
        }
        public AutopilotRequester()
        {
        
        }
        private void <Start>b__9_0()
        {
            this.apiRequester.Dequeue();
        }
    
    }

}
