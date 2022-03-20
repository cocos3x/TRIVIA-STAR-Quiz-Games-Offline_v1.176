using UnityEngine;

namespace SRF
{
    public sealed class RequiredFieldAttribute : Attribute
    {
        // Fields
        private bool _autoCreate;
        private bool _autoSearch;
        private bool _editorOnly;
        
        // Properties
        public bool AutoSearch { get; set; }
        public bool AutoCreate { get; set; }
        public bool EditorOnly { get; set; }
        
        // Methods
        public RequiredFieldAttribute(bool autoSearch)
        {
            this._editorOnly = true;
            this._autoSearch = autoSearch;
        }
        public RequiredFieldAttribute()
        {
            this._editorOnly = true;
        }
        public bool get_AutoSearch()
        {
            return (bool)this._autoSearch;
        }
        public void set_AutoSearch(bool value)
        {
            this._autoSearch = value;
        }
        public bool get_AutoCreate()
        {
            return (bool)this._autoCreate;
        }
        public void set_AutoCreate(bool value)
        {
            this._autoCreate = value;
        }
        public bool get_EditorOnly()
        {
            return (bool)this._editorOnly;
        }
        public void set_EditorOnly(bool value)
        {
            this._editorOnly = value;
        }
    
    }

}
