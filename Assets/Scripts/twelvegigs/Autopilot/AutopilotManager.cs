using UnityEngine;

namespace twelvegigs.Autopilot
{
    public class AutopilotManager : MonoSingleton<twelvegigs.Autopilot.AutopilotManager>
    {
        // Fields
        private const double NO_ACTIVITY_MAX_SEC = 60;
        private const float REPEAT_ACTION_RATE = 3;
        private const string HIDDEN_CLICKS = "[hidden_clicks] ";
        private bool <AllowPurchases>k__BackingField;
        private System.Collections.Generic.List<twelvegigs.Autopilot.AutopilotButton> <aButtons>k__BackingField;
        private bool initialized;
        private System.Collections.Generic.List<string> instructions;
        private System.Collections.Generic.HashSet<string> ignoreButtons;
        private System.Collections.Hashtable pressedBtn;
        private twelvegigs.Autopilot.AutopilotGameplay gameplay;
        private twelvegigs.Autopilot.AutopilotRequester requester;
        private bool pauseSceneChange;
        private bool pauseAutomation;
        private System.DateTime lastAction;
        private bool defaultAllowPurchases;
        private int defaultLevels;
        
        // Properties
        public static twelvegigs.Autopilot.AutopilotRequester Requester { get; }
        public static twelvegigs.Autopilot.AutopilotGameplay Gameplay { get; }
        public bool AllowPurchases { get; set; }
        public System.Collections.Generic.List<twelvegigs.Autopilot.AutopilotButton> aButtons { get; set; }
        
