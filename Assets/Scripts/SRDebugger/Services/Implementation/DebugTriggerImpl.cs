using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    public class DebugTriggerImpl : SRServiceBase<SRDebugger.Services.IDebugTriggerService>, IDebugTriggerService
    {
        // Fields
        private SRDebugger.PinAlignment _position;
        private SRDebugger.UI.Other.TriggerRoot _trigger;
        
        // Properties
        public bool IsEnabled { get; set; }
        public SRDebugger.PinAlignment Position { get; set; }
        
        // Methods
        public bool get_IsEnabled()
        {
            if(this._trigger == 0)
            {
                    return false;
            }
            
            UnityEngine.GameObject val_2 = this._trigger.CachedGameObject;
            if(this._trigger != 0)
            {
                    return this._trigger.activeSelf;
            }
            
            return this._trigger.activeSelf;
        }
        public void set_IsEnabled(bool value)
        {
            if(value != false)
            {
                    bool val_1 = UnityEngine.Object.op_Equality(x:  this._trigger, y:  0);
                if(val_1 == true)
            {
                    val_1 = this;
                this.CreateTrigger();
            }
            
            }
            
            if(this._trigger == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_3 = this._trigger.CachedGameObject;
            this._trigger.SetActive(value:  value);
        }
        public SRDebugger.PinAlignment get_Position()
        {
        
        }
        public void set_Position(SRDebugger.PinAlignment value)
        {
            SRDebugger.UI.Other.TriggerRoot val_2 = this._trigger;
            if(val_2 != 0)
            {
                    val_2 = this._trigger;
                SRDebugger.Services.Implementation.DebugTriggerImpl.SetTriggerPosition(t:  this._trigger.TriggerTransform, position:  value);
            }
            
            this._position = value;
        }
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.GameObject val_1 = this.CachedGameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  471857296);
            UnityEngine.Transform val_2 = this.CachedTransform;
            UnityEngine.Transform val_3 = SRF.Hierarchy.Get(key:  466780208);
            this.SetParent(parent:  466780208, worldPositionStays:  true);
            this.name = 471833200;
        }
        private void CreateTrigger()
        {
            System.Exception val_13;
            UnityEngine.Events.UnityAction val_14;
            SRF.UI.LongPressButton val_15;
            val_13 = this;
            object val_1 = UnityEngine.Resources.Load<System.Object>(path:  471946320);
            if(471946320 == 0)
            {
                    UnityEngine.Debug.LogError(message:  471946448);
                return;
            }
            
            UnityEngine.RectTransform val_3 = SRInstantiate.Instantiate<UnityEngine.RectTransform>(prefab:  471946320);
            this._trigger = "SRDebugger/UI/Prefabs/Trigger";
            UnityEngine.Transform val_4 = CachedTransform;
            UnityEngine.Transform val_5 = this.CachedTransform;
            SetParent(parent:  472011696, worldPositionStays:  true);
            SRDebugger.Services.Implementation.DebugTriggerImpl.SetTriggerPosition(t:  this._trigger.TriggerTransform, position:  this._position);
            SRDebugger.Settings val_6 = SRDebugger.Settings.Instance;
            if(0 == 2)
            {
                goto label_10;
            }
            
            if(0 == 1)
            {
                goto label_11;
            }
            
            if(0 == 0)
            {
                goto label_12;
            }
            
            val_13 = null;
            val_13 = new System.Exception(message:  471959920);
            label_11:
            val_14 = null;
            val_14 = new UnityEngine.Events.UnityAction(object:  11022336, method:  new IntPtr(471961072));
            23.AddListener(call:  162246656);
            val_15 = 1835037;
            goto label_17;
            label_10:
            this._trigger.TripleTapButton.RequiredTapCount = 2;
            label_12:
            val_14 = null;
            val_14 = new UnityEngine.Events.UnityAction(object:  472011696, method:  new IntPtr(471961072));
            this._trigger.TripleTapButton.AddListener(call:  162246656);
            val_15 = this._trigger.TapHoldButton;
            label_17:
            UnityEngine.GameObject val_10 = val_15.gameObject;
            val_15.SetActive(value:  false);
            bool val_11 = SRDebugger.Internal.SRDebuggerUtil.EnsureEventSystemExists();
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> val_12 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>(object:  0, method:  new IntPtr(471986672));
            UnityEngine.SceneManagement.SceneManager.add_activeSceneChanged(value:  162459648);
        }
        protected override void OnDestroy()
        {
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>(object:  0, method:  new IntPtr(471986672));
            UnityEngine.SceneManagement.SceneManager.remove_activeSceneChanged(value:  162459648);
            this.OnDestroy();
        }
        private static void OnActiveSceneChanged(UnityEngine.SceneManagement.Scene s1, UnityEngine.SceneManagement.Scene s2)
        {
            bool val_1 = SRDebugger.Internal.SRDebuggerUtil.EnsureEventSystemExists();
        }
        private void OnTriggerButtonClick()
        {
            bool val_2;
            var val_3;
            val_2 = static_value_021FC400;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
            if(1507 == 0)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            label_4:
            if(793910273 == null)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            if(((uint)val_3 & 65535) < 1507)
            {
                goto label_4;
            }
            
            label_2:
            val_3 = val_2;
            goto ((21384261 + ((15449083 + 0) + 4) << 3) + 252);
            label_3:
            var val_2 = 15449083 + 0;
            var val_4 = (15449083 + 0) + 4;
            val_4 = 21384261 + (val_4 << 3);
            val_3 = val_4 + 252;
            goto ((21384261 + ((15449083 + 0) + 4) << 3) + 252);
        }
        private static void SetTriggerPosition(UnityEngine.RectTransform t, SRDebugger.PinAlignment position)
        {
            float val_4;
            float val_5;
            val_4 = 0f;
            if(position <= 6)
            {
                    var val_1 = 11400172 + (11400172 + (position) << 2);
                if(position == 6)
            {
                    11400172 = 11400172 & (t >> 11400172);
                11400172 = 11400172 & ((R8) >> 32);
                11400172 = 11400172 & (t >> 32);
                11400172 = 11400172 & (t >> 32);
                11400172 = 11400172 & ((IP) << ((((11400172 & ((int)t) >> 11400172) & (R8) >> 32) & (t) >> 32) & (t) >> 32));
                11400172 = 11400172 & ((IP) << (((((11400172 & ((int)t) >> 11400172) & (R8) >> 32) & (t) >> 32) & (t) >> 32) & (IP) << ((((11400172 & ((int)t) >> 11400172) & (R8) >> 32) & (t) >> 32) & (t) >> 32)));
                11400172 = 11400172 & ((R8) >> 32);
            }
            
                val_5 = 0.5f;
            }
            else
            {
                    val_5 = 0f;
            }
            
            if(position <= 7)
            {
                    if((42 & (1 << position)) == 0)
            {
                    val_4 = 1f;
            }
            
            }
            
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_4 = 0.5f, y:  null);
            t.pivot = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_4, y:  null);
            t.anchorMin = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            t.anchorMax = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
        public DebugTriggerImpl()
        {
        
        }
    
    }

}
