using UnityEngine;

namespace SRDebugger.UI.Tabs
{
    public class OptionsTabController : SRMonoBehaviourEx
    {
        // Fields
        private readonly System.Collections.Generic.List<SRDebugger.UI.Controls.OptionsControlBase> _controls;
        private readonly System.Collections.Generic.List<SRDebugger.UI.Tabs.OptionsTabController.CategoryInstance> _categories;
        private readonly System.Collections.Generic.Dictionary<SRDebugger.Internal.OptionDefinition, SRDebugger.UI.Controls.OptionsControlBase> _options;
        private bool _queueRefresh;
        private bool _selectionModeEnabled;
        private UnityEngine.Canvas _optionCanvas;
        public SRDebugger.UI.Controls.Data.ActionControl ActionControlPrefab;
        public SRDebugger.UI.Other.CategoryGroup CategoryGroupPrefab;
        public UnityEngine.RectTransform ContentContainer;
        public UnityEngine.GameObject NoOptionsNotice;
        public UnityEngine.UI.Toggle PinButton;
        public UnityEngine.GameObject PinPromptSpacer;
        public UnityEngine.GameObject PinPromptText;
        private bool _isTogglingCategory;
        
        // Methods
        protected override void Start()
        {
            UnityEngine.Events.UnityAction<System.Boolean> val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            this.Start();
            val_12 = null;
            val_12 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  427539152, method:  new IntPtr(427504912));
            this.PinButton.onValueChanged.AddListener(call:  162353152);
            this.PinPromptText.SetActive(value:  false);
            this.Populate();
            object val_2 = this.GetComponent<System.Object>();
            this._optionCanvas = this;
            SRDebugger.Services.IOptionsService val_3 = SRDebugger.Internal.Service.Options;
            System.EventHandler val_4 = new System.EventHandler(object:  427539152, method:  new IntPtr(427510032));
            var val_12 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_5;
            }
            
            val_13 = 0;
            label_7:
            val_12 = 0;
            if((mem[1179403735] + 0) == null)
            {
                goto label_6;
            }
            
            val_13 = val_13 + 1;
            val_12 = (uint)val_13 & 65535;
            if(val_12 < mem[1179403825])
            {
                goto label_7;
            }
            
