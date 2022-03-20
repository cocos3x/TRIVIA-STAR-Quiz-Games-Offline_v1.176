using UnityEngine;

namespace SRDebugger.Services
{
    public interface IOptionsService
    {
        // Properties
        public abstract System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition> Options { get; }
        
        // Methods
        public abstract void add_OptionsUpdated(System.EventHandler value); // 0
        public abstract void remove_OptionsUpdated(System.EventHandler value); // 0
        public abstract void add_OptionsValueUpdated(System.EventHandler<System.ComponentModel.PropertyChangedEventArgs> value); // 0
        public abstract void remove_OptionsValueUpdated(System.EventHandler<System.ComponentModel.PropertyChangedEventArgs> value); // 0
        public abstract System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition> get_Options(); // 0
        public abstract void Scan(object obj); // 0
        public abstract void AddContainer(object obj); // 0
        public abstract void RemoveContainer(object obj); // 0
    
    }

}
