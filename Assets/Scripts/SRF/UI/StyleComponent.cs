using UnityEngine;

namespace SRF.UI
{
    public class StyleComponent : SRMonoBehaviour
    {
        // Fields
        private SRF.UI.Style _activeStyle;
        private SRF.UI.StyleRoot _cachedRoot;
        private UnityEngine.UI.Graphic _graphic;
        private bool _hasStarted;
        private UnityEngine.UI.Image _image;
        private UnityEngine.UI.Selectable _selectable;
        private string _styleKey;
        public bool IgnoreImage;
        
        // Properties
        public string StyleKey { get; set; }
        
        // Methods
        public string get_StyleKey()
        {
        
        }
        public void set_StyleKey(string value)
        {
            this._styleKey = value;
            this.Refresh(invalidateCache:  false);
        }
        private void Start()
        {
            this.Refresh(invalidateCache:  true);
            this._hasStarted = true;
        }
        private void OnEnable()
        {
            if(this._hasStarted == false)
            {
                    return;
            }
            
            this.Refresh(invalidateCache:  false);
        }
        public void Refresh(bool invalidateCache)
        {
            SRF.UI.StyleRoot val_7;
            if((System.String.IsNullOrEmpty(value:  this._styleKey)) == false)
            {
                goto label_1;
            }
            
            label_19:
            this._activeStyle = 0;
            return;
            label_1:
            bool val_2 = UnityEngine.Object.op_Equality(x:  this._cachedRoot, y:  0);
            if(invalidateCache != false)
            {
                    SRF.UI.StyleRoot val_3 = this.GetStyleRoot();
                val_7 = this;
                this._cachedRoot = this;
            }
            else
            {
                    val_7 = this._cachedRoot;
            }
            
            if(val_7 == 0)
            {
                    UnityEngine.Debug.LogWarning(message:  390365648, context:  390402272);
                this._activeStyle = 0;
                return;
            }
            
            SRF.UI.Style val_5 = this._cachedRoot.GetStyle(key:  this._styleKey);
            if(this._cachedRoot != 0)
            {
                    this._activeStyle = this._cachedRoot;
                this.ApplyStyle();
                return;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = this._styleKey;
            string val_6 = System.String.Format(format:  390378128, args:  472754880);
            UnityEngine.Debug.LogWarning(message:  390378128, context:  390402272);
            goto label_19;
        }
        private SRF.UI.StyleRoot GetStyleRoot()
        {
            var val_9;
            UnityEngine.Transform val_1 = this.CachedTransform;
            val_9 = this;
            var val_9 = 0;
            label_15:
            object val_2 = this.GetComponentInParent<System.Object>();
            if(390539968 != 0)
            {
                    UnityEngine.Transform val_4 = val_9.CachedTransform;
                UnityEngine.Transform val_5 = this.parent;
                val_9 = val_9;
            }
            
            val_9 = val_9 + 1;
            if(val_9 >= 101)
            {
                goto label_7;
            }
            
            if(390539968 == 0)
            {
                    return;
            }
            
            if(this.enabled == true)
            {
                    return;
            }
            
            if(390539968 != 0)
            {
                goto label_15;
            }
            
            return;
            label_7:
            UnityEngine.Debug.LogWarning(message:  390515872);
        }
        private void ApplyStyle()
        {
            float val_10;
            var val_14;
            float val_15;
            UnityEngine.Sprite val_16;
            SRF.UI.Style val_17;
            SRF.UI.Style val_18;
            SRF.UI.Style val_19;
            UnityEngine.UI.Selectable val_20;
            if(this._activeStyle == 0)
            {
                    return;
            }
            
            val_15 = 1152921504765685760;
            if(this._graphic == 0)
            {
                    object val_2 = this.GetComponent<System.Object>();
                this._graphic = this;
            }
            
            if(this._selectable == 0)
            {
                    object val_4 = this.GetComponent<System.Object>();
                this._selectable = this;
            }
            
            if(this._image == 0)
            {
                    object val_6 = this.GetComponent<System.Object>();
                this._image = this;
            }
            
            if(this.IgnoreImage != true)
            {
                    if(this._image != 0)
            {
                    val_16 = this._activeStyle.Image;
                this._image.sprite = val_16;
            }
            
            }
            
            if(this._selectable != 0)
            {
                    UnityEngine.UI.Selectable val_9 = this._selectable + 88;
                val_17 = this._activeStyle;
                if(this._activeStyle == 0)
            {
                    val_17 = this._activeStyle;
            }
            
                val_18 = val_17;
                if(val_17 == 0)
            {
                    val_18 = this._activeStyle;
            }
            
                val_19 = val_18;
                if(val_18 == 0)
            {
                    val_19 = this._activeStyle;
            }
            
                val_20 = this._selectable;
                val_16;
                do
            {
                val_14 = 76 - 4;
            }
            while(val_20 != 0);
            
                val_20.colors = new UnityEngine.UI.ColorBlock() {m_NormalColor = new UnityEngine.Color() {a = val_10}, m_HighlightedColor = new UnityEngine.Color(), m_PressedColor = new UnityEngine.Color(), m_SelectedColor = new UnityEngine.Color(), m_DisabledColor = new UnityEngine.Color()};
                if(this._graphic == 0)
            {
                    return;
            }
            
                UnityEngine.Color val_12 = UnityEngine.Color.white;
                if(this._graphic != 0)
            {
                    return;
            }
            
                return;
            }
            
            if(this._graphic == 0)
            {
                    return;
            }
            
            val_20 = this._activeStyle.NormalColor;
        }
        private void SRStyleDirty()
        {
            UnityEngine.GameObject val_1 = this.CachedGameObject;
            if(this.activeInHierarchy != false)
            {
                    this.Refresh(invalidateCache:  true);
                return;
            }
            
            this._cachedRoot = 0;
        }
        public StyleComponent()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