            label_5:
            val_14 = 0;
            goto label_8;
            label_6:
            var val_5 = mem[1179403735] + 0;
            val_12 = val_12 + (((mem[1179403735] + 0) + 4) << 3);
            val_14 = val_12 + 188;
            label_8:
            SRDebugger.Services.IOptionsService val_6 = SRDebugger.Internal.Service.Options;
            System.EventHandler<System.Object> val_7 = new System.EventHandler<System.Object>(object:  427539152, method:  new IntPtr(427511056));
            var val_13 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_10;
            }
            
            val_13 = 0;
            label_12:
            val_12 = 0;
            if((mem[1179403735] + 0) == null)
            {
                goto label_11;
            }
            
            val_13 = val_13 + 1;
            val_12 = (uint)val_13 & 65535;
            if(val_12 < mem[1179403825])
            {
                goto label_12;
            }
            
            label_10:
            val_15 = 0;
            goto label_13;
            label_11:
            var val_8 = mem[1179403735] + 0;
            val_13 = val_13 + (((mem[1179403735] + 0) + 4) << 3);
            val_15 = val_13 + 204;
            label_13:
            SRDebugger.Services.IPinnedUIService val_9 = SRDebugger.Internal.Service.PinnedUI;
            System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean> val_10 = new System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean>(object:  427539152, method:  new IntPtr(427513104));
            var val_14 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_15;
            }
            
            val_13 = 0;
            label_17:
            val_12 = mem[mem[1179403735] + 0];
            val_12 = mem[1179403735] + 0;
            if(val_12 == null)
            {
                goto label_16;
            }
            
            val_13 = val_13 + 1;
            if(((uint)val_13 & 65535) < mem[1179403825])
            {
                goto label_17;
            }
            
            label_15:
            val_16 = 0;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 188);
            label_16:
            var val_11 = mem[1179403735] + 0;
            val_14 = val_14 + (((mem[1179403735] + 0) + 4) << 3);
            val_16 = val_14 + 188;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 188);
        }
        private void OnOptionPinnedStateChanged(SRDebugger.Internal.OptionDefinition optionDefinition, bool isPinned)
        {
            if((this._options.ContainsKey(key:  optionDefinition)) == false)
            {
                    return;
            }
            
            SRDebugger.UI.Controls.OptionsControlBase val_2 = this._options.Item[optionDefinition];
            this._options.IsSelected = isPinned;
        }
        private void OnOptionsUpdated(object sender, System.EventArgs eventArgs)
        {
            this.Clear();
            this.Populate();
        }
        private void OnOptionsValueChanged(object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs)
        {
            this._queueRefresh = true;
        }
        protected override void OnEnable()
        {
            var val_4;
            var val_5;
            val_4 = this;
            val_4.OnEnable();
            SRDebugger.Services.IDebugPanelService val_1 = SRDebugger.Internal.Service.Panel;
            System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean> val_2 = new System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean>(object:  428059856, method:  new IntPtr(428034832));
            var val_4 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_2;
            }
            
            val_4 = 0;
            label_4:
            if((mem[1179403735] + 0) == null)
            {
                goto label_3;
            }
            
            val_4 = val_4 + 1;
            if(((uint)val_4 & 65535) < mem[1179403825])
            {
                goto label_4;
            }
            
            label_2:
            val_5 = 0;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 220);
            label_3:
            var val_3 = mem[1179403735] + 0;
            val_4 = val_4 + (((mem[1179403735] + 0) + 4) << 3);
            val_5 = val_4 + 220;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 220);
        }
        protected override void OnDisable()
        {
            var val_5;
            var val_6;
            var val_7;
            this.SetSelectionModeEnabled(isEnabled:  false);
            SRDebugger.Services.IDebugPanelService val_1 = SRDebugger.Internal.Service.Panel;
            if(0 == 0)
            {
                goto label_1;
            }
            
            SRDebugger.Services.IDebugPanelService val_2 = SRDebugger.Internal.Service.Panel;
            System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean> val_3 = new System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean>(object:  428171856, method:  new IntPtr(428034832));
            var val_5 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_3;
            }
            
            val_5 = 0;
            label_5:
            val_6 = 0;
            if((mem[1179403735] + 0) == null)
            {
                goto label_4;
            }
            
            val_5 = val_5 + 1;
            val_6 = (uint)val_5 & 65535;
            if(val_6 < mem[1179403825])
            {
                goto label_5;
            }
            
            label_3:
            val_7 = 0;
            goto label_6;
            label_4:
            var val_4 = mem[1179403735] + 0;
            val_5 = val_5 + (((mem[1179403735] + 0) + 4) << 3);
            val_7 = val_5 + 228;
            label_6:
            label_1:
            this.OnDisable();
        }
        protected override void Update()
        {
            this.Update();
            if(this._queueRefresh == false)
            {
                    return;
            }
            
            this._queueRefresh = false;
            this.Refresh();
        }
        private void PanelOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, bool b)
        {
            if(b == false)
            {
                goto label_1;
            }
            
            UnityEngine.GameObject val_1 = this.CachedGameObject;
            if(this.activeInHierarchy == true)
            {
                goto label_3;
            }
            
            goto label_4;
            label_1:
            this.SetSelectionModeEnabled(isEnabled:  false);
            label_3:
            this.Refresh();
            label_4:
            if(this._optionCanvas == 0)
            {
                    return;
            }
            
            this._optionCanvas.enabled = b;
        }
        public void SetSelectionModeEnabled(bool isEnabled)
        {
            var val_5;
            var val_11;
            if(this._selectionModeEnabled == true)
            {
                    this._selectionModeEnabled = 1;
            }
            
            if(1 ^ isEnabled != true)
            {
                    return;
            }
            
            this._selectionModeEnabled = isEnabled;
            this.PinButton.isOn = isEnabled;
            this.PinPromptText.SetActive(value:  isEnabled);
            Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            label_14:
            if(0.MoveNext() == false)
            {
                goto label_5;
            }
            
            val_5.SelectionModeEnabled = isEnabled;
            if(isEnabled == false)
            {
                goto label_14;
            }
            
            SRDebugger.Services.IPinnedUIService val_6 = SRDebugger.Internal.Service.PinnedUI;
            if(mem[1179403825] == 0)
            {
                goto label_9;
            }
            
            var val_11 = 0;
            label_11:
            if((mem[1179403735] + 0) == null)
            {
                goto label_10;
            }
            
            val_11 = val_11 + 1;
            if(((uint)val_11 & 65535) < mem[1179403825])
            {
                goto label_11;
            }
            
            label_9:
            val_11 = 0;
            goto label_12;
            label_10:
            var val_7 = mem[1179403735] + 0;
            var val_12 = (mem[1179403735] + 0) + 4;
            val_12 = 1179403647 + (val_12 << 3);
            val_11 = val_12 + 244;
            label_12:
            val_5.IsSelected = false;
            goto label_14;
            label_5:
            0.Dispose();
            List.Enumerator<T> val_8 = GetEnumerator();
            label_19:
            if(MoveNext() == false)
            {
                goto label_16;
            }
            
            val_10 + 8.SelectionModeEnabled = isEnabled;
            goto label_19;
            label_16:
            Dispose();
            this.RefreshCategorySelection();
        }
        private void Refresh()
        {
            SRDebugger.UI.Tabs.OptionsTabController val_4;
            var val_5;
            var val_6;
            val_4 = this;
            val_5 = 0;
            goto label_1;
            label_17:
            if(true <= val_5)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            if(((0 + 0) + 16) <= val_5)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            SRDebugger.Services.IPinnedUIService val_1 = SRDebugger.Internal.Service.PinnedUI;
            if(0 <= val_5)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 0;
            var val_8 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_11;
            }
            
            var val_7 = 0;
            label_13:
            if((mem[1179403735] + 0) == null)
            {
                goto label_12;
            }
            
            val_7 = val_7 + 1;
            if(((uint)val_7 & 65535) < mem[1179403825])
            {
                goto label_13;
            }
            
            label_11:
            val_6 = 0;
            goto label_14;
            label_12:
            var val_2 = mem[1179403735] + 0;
            val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
            val_6 = val_8 + 244;
            label_14:
            val_4 = val_4;
            (0 + 0) + 16.IsSelected = false;
            val_5 = 1;
            label_1:
            if(val_5 < mem[1152921513625470076].Count)
            {
                goto label_17;
            }
        
        }
        private void CommitPinnedOptions()
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
            label_32:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            if((SL + 40 + 188) == 0)
            {
                goto label_5;
            }
            
            SRDebugger.Services.IPinnedUIService val_4 = SRDebugger.Internal.Service.PinnedUI;
            var val_13 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_7;
            }
            
            var val_12 = 0;
            label_9:
            if((mem[1179403735] + 0) == null)
            {
                goto label_8;
            }
            
            val_12 = val_12 + 1;
            if(((uint)val_12 & 65535) < mem[1179403825])
            {
                goto label_9;
            }
            
            label_7:
            val_12 = 0;
            goto label_10;
            label_8:
            var val_5 = mem[1179403735] + 0;
            val_13 = val_13 + (((mem[1179403735] + 0) + 4) << 3);
            val_12 = val_13 + 244;
            label_10:
            if(0 == 0)
            {
                goto label_11;
            }
            
            label_5:
            if((SL + 40 + 188) != 0)
            {
                goto label_32;
            }
            
            SRDebugger.Services.IPinnedUIService val_6 = SRDebugger.Internal.Service.PinnedUI;
            var val_16 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_16;
            }
            
            var val_14 = 0;
            label_18:
            if((mem[1179403735] + 0) == null)
            {
                goto label_17;
            }
            
            val_14 = val_14 + 1;
            if(((uint)val_14 & 65535) < mem[1179403825])
            {
                goto label_18;
            }
            
            label_16:
            val_13 = 0;
            goto label_19;
            label_11:
            SRDebugger.Services.IPinnedUIService val_7 = SRDebugger.Internal.Service.PinnedUI;
            var val_18 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_21;
            }
            
            var val_15 = 0;
            label_23:
            if((mem[1179403735] + 0) == null)
            {
                goto label_22;
            }
            
            val_15 = val_15 + 1;
            if(((uint)val_15 & 65535) < mem[1179403825])
            {
                goto label_23;
            }
            
            label_21:
            val_14 = 0;
            goto label_32;
            label_17:
            var val_8 = mem[1179403735] + 0;
            val_16 = val_16 + (((mem[1179403735] + 0) + 4) << 3);
            val_13 = val_16 + 244;
            label_19:
            if(0 == 0)
            {
                goto label_32;
            }
            
            SRDebugger.Services.IPinnedUIService val_9 = SRDebugger.Internal.Service.PinnedUI;
            var val_19 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_27;
            }
            
            var val_17 = 0;
            label_29:
            if((mem[1179403735] + 0) == null)
            {
                goto label_28;
            }
            
            val_17 = val_17 + 1;
            if(((uint)val_17 & 65535) < mem[1179403825])
            {
                goto label_29;
            }
            
            label_27:
            val_15 = 0;
            goto label_32;
            label_22:
            var val_10 = mem[1179403735] + 0;
            val_18 = val_18 + (((mem[1179403735] + 0) + 4) << 3);
            val_14 = val_18 + 220;
            goto label_32;
            label_28:
            var val_11 = mem[1179403735] + 0;
            val_19 = val_19 + (((mem[1179403735] + 0) + 4) << 3);
            val_15 = val_19 + 228;
            goto label_32;
            label_2:
            0.Dispose();
        }
        private void RefreshCategorySelection()
        {
            var val_4;
            this._isTogglingCategory = true;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_13:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            var val_5 = 0;
            label_10:
            if(val_5 >= (val_3 + 12 + 12))
            {
                goto label_5;
            }
            
            if((val_3 + 12 + 12) <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = val_3 + 12 + 8;
            val_4 = val_4 + 0;
            val_5 = val_5 + 1;
            if(((val_3 + 12 + 8 + 0) + 16 + 40 + 188) != 0)
            {
                goto label_10;
            }
            
            val_4 = 0;
            goto label_11;
            label_5:
            val_4 = 1;
            label_11:
            val_3 + 8.IsSelected = true;
            goto label_13;
            label_2:
            Dispose();
            this._isTogglingCategory = false;
        }
        private void OnOptionSelectionToggle(bool selected)
        {
            if(this._isTogglingCategory == true)
            {
                    return;
            }
            
            R4.RefreshCategorySelection();
            R4.CommitPinnedOptions();
        }
        private void OnCategorySelectionToggle(SRDebugger.UI.Tabs.OptionsTabController.CategoryInstance category, bool selected)
        {
            var val_1 = 0;
            this._isTogglingCategory = true;
            goto label_1;
            label_7:
            if(true <= val_1)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            (0 + 0) + 16.IsSelected = selected;
            val_1 = 1;
            label_1:
            if(val_1 < ((0 + 0) + 16))
            {
                goto label_7;
            }
            
            this._isTogglingCategory = false;
            this.CommitPinnedOptions();
        }
        protected void Populate()
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            SRDebugger.Services.IOptionsService val_2 = SRDebugger.Internal.Service.Options;
            if(mem[1179403825] == 0)
            {
                goto label_2;
            }
            
            var val_13 = 0;
            label_4:
            if((mem[1179403735] + 0) == null)
            {
                goto label_3;
            }
            
            val_13 = val_13 + 1;
            if(((uint)val_13 & 65535) < mem[1179403825])
            {
                goto label_4;
            }
            
            label_2:
            val_13 = 0;
            goto label_5;
            label_3:
            var val_3 = mem[1179403735] + 0;
            var val_14 = (mem[1179403735] + 0) + 4;
            val_14 = 1179403647 + (val_14 << 3);
            val_13 = val_14 + 220;
            label_5:
            if(mem[1179403825] == 0)
            {
                goto label_7;
            }
            
            var val_15 = 0;
            label_9:
            if((mem[1179403735] + 0) == null)
            {
                goto label_8;
            }
            
            val_15 = val_15 + 1;
            if(((uint)val_15 & 65535) < mem[1179403825])
            {
                goto label_9;
            }
            
            label_7:
            val_14 = 0;
            goto label_10;
            label_8:
            var val_4 = mem[1179403735] + 0;
            var val_16 = (mem[1179403735] + 0) + 4;
            val_16 = 1179403647 + (val_16 << 3);
            val_14 = val_16 + 188;
            label_10:
            label_27:
            var val_18 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_12;
            }
            
            var val_17 = 0;
            label_14:
            if((mem[1179403735] + 0) == null)
            {
                goto label_13;
            }
            
            val_17 = val_17 + 1;
            if(((uint)val_17 & 65535) < mem[1179403825])
            {
                goto label_14;
            }
            
            label_12:
            val_15 = 0;
            goto label_15;
            label_13:
            var val_5 = mem[1179403735] + 0;
            val_18 = val_18 + (((mem[1179403735] + 0) + 4) << 3);
            val_15 = val_18 + 188;
            label_15:
            if(0 == 0)
            {
                goto label_16;
            }
            
            var val_20 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_18;
            }
            
            var val_19 = 0;
            label_20:
            if((mem[1179403735] + 0) == null)
            {
                goto label_19;
            }
            
            val_19 = val_19 + 1;
            if(((uint)val_19 & 65535) < mem[1179403825])
            {
                goto label_20;
            }
            
            label_18:
            val_16 = 0;
            goto label_21;
            label_19:
            var val_6 = mem[1179403735] + 0;
            val_20 = val_20 + (((mem[1179403735] + 0) + 4) << 3);
            val_16 = val_20 + 188;
            label_21:
            if((TryGetValue(key:  0, value: out  UnityEngine.Material val_7 = 429297860)) != true)
            {
                    System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_9 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
                Add(key:  0, value:  80883712);
            }
            
            Add(item:  0);
            goto label_27;
            label_16:
            if(0 == 0)
            {
                goto label_28;
            }
            
            var val_22 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_29;
            }
            
            var val_21 = 0;
            label_31:
            if((mem[1179403735] + 0) == null)
            {
                goto label_30;
            }
            
            val_21 = val_21 + 1;
            if(((uint)val_21 & 65535) < mem[1179403825])
            {
                goto label_31;
            }
            
            label_29:
            val_17 = 0;
            goto label_32;
            label_30:
            var val_10 = mem[1179403735] + 0;
            val_22 = val_22 + (((mem[1179403735] + 0) + 4) << 3);
            val_17 = val_22 + 188;
            label_32:
            label_28:
            if(0 != 1)
            {
                    if(0 > 1)
            {
                    0 = 1;
            }
            
                var val_23 = 0;
                val_23 = 0 - val_23;
                val_18 = val_23 + 1;
            }
            else
            {
                    val_18 = 0;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_11 = 0.GetEnumerator();
            label_40:
            if(0.MoveNext() == false)
            {
                goto label_37;
            }
            
            if(0 == 0)
            {
                goto label_40;
            }
            
            this.CreateCategory(title:  R4, options:  0);
            goto label_40;
            label_37:
            0.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            mem[1152921513626091540].SetActive(value:  false);
        }
        protected void CreateCategory(string title, System.Collections.Generic.List<SRDebugger.Internal.OptionDefinition> options)
        {
            SRDebugger.Internal.OptionDefinition val_9;
            var val_17;
            System.Comparison<SRDebugger.Internal.OptionDefinition> val_19;
            var val_20;
            object val_1 = new System.Object();
            typeof(OptionsTabController.<>c__DisplayClass30_0).__il2cppRuntimeField_8 = this;
            val_17 = null;
            val_17 = null;
            val_19 = OptionsTabController.<>c.<>9__30_0;
            if(val_19 == 0)
            {
                    val_19 = null;
                val_19 = new System.Comparison<WordForest.NewsArticle>(object:  OptionsTabController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(429406096));
                OptionsTabController.<>c.<>9__30_0 = val_19;
            }
            
            options.Sort(comparison:  7933952);
            UnityEngine.RectTransform val_3 = SRInstantiate.Instantiate<UnityEngine.RectTransform>(prefab:  this.CategoryGroupPrefab);
            typeof(OptionsTabController.<>c__DisplayClass30_0).__il2cppRuntimeField_C = new OptionsTabController.CategoryInstance(group:  this.CategoryGroupPrefab);
            this._categories.Add(item:  416133120);
            UnityEngine.Transform val_5 = this.CategoryGroupPrefab.CachedTransform;
            this.CategoryGroupPrefab.SetParent(parent:  this.ContentContainer, worldPositionStays:  false);
            this.CategoryGroupPrefab.SelectionModeEnabled = false;
            UnityEngine.Events.UnityAction<System.Boolean> val_6 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  416186368, method:  new IntPtr(429427600));
            OptionsTabController.CategoryInstance.__il2cppRuntimeField_30 + 184.AddListener(call:  162353152);
            List.Enumerator<T> val_7 = GetEnumerator();
            label_48:
            if(MoveNext() == false)
            {
                goto label_18;
            }
            
            SRDebugger.UI.Controls.OptionsControlBase val_10 = SRDebugger.Internal.OptionControlFactory.CreateControl(from:  val_9, categoryPrefix:  title);
            if(val_9 != 0)
            {
                goto label_21;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_9 + 8;
            string val_12 = SRF.SRFStringExtensions.Fmt(formatString:  429430672, args:  472754880);
            UnityEngine.Debug.LogError(message:  429430672);
            goto label_48;
            label_21:
            Add(item:  val_9);
            UnityEngine.Transform val_13 = val_9.CachedTransform;
            val_9.SetParent(parent:  this.CategoryGroupPrefab + 36, worldPositionStays:  false);
            SRDebugger.Services.IPinnedUIService val_14 = SRDebugger.Internal.Service.PinnedUI;
            var val_18 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_37;
            }
            
            var val_17 = 0;
            label_39:
            if((mem[1179403735] + 0) == null)
            {
                goto label_38;
            }
            
            val_17 = val_17 + 1;
            if(((uint)val_17 & 65535) < mem[1179403825])
            {
                goto label_39;
            }
            
            label_37:
            val_20 = 0;
            goto label_40;
            label_38:
            var val_15 = mem[1179403735] + 0;
            val_18 = val_18 + (((mem[1179403735] + 0) + 4) << 3);
            val_20 = val_18 + 244;
            label_40:
            val_9.IsSelected = false;
            val_9.SelectionModeEnabled = false;
            UnityEngine.Events.UnityAction<System.Boolean> val_16 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  429458976, method:  new IntPtr(429431904));
            val_9 + 40 + 184.AddListener(call:  162353152);
            mem[1152921513626240588].Add(key:  val_9, value:  val_9);
            mem[1152921513626240580].Add(item:  val_9);
            goto label_48;
            label_18:
            Dispose();
        }
        private void Clear()
        {
            List.Enumerator<T> val_1 = GetEnumerator();
            label_7:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            UnityEngine.GameObject val_4 = val_3 + 8.gameObject;
            UnityEngine.Object.Destroy(obj:  val_3 + 8);
            goto label_7;
            label_2:
            Dispose();
            this._categories.Clear();
            this._controls.Clear();
            this._options.Clear();
        }
        public OptionsTabController()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this._controls = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this._categories = null;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this._options = null;
        }
    
    }

}
