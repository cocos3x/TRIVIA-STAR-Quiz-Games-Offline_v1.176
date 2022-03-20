using UnityEngine;

namespace RestaurantRivals
{
    public class RESEventProgressBar : ARESUIController
    {
        // Fields
        private UnityEngine.UI.Slider progressSlider;
        private UnityEngine.UI.Image pointIconImage;
        private UnityEngine.UI.Text pointGainedText;
        private UnityEngine.UI.Image rewardIconImage;
        private UnityEngine.UI.Text rewardAmountText;
        private UnityEngine.UI.Text meterFillLabel;
        private UGUINetworkedButton button;
        private UnityEngine.Sprite iconCoins;
        private UnityEngine.Sprite iconSpins;
        private UnityEngine.Sprite iconHotNSpicy;
        protected WGEventHandler eventHandler;
        private string currDisplayEventType;
        private int currPointsGainTextValue;
        private int currDisplayPointsCollected;
        private int currDisplayPointsRequired;
        
        // Properties
        public UnityEngine.UI.Slider ProgressSlider { get; }
        public UnityEngine.UI.Image PointIconImage { get; }
        public UnityEngine.UI.Text MeterFillLabel { get; }
        public UnityEngine.UI.Image RewardIconImage { get; }
        public string EventType { get; }
        
        // Methods
        public UnityEngine.UI.Slider get_ProgressSlider()
        {
        
        }
        public UnityEngine.UI.Image get_PointIconImage()
        {
        
        }
        public UnityEngine.UI.Text get_MeterFillLabel()
        {
        
        }
        public UnityEngine.UI.Image get_RewardIconImage()
        {
        
        }
        public string get_EventType()
        {
            if(this.eventHandler == 0)
            {
                    this.eventHandler = 0;
                return;
            }
            
            return this.eventHandler.EventType;
        }
        private void Start()
        {
            System.Action<System.Boolean> val_4;
            System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  537423264, method:  new IntPtr(537394144));
            System.Delegate val_2 = System.Delegate.Combine(a:  this.button.OnConnectionClick, b:  7401472);
            val_4 = this.button.OnConnectionClick;
            if(val_4 != 0)
            {
                    if(null == null)
            {
                goto label_4;
            }
            
            }
            