        // Methods
        public static twelvegigs.Autopilot.AutopilotRequester get_Requester()
        {
            var val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_4 = 0;
            if((-1758934368) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        public static twelvegigs.Autopilot.AutopilotGameplay get_Gameplay()
        {
            var val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_4 = 0;
            if((-1758934368) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        public bool get_AllowPurchases()
        {
            return (bool)this.<AllowPurchases>k__BackingField;
        }
        public void set_AllowPurchases(bool value)
        {
            this.<AllowPurchases>k__BackingField = value;
        }
        public System.Collections.Generic.List<twelvegigs.Autopilot.AutopilotButton> get_aButtons()
        {
        
        }
        private void set_aButtons(System.Collections.Generic.List<twelvegigs.Autopilot.AutopilotButton> value)
        {
            this.<aButtons>k__BackingField = value;
        }
        public override void InitMonoSingleton()
        {
            this.InitMonoSingleton();
            if(this.initialized == false)
            {
                    this.initialized = true;
                this.initialized = this.initialized;
            }
        
        }
        public void AddInstruction(System.Collections.Generic.List<string> newInstructions, bool clearPrevious = False)
        {
            bool val_1 = clearPrevious;
            if(val_1 != false)
            {
                    val_1 = this.instructions;
                val_1.Clear();
            }
            
            this.instructions.AddRange(collection:  newInstructions);
        }
        public void AddIgnore(string button, bool clearPrevious = False)
        {
            bool val_2 = clearPrevious;
            if(val_2 != false)
            {
                    val_2 = this.ignoreButtons;
                val_2.Clear();
            }
            
            bool val_1 = this.ignoreButtons.Add(item:  button);
        }
        public void ClearIgnore()
        {
            this.ignoreButtons.Clear();
        }
        public void UpdateCounter(string path, int count, int hiddenCount = 0)
        {
            System.Collections.Hashtable val_2;
            System.Collections.Hashtable val_3;
            val_2 = this;
            val_3 = this.pressedBtn;
            if(hiddenCount < 1)
            {
                    return;
            }
            
            val_2 = this.pressedBtn;
            string val_1 = 1112648768 + path;
        }
        public void TrackButtonPressed(twelvegigs.Autopilot.AutopilotButton button)
        {
            ulong val_3;
            var val_10;
            var val_11;
            val_10 = 35639727;
            if(this.pauseAutomation == true)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            System.DateTime val_2 = System.DateTime.UtcNow;
            long val_5 = twelvegigs.storage.JsonDictionary.TotalSeconds(dateTime:  new System.DateTime() {dateData = val_3});
            Add(key:  1470901296, value:  13205504);
            Add(key:  1112785456, value:  button.route);
            int val_7 = button.GetCount(hidden:  true);
            val_7 = val_7 + (button.GetCount(hidden:  false));
            Add(key:  1348647040, value:  13152256);
            string val_9 = new System.Random().ToString();
            Add(key:  1112785536, value:  1112797716);
            val_10 = 13463124 + 22162414;
            if(val_10 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_11 = null;
            val_11 = null;
            App.trackerManager.track(eventName:  1112785632, data:  78753792);
        }
        public void TrackError(System.Collections.Generic.Dictionary<string, string> newError)
        {
            ulong val_5;
            string val_6;
            System.Collections.Generic.IEnumerable<TSource> val_11;
            var val_12;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_14;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.Object> val_16;
            var val_17;
            val_11 = newError;
            if(this.pauseAutomation == true)
            {
                    return;
            }
            
            this.PauseAutomation(pause:  true);
            val_12 = null;
            val_12 = null;
            val_14 = AutopilotManager.<>c.<>9__32_0;
            if(val_14 == 0)
            {
                    val_14 = null;
                val_14 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(object:  AutopilotManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(1112910032));
                val_12 = null;
                AutopilotManager.<>c.<>9__32_0 = val_14;
            }
            
            val_12 = null;
            val_16 = AutopilotManager.<>c.<>9__32_1;
            if(val_16 == 0)
            {
                    val_16 = null;
                val_16 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(object:  AutopilotManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(1112911056));
                AutopilotManager.<>c.<>9__32_1 = val_16;
            }
            
            System.Collections.Generic.Dictionary<TKey, TElement> val_3 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Object, System.Object>, System.Object, System.Object>(source:  val_11, keySelector:  7720960, elementSelector:  7720960);
            System.DateTime val_4 = System.DateTime.UtcNow;
            val_11 = twelvegigs.storage.JsonDictionary.TotalSeconds(dateTime:  new System.DateTime() {dateData = val_5});
            val_11.Add(key:  1470901296, value:  13205504);
            System.Random val_8 = new System.Random();
            string val_9 = val_8.ToString();
            val_11.Add(key:  1112785536, value:  1112928232);
            var val_11 = 22159462;
            val_11 = 13466076 + val_11;
            if(val_11 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_17 = null;
            val_17 = null;
            App.trackerManager.track(eventName:  1112912080, data:  val_11);
            AppConfigs val_10 = App.Configuration;
            this.requester.TakeScreenshot(actionTimestamp:  1152921514309693648, uniqueTag:  val_6, game:  val_8);
        }
        public int ButtonPressedCount(string path, bool hiddenCount = False)
        {
            System.Collections.Hashtable val_2;
            string val_3;
            var val_4;
            val_2 = hiddenCount;
            val_3 = path;
            val_4 = 0;
            if(val_3 == null)
            {
                    return 1152921504682725376;
            }
            
            if(val_2 != false)
            {
                    string val_1 = 1112648768 + val_3;
                val_3 = "[hidden_clicks] ";
            }
            
            val_2 = this.pressedBtn;
            if(val_2 == 0)
            {
                    return 1152921504682725376;
            }
            
            this.pressedBtn.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            return 1152921504682725376;
        }
        public void PauseAutomation(bool pause = True)
        {
            if(pause == true)
            {
                    "RESUME" = "PAUSE";
            }
            
            string val_1 = 1113173136 + 1113173040;
            twelvegigs.Autopilot.AutopilotTools.Log(message:  1113173136);
            this.pauseAutomation = pause;
            System.DateTime val_2 = System.DateTime.UtcNow;
            this.lastAction = new System.DateTime();
        }
        private void OnSceneChange(SceneType sceneType)
        {
            this.pauseSceneChange = true;
            System.Collections.IEnumerator val_1 = this.GetButtonElements();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1113317408);
        }
        private void OnSceneUnloaded(SceneType sceneType)
        {
            this.<aButtons>k__BackingField.Clear();
            if(this.gameplay == 0)
            {
                
            }
        
        }
        private void ExecutePilot()
        {
            var val_5;
            if(this.pauseAutomation == false)
            {
                    this.pauseAutomation = this.pauseSceneChange;
                goto label_1;
            }
            
            return;
            label_1:
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921514310352904}, d2:  new System.DateTime() {dateData = this.lastAction});
            double val_7 = val_5.TotalSeconds;
            this.StopAutomation();
        }
        private void StopAutomation()
        {
            ulong val_3;
            string val_4;
            var val_9;
            twelvegigs.Autopilot.AutopilotTools.Log(message:  1113679584);
            this.pauseAutomation = true;
            this.CancelInvoke(methodName:  1113679696);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            System.DateTime val_2 = System.DateTime.UtcNow;
            long val_5 = twelvegigs.storage.JsonDictionary.TotalSeconds(dateTime:  new System.DateTime() {dateData = val_3});
            Add(key:  1470901296, value:  13205504);
            System.Random val_6 = new System.Random();
            string val_7 = val_6.ToString();
            Add(key:  1112785536, value:  1113695960);
            var val_9 = 22157266;
            val_9 = 13468272 + val_9;
            if(val_9 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_9 = null;
            val_9 = null;
            App.trackerManager.track(eventName:  1113679792, data:  78753792);
            AppConfigs val_8 = App.Configuration;
            this.requester.TakeScreenshot(actionTimestamp:  1152921514310461360, uniqueTag:  val_4, game:  val_6);
        }
        private System.Collections.IEnumerator GetButtonElements()
        {
            object val_1 = new System.Object();
            typeof(AutopilotManager.<GetButtonElements>d__39).__il2cppRuntimeField_8 = 0;
            typeof(AutopilotManager.<GetButtonElements>d__39).__il2cppRuntimeField_10 = this;
        }
        private System.Collections.IEnumerator TrySelectableAction()
        {
            object val_1 = new System.Object();
            typeof(AutopilotManager.<TrySelectableAction>d__40).__il2cppRuntimeField_8 = 0;
            typeof(AutopilotManager.<TrySelectableAction>d__40).__il2cppRuntimeField_10 = this;
        }
        private void ExecuteSelectableAction()
        {
            twelvegigs.Autopilot.AutopilotButton val_16;
            var val_28;
            twelvegigs.Autopilot.AutopilotManager val_30;
            var val_31;
            var val_32;
            var val_33;
            System.Func<UnityEngine.Camera, System.Single> val_35;
            System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32> val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_49;
            float val_50;
            var val_51;
            val_30 = this;
            val_32;
            if(((this.<aButtons>k__BackingField) == 0) || ((this.<aButtons>k__BackingField) < 1))
            {
                goto label_96;
            }
            
            UnityEngine.Camera[] val_1 = UnityEngine.Camera.allCameras;
            val_33 = null;
            val_33 = null;
            val_35 = AutopilotManager.<>c.<>9__41_0;
            if(val_35 == 0)
            {
                    val_35 = null;
                val_35 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Single>(object:  AutopilotManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(1114028192));
                AutopilotManager.<>c.<>9__41_0 = val_35;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_3 = System.Linq.Enumerable.OrderByDescending<System.Object, System.Single>(source:  0, keySelector:  7720960);
            var val_31 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_9;
            }
            
            val_30 = 0;
            label_11:
            val_36 = 0;
            if((mem[1179403735] + 0) == null)
            {
                goto label_10;
            }
            
            val_30 = val_30 + 1;
            val_36 = (uint)val_30 & 65535;
            if(val_36 < mem[1179403825])
            {
                goto label_11;
            }
            
            label_9:
            val_37 = 0;
            goto label_12;
            label_10:
            var val_4 = mem[1179403735] + 0;
            val_31 = val_31 + (((mem[1179403735] + 0) + 4) << 3);
            val_37 = val_31 + 188;
            label_12:
            val_38 = 0;
            label_68:
            var val_32 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_14;
            }
            
            val_30 = 0;
            label_16:
            val_36 = 0;
            if((mem[1179403735] + 0) == null)
            {
                goto label_15;
            }
            
            val_30 = val_30 + 1;
            val_36 = (uint)val_30 & 65535;
            if(val_36 < mem[1179403825])
            {
                goto label_16;
            }
            
            label_14:
            val_39 = val_38;
            goto label_17;
            label_15:
            var val_5 = mem[1179403735] + 0;
            val_32 = val_32 + (((mem[1179403735] + 0) + 4) << 3);
            val_39 = val_32 + 188;
            label_17:
            if(val_38 == 0)
            {
                goto label_18;
            }
            
            var val_34 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_20;
            }
            
            var val_33 = 0;
            label_22:
            if((mem[1179403735] + 0) == null)
            {
                goto label_21;
            }
            
            val_33 = val_33 + 1;
            if(((uint)val_33 & 65535) < mem[1179403825])
            {
                goto label_22;
            }
            
            label_20:
            val_40 = val_38;
            val_41 = val_38;
            goto label_23;
            label_21:
            var val_6 = mem[1179403735] + 0;
            val_34 = val_34 + (((mem[1179403735] + 0) + 4) << 3);
            val_40 = val_34 + 188;
            label_23:
            object val_7 = new System.Object();
            typeof(AutopilotManager.<>c__DisplayClass41_0).__il2cppRuntimeField_8 = val_38.GetInstanceID();
            val_36 = null;
            val_36 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  457773056, method:  new IntPtr(1114033312));
            System.Collections.Generic.IEnumerable<TSource> val_10 = System.Linq.Enumerable.Where<System.Object>(source:  this.<aButtons>k__BackingField, predicate:  7720960);
            val_42 = null;
            val_42 = null;
            val_44 = AutopilotManager.<>c.<>9__41_2;
            if(val_44 == 0)
            {
                    val_44 = null;
                val_44 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  AutopilotManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(1114036384));
                AutopilotManager.<>c.<>9__41_2 = val_44;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_12 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  this.<aButtons>k__BackingField, keySelector:  7720960);
            System.Collections.Generic.List<TSource> val_13 = System.Linq.Enumerable.ToList<System.Object>(source:  this.<aButtons>k__BackingField);
            val_30 = this.<aButtons>k__BackingField;
            if((mem[1152921514310847336] + 12) < 1)
            {
                goto label_32;
            }
            
            if((mem[1152921514310847336] + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            List.Enumerator<T> val_14 = GetEnumerator();
            label_41:
            if(MoveNext() == false)
            {
                goto label_36;
            }
            
            val_36 = mem[val_16 + 36];
            val_36 = val_16 + 36;
            if((val_36.Contains(value:  mem[1152921514310847336] + 8 + 16)) == false)
            {
                goto label_41;
            }
            
            bool val_18 = val_16.CanBePressed();
            if((val_18 == false) || ((val_18.SimulateClick(btn:  val_16, camera:  0, hiddenClick:  true)) == false))
            {
                goto label_41;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = mem[1152921514310847336] + 8 + 16;
            twelvegigs.Autopilot.AutopilotTools.LogFormat(format:  1114040480, args:  472754880);
            mem[1152921514310847336].RemoveAt(index:  0);
            val_45 = 0;
            val_46 = 451;
            goto label_47;
            label_36:
            val_45 = 0;
            val_46 = 320;
            label_47:
            val_47 = val_45 + 1;
            mem2[0] = val_46;
            Dispose();
            if(val_47 == 1)
            {
                goto label_49;
            }
            
            var val_35 = 1114053624 + ((val_45 + 1)) << 2;
            if(val_35 == 451)
            {
                goto label_50;
            }
            
            val_35 = val_35 - 320;
            if(val_47 > 1)
            {
                    0 = 1;
            }
            
            val_35 = val_35 >> 5;
            val_35 = 1 & val_35;
            val_35 = val_47 - val_35;
            goto label_51;
            label_49:
            label_32:
            label_51:
            List.Enumerator<T> val_20 = GetEnumerator();
            val_30 = val_30;
            label_59:
            if(MoveNext() == false)
            {
                goto label_53;
            }
            
            if(val_16.CanBePressed() == false)
            {
                goto label_59;
            }
            
            string val_23 = val_16.name;
            val_36 = val_16;
            bool val_24 = mem[1152921514310847340].Contains(item:  val_36);
            if((val_24 == true) || ((val_24.SimulateClick(btn:  val_16, camera:  0, hiddenClick:  false)) == false))
            {
                goto label_59;
            }
            
            System.DateTime val_26 = System.DateTime.UtcNow;
            val_47 = 1;
            mem[1152921514310847360] = val_28;
            val_49 = 451;
            goto label_62;
            label_53:
            val_49 = 418;
            val_47 = 0 + 1;
            label_62:
            mem2[0] = 418;
            Dispose();
            val_50 = val_38;
            if(val_47 == 1)
            {
                goto label_68;
            }
            
            if((1114053624 + ((0 + 1)) << 2) == 418)
            {
                goto label_65;
            }
            
            if((1114053624 + ((0 + 1)) << 2) != 451)
            {
                goto label_68;
            }
            
            goto label_67;
            label_65:
            var val_36 = val_47 >> 31;
            var val_29 = val_47 + (~(val_47 >> 31));
            goto label_68;
            label_18:
            val_47 = 0 + 1;
            mem2[0] = 441;
            label_67:
            val_31 = 0;
            goto label_122;
            label_50:
            val_31 = 0;
            val_50 = val_38;
            label_122:
            if(val_50 == 0)
            {
                goto label_90;
            }
            
            var val_37 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_91;
            }
            
            val_30 = 0;
            label_93:
            val_36 = 0;
            if((mem[1179403735] + 0) == null)
            {
                goto label_92;
            }
            
            val_30 = val_30 + 1;
            val_36 = (uint)val_30 & 65535;
            if(val_36 < mem[1179403825])
            {
                goto label_93;
            }
            
            label_91:
            val_51 = val_50;
            goto label_94;
            label_92:
            var val_30 = mem[1179403735] + 0;
            val_37 = val_37 + (((mem[1179403735] + 0) + 4) << 3);
            val_51 = val_37 + 188;
            label_94:
            label_90:
            if(val_47 != 1)
            {
                    if((1114053624 + ((val_45 + 1)) << 2) == 451)
            {
                    return;
            }
            
            }
            
            label_96:
            twelvegigs.Autopilot.AutopilotTools.Log(message:  1114041632);
        }
        private bool SimulateClick(twelvegigs.Autopilot.AutopilotButton btn, UnityEngine.Camera camera, bool hiddenClick = False)
        {
            UnityEngine.Camera val_7;
            var val_8;
            var val_9;
            var val_10;
            val_7 = camera;
            val_8 = 35639737;
            val_9 = 0;
            if((twelvegigs.Autopilot.AutopilotTools.RaycastOnButton(button:  btn, camera:  val_7)) == false)
            {
                    return (bool)val_9;
            }
            
            if(btn.SkipExecuteClick != true)
            {
                    UnityEngine.GameObject val_3 = btn.gameObject;
                UnityEngine.EventSystems.EventSystem val_4 = UnityEngine.EventSystems.EventSystem.current;
                UnityEngine.EventSystems.BaseEventData val_5 = null;
                val_8 = val_5;
                val_5 = new UnityEngine.EventSystems.BaseEventData(eventSystem:  0);
                val_7 = 13471868 + 22167944;
                if(val_7 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_10 = null;
                val_10 = null;
                bool val_6 = UnityEngine.EventSystems.ExecuteEvents.Execute<UnityEngine.EventSystems.IUpdateSelectedHandler>(target:  btn, eventData:  210276352, functor:  UnityEngine.EventSystems.ExecuteEvents.s_SubmitHandler);
            }
            
            val_9 = 1;
            return (bool)val_9;
        }
        private void AttachButtonTracker()
        {
            UnityEngine.Component val_5;
            var val_14;
            var val_15;
            System.Func<twelvegigs.Autopilot.AutopilotButton, System.Single> val_17;
            System.Collections.Generic.List<UnityEngine.UI.Selectable> val_1 = UnityEngine.UI.Selectable.allSelectables;
            val_14 = 0;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            List.Enumerator<T> val_3 = GetEnumerator();
            label_13:
            if(MoveNext() == false)
            {
                goto label_4;
            }
            
            UnityEngine.GameObject val_6 = val_5.gameObject;
            if((val_5.activeInHierarchy == false) || ((val_5.enabled == false) || ((val_5 + 148) == 0)))
            {
                goto label_13;
            }
            
            twelvegigs.Autopilot.WUTAutopilotGameplay val_9 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  val_5);
            twelvegigs.Autopilot.WUTAutopilotGameplay val_10 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  val_5);
            Add(item:  val_5);
            goto label_13;
            label_4:
            Dispose();
            mem[1152921514311103072].Clear();
            val_15 = null;
            val_15 = null;
            val_17 = AutopilotManager.<>c.<>9__43_0;
            if(val_17 == 0)
            {
                    val_17 = null;
                val_17 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Single>(object:  AutopilotManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(1114293392));
                AutopilotManager.<>c.<>9__43_0 = val_17;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_12 = System.Linq.Enumerable.OrderByDescending<System.Object, System.Single>(source:  80883712, keySelector:  7720960);
            System.Collections.Generic.List<TSource> val_13 = System.Linq.Enumerable.ToList<System.Object>(source:  80883712);
            mem[1152921514311103072].AddRange(collection:  80883712);
        }
        private twelvegigs.Autopilot.AutopilotGameplay GetAutopilotGameplay()
        {
            var val_1;
            var val_2;
            var val_3;
            var val_1 = 22152431;
            val_1 = 13473356 + val_1;
            if(val_1 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_1 = null;
            val_1 = null;
            GameNames val_2 = App.game;
            if(val_2 <= 7)
            {
                goto label_6;
            }
            
            if(val_2 <= 17)
            {
                goto label_7;
            }
            
            if(val_2 == 99)
            {
                    val_2 = 1152921514311191056;
            }
            
            goto label_8;
            label_6:
            val_2 = val_2 - 1;
            if(val_2 >= 7)
            {
                goto label_9;
            }
            
            val_3 = mem[34443760 + ((App.game - 1)) << 2];
            val_3 = 34443760 + ((App.game - 1)) << 2;
            return MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  1114437584);
            label_7:
            if(val_2 == 17)
            {
                    val_2 = 1152921514311194128;
            }
            
            if(val_2 != 10)
            {
                    label_8:
                val_3 = val_2;
            }
            
            return MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  1114437584);
            label_9:
            val_3 = 1152921514311192080;
            return MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  1114437584);
        }
        private void OnDestroy()
        {
            var val_4;
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.Action<Result> val_2 = new System.Action<Result>(object:  1114550608, method:  new IntPtr(1114525584));
            System.Delegate val_3 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
            val_4 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
            if(val_4 != 0)
            {
                    if(val_4 == null)
            {
                goto label_6;
            }
            
            }
            
            val_4 = 0;
            label_6:
            public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_4;
        }
        public AutopilotManager()
        {
            this.defaultAllowPurchases = true;
            this.pressedBtn = new System.Collections.Hashtable();
            this.defaultLevels = 130;
        }
    
    }

}
