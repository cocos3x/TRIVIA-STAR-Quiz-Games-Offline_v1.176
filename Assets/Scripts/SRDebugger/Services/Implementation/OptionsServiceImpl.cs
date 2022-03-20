using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    public class OptionsServiceImpl : IOptionsService
    {
        // Fields
        private System.EventHandler OptionsUpdated;
        private System.EventHandler<System.ComponentModel.PropertyChangedEventArgs> OptionsValueUpdated;
        private readonly System.Collections.Generic.Dictionary<object, System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition>> _optionContainerLookup;
        private readonly System.Collections.Generic.List<SRDebugger.Internal.OptionDefinition> _options;
        private readonly System.Collections.Generic.IList<SRDebugger.Internal.OptionDefinition> _optionsReadonly;
        
        // Properties
        public System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition> Options { get; }
        
        // Methods
        public void add_OptionsUpdated(System.EventHandler value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.OptionsUpdated, b:  value);
            if(this.OptionsUpdated == 0)
            {
                goto label_1;
            }
            
            val_2 = this.OptionsUpdated;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.OptionsUpdated != 1152921513671243736)
            {
                goto label_3;
            }
        
        }
        public void remove_OptionsUpdated(System.EventHandler value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.OptionsUpdated, value:  value);
            if(this.OptionsUpdated == 0)
            {
                goto label_1;
            }
            
            val_2 = this.OptionsUpdated;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.OptionsUpdated != 1152921513671372120)
            {
                goto label_3;
            }
        
        }
        public void add_OptionsValueUpdated(System.EventHandler<System.ComponentModel.PropertyChangedEventArgs> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.OptionsValueUpdated, b:  value);
            if(this.OptionsValueUpdated == 0)
            {
                goto label_1;
            }
            
            val_2 = this.OptionsValueUpdated;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.OptionsValueUpdated != 1152921513671500508)
            {
                goto label_3;
            }
        
        }
        public void remove_OptionsValueUpdated(System.EventHandler<System.ComponentModel.PropertyChangedEventArgs> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.OptionsValueUpdated, value:  value);
            if(this.OptionsValueUpdated == 0)
            {
                goto label_1;
            }
            
            val_2 = this.OptionsValueUpdated;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.OptionsValueUpdated != 1152921513671628892)
            {
                goto label_3;
            }
        
        }
        public System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition> get_Options()
        {
        
        }
        public OptionsServiceImpl()
        {
            var val_5;
            var val_6;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this._optionContainerLookup = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this._options = null;
            System.Collections.ObjectModel.ReadOnlyCollection<System.TimeZoneInfo> val_3 = new System.Collections.ObjectModel.ReadOnlyCollection<System.TimeZoneInfo>(list:  this._options);
            this._optionsReadonly = null;
            var val_5 = 24228078;
            val_5 = 11408224 + val_5;
            if(val_5 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_5 = null;
            val_5 = null;
            this.AddContainer(obj:  SROptions._current);
            if(val_5 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_6 = null;
            val_6 = null;
            SROptionsPropertyChanged val_4 = new SROptionsPropertyChanged(object:  475094864, method:  new IntPtr(475069840));
            SROptions._current.add_PropertyChanged(value:  349999104);
        }
        public void Scan(object obj)
        {
            this.AddContainer(obj:  obj);
        }
        public void AddContainer(object obj)
        {
            System.Collections.Generic.Dictionary<System.Object, System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition>> val_7;
            System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition> val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            if((this._optionContainerLookup.ContainsKey(key:  obj)) != true)
            {
                    System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition> val_2 = SRDebugger.Internal.SRDebuggerUtil.ScanForOptions(obj:  obj);
                val_7 = this._optionContainerLookup;
                val_8 = obj;
                val_7.Add(key:  obj, value:  val_8);
                val_7 = 0;
                val_7 = val_7 + 1;
                val_9 = val_8;
                if(val_8 < 1)
            {
                    return;
            }
            
                val_7 = this._options;
                val_7.AddRange(collection:  val_8);
                this.OnOptionsUpdated();
                val_10 = 1152921504717017088;
                if(obj == 0)
            {
                    return;
            }
            
                val_11 = 0;
                System.ComponentModel.PropertyChangedEventHandler val_4 = new System.ComponentModel.PropertyChangedEventHandler(object:  475352800, method:  new IntPtr(475326608));
                val_12 = 0;
                val_11 = val_11 + 1;
                val_12 = (uint)val_11 & 65535;
                val_13 = obj;
            }
            else
            {
                    System.Exception val_6 = new System.Exception(message:  475327632);
            }
        
        }
        public void RemoveContainer(object obj)
        {
            var val_11;
            var val_12;
            SRDebugger.Internal.OptionDefinition val_13;
            var val_14;
            var val_15;
            System.ComponentModel.PropertyChangedEventHandler val_16;
            var val_17;
            var val_18;
            var val_19;
            if((this._optionContainerLookup.ContainsKey(key:  obj)) == false)
            {
                    return;
            }
            
            System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition> val_2 = this._optionContainerLookup.Item[obj];
            bool val_3 = this._optionContainerLookup.Remove(key:  obj);
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = this._optionContainerLookup;
            val_12 = this;
            val_13 = this._optionContainerLookup;
            label_22:
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_14 = val_13;
            if(val_13 == 0)
            {
                goto label_15;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_15 = val_13;
            bool val_7 = this._options.Remove(item:  val_13);
            goto label_22;
            label_15:
            val_16 = 0;
            if(val_13 != 0)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_17 = val_13;
            }
            
            val_18 = 1152921504717017088;
            if(obj == 0)
            {
                goto label_29;
            }
            
            val_16 = null;
            var val_15 = 0;
            val_16 = new System.ComponentModel.PropertyChangedEventHandler(object:  475504736, method:  new IntPtr(475326608));
            object val_16 = obj;
            if((obj + 178) == 0)
            {
                goto label_30;
            }
            
            label_32:
            val_18 = 0;
            val_13 = mem[obj + 88 + 0];
            val_13 = obj + 88 + 0;
            if(val_13 == null)
            {
                goto label_31;
            }
            
            val_15 = val_15 + 1;
            val_18 = (uint)val_15 & 65535;
            if(val_18 < (obj + 178))
            {
                goto label_32;
            }
            
            label_30:
            val_19 = obj;
            goto label_33;
            label_31:
            var val_10 = (obj + 88) + 0;
            val_16 = val_16 + (((obj + 88 + 0) + 4) << 3);
            val_19 = val_16 + 196;
            label_33:
            label_29:
            this.OnOptionsUpdated();
        }
        private void OnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if(this.OptionsValueUpdated == 0)
            {
                    return;
            }
            
            this.OptionsValueUpdated.Invoke(sender:  475650528, e:  propertyChangedEventArgs);
        }
        private void OnSROptionsPropertyChanged(object sender, string propertyName)
        {
            System.ComponentModel.PropertyChangedEventArgs val_1 = new System.ComponentModel.PropertyChangedEventArgs(propertyName:  propertyName);
            this.OnPropertyChanged(sender:  propertyName, propertyChangedEventArgs:  110755840);
        }
        private void OnOptionsUpdated()
        {
            var val_1;
            if(this.OptionsUpdated == 0)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            this.OptionsUpdated.Invoke(sender:  475907296, e:  System.EventArgs.Empty);
        }
    
    }

}