            val_4 = 0;
            label_4:
            this.button.OnConnectionClick = val_4;
            UnityEngine.GameObject val_3 = this.pointGainedText.gameObject;
            this.pointGainedText.SetActive(value:  false);
        }
        protected override void Awake()
        {
            this.Awake();
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  537547552, name:  -1649709888);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  537547552, name:  -1649709760);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  537659552, name:  -1649709888);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  537659552, name:  -1649709760);
        }
        public void SetPointsGainText(int value)
        {
            float val_2;
            float val_3;
            float val_4;
            UnityEngine.Color val_1 = color;
            this.pointGainedText.color = new UnityEngine.Color() {r = val_2, g = val_3, b = val_4, a = 1f};
            this.currPointsGainTextValue = value;
            string val_5 = System.String.Format(format:  2128510224, arg0:  13152256);
            UnityEngine.GameObject val_6 = this.pointGainedText.gameObject;
            this.pointGainedText.SetActive(value:  true);
        }
        public void UpdateValue(bool animated = False)
        {
            WGEventHandler val_12;
            var val_13;
            System.Func<WGEventHandler, System.Boolean> val_15;
            UnityEngine.UI.Image val_16;
            UnityEngine.Sprite val_17;
            val_12 = this.eventHandler;
            if(val_12 != 0)
            {
                goto label_1;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<WGEventHandler> val_2 = GetOrderedEventHandlers();
            val_13 = null;
            val_13 = null;
            val_15 = RESEventProgressBar.<>c.<>9__29_0;
            if(val_15 == 0)
            {
                    val_15 = null;
                val_15 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  RESEventProgressBar.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(537896416));
                RESEventProgressBar.<>c.<>9__29_0 = val_15;
            }
            
            val_12 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
            object val_4 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  -2101040096, predicate:  7720960);
            this.eventHandler = val_12;
            if(val_12 == 0)
            {
                goto label_10;
            }
            
            label_1:
            if(val_12 == 0)
            {
                    if(this.eventHandler == 0)
            {
                goto label_13;
            }
            
            }
            
            UnityEngine.GameObject val_5 = this.rewardIconImage.gameObject;
            this.rewardIconImage.SetActive(value:  false);
            return;
            label_13:
            if(this.eventHandler.myEvent == 2)
            {
                goto label_20;
            }
            
            if(this.eventHandler.myEvent != 1)
            {
                goto label_21;
            }
            
            val_16 = this.rewardIconImage;
            val_17 = this.iconCoins;
            goto label_22;
            label_20:
            val_16 = this.rewardIconImage;
            val_17 = this.iconSpins;
            label_22:
            val_16.sprite = val_17;
            label_21:
            string val_6 = this.eventHandler.EventType;
            if((System.String.op_Inequality(a:  this.eventHandler, b:  this.currDisplayEventType)) != false)
            {
                    this.currDisplayPointsCollected = 0;
                this.currDisplayPointsRequired = 0;
                string val_8 = this.eventHandler.EventType;
                this.currDisplayEventType = this.eventHandler;
            }
            
            int val_9 = UnityEngine.Mathf.Min(a:  this.eventHandler, b:  this.eventHandler);
            if(this.eventHandler == this.currDisplayPointsRequired)
            {
                    if(val_9 >= this.currDisplayPointsCollected)
            {
                goto label_32;
            }
            
            }
            
            this.SetValue(pointsCollected:  0, pointsRequired:  this.eventHandler, animated:  false);
            label_32:
            this.currDisplayPointsCollected = val_9;
            this.currDisplayPointsRequired = this.eventHandler;
            decimal val_10 = new System.Decimal(value:  1000);
            string val_11 = MetricSystem.Abbreviate(number:  new System.Decimal() {flags = SL, hi = 537986976, lo = 537986976, mid = 537986976}, maxSigFigs:  3, round:  false, useColor:  false, maxValueWithoutAbbr:  new System.Decimal() {flags = val_10.flags, hi = val_10.hi, lo = val_10.lo, mid = val_10.mid}, useRichText:  false, withSpaces:  false);
            this.SetValue(pointsCollected:  val_9, pointsRequired:  this.eventHandler, animated:  animated);
            return;
            label_10:
        }
        private void OnEnable()
        {
            this.UpdateDisplay();
        }
        private void OnGameEventControllerUpdate()
        {
            this.UpdateDisplay();
        }
        private void OnGameEventHandlerProgress()
        {
            this.UpdateDisplay();
        }
        private void SetValue(int pointsCollected, int pointsRequired, bool animated = False)
        {
            var val_11;
            var val_12;
            int val_13;
            bool val_14;
            UnityEngine.UI.Slider val_15;
            var val_16;
            object val_1 = new System.Object();
            if(val_1 != 0)
            {
                    val_11 = val_1;
                typeof(RESEventProgressBar.<>c__DisplayClass33_0).__il2cppRuntimeField_1C = pointsCollected;
                val_12 = 1152921505031127068;
                mem[1152921505031127048] = this;
                mem[1152921505031127052] = pointsRequired;
                val_13 = this.currPointsGainTextValue;
                val_14 = (float)pointsCollected / (float)pointsRequired;
            }
            else
            {
                    mem[8] = this;
                val_12 = 12;
                mem[12] = pointsRequired;
                val_11 = 28;
                mem[28] = pointsCollected;
                val_13 = this.currPointsGainTextValue;
                val_14 = (float)mem[28] / (float)mem[12];
            }
            
            typeof(RESEventProgressBar.<>c__DisplayClass33_0).__il2cppRuntimeField_18 = val_13;
            val_15 = this.progressSlider;
            float val_10 = val_15;
            typeof(RESEventProgressBar.<>c__DisplayClass33_0).__il2cppRuntimeField_10 = val_15;
            val_10 = val_14 - val_10;
            typeof(RESEventProgressBar.<>c__DisplayClass33_0).__il2cppRuntimeField_14 = val_10;
            if(animated != false)
            {
                    DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOValue(target:  this.progressSlider, endValue:  val_10, duration:  null, snapping:  val_14);
                object val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.progressSlider, ease:  1);
                DG.Tweening.TweenCallback val_4 = new DG.Tweening.TweenCallback(object:  424280064, method:  new IntPtr(538488800));
                object val_5 = DG.Tweening.TweenSettingsExtensions.OnUpdate<System.Object>(t:  this.progressSlider, action:  190734336);
                DG.Tweening.TweenCallback val_6 = new DG.Tweening.TweenCallback(object:  424280064, method:  new IntPtr(538489824));
                object val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.progressSlider, action:  190734336);
                return;
            }
            
            this.currPointsGainTextValue = 0;
            UnityEngine.GameObject val_8 = this.pointGainedText.gameObject;
            this.pointGainedText.SetActive(value:  false);
            if(this.eventHandler != 0)
            {
                    val_16 = "COMPLETED";
            }
            else
            {
                    val_15 = 1152921504619999232;
                string val_9 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
                val_16 = "{0}/{1}";
            }
            
            if(this.meterFillLabel != 0)
            {
                    return;
            }
        
        }
        private void UpdateDisplay()
        {
            var val_14;
            System.Func<WGEventHandler, System.Boolean> val_16;
            UnityEngine.UI.Image val_17;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<WGEventHandler> val_2 = GetOrderedEventHandlers();
            val_14 = null;
            val_14 = null;
            val_16 = RESEventProgressBar.<>c.<>9__34_0;
            if(val_16 == 0)
            {
                    val_16 = null;
                val_16 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  RESEventProgressBar.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(538643808));
                RESEventProgressBar.<>c.<>9__34_0 = val_16;
            }
            
            object val_4 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  -2101040096, predicate:  7720960);
            this.eventHandler = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
            if((public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance()) == 0)
            {
                goto label_10;
            }
            
            string val_5 = EventType;
            if((System.String.op_Equality(a:  -2101040096, b:  -1549997168)) == false)
            {
                goto label_11;
            }
            
            val_17 = this.pointIconImage;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_16 = mem[public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_20 + 24];
            val_16 = public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_20 + 24;
            goto label_24;
            label_10:
            UnityEngine.GameObject val_8 = this.progressSlider.gameObject;
            this.progressSlider.SetActive(value:  false);
            return;
            label_11:
            if((System.String.op_Equality(a:  -2101040096, b:  -1298907488)) == false)
            {
                goto label_19;
            }
            
            val_17 = this.pointIconImage;
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_16 = mem[public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_20 + 28];
            val_16 = public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_20 + 28;
            goto label_24;
            label_19:
            if((System.String.op_Equality(a:  -2101040096, b:  -1298907680)) == false)
            {
                goto label_25;
            }
            
            val_17 = this.pointIconImage;
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_16 = mem[public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_20 + 32];
            val_16 = public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_20 + 32;
            label_24:
            val_17.sprite = val_16;
            label_25:
            UnityEngine.GameObject val_13 = this.progressSlider.gameObject;
            this.progressSlider.SetActive(value:  true);
            this.UpdateValue(animated:  false);
        }
        private void OnButtonClicked(bool connected)
        {
            if(this.eventHandler == 0)
            {
                
            }
        
        }
        public RESEventProgressBar()
        {
            this.currDisplayPointsCollected = 0;
            this.currDisplayPointsRequired = 0;
        }
    
    }

}
