using UnityEngine;

namespace SRDebugger.UI
{
    public class MobileMenuController : SRMonoBehaviourEx
    {
        // Fields
        private UnityEngine.UI.Button _closeButton;
        private float _maxMenuWidth;
        private float _peekAmount;
        private float _targetXPosition;
        public UnityEngine.RectTransform Content;
        public UnityEngine.RectTransform Menu;
        public UnityEngine.UI.Button OpenButton;
        public SRDebugger.UI.Other.SRTabController TabController;
        
        // Properties
        public float PeekAmount { get; }
        public float MaxMenuWidth { get; }
        
        // Methods
        public float get_PeekAmount()
        {
            return (float)S0;
        }
        public float get_MaxMenuWidth()
        {
            return (float)S0;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            UnityEngine.Transform val_1 = this.Menu.parent;
            if(this.Menu != 0)
            {
                    if(null != null)
            {
                    this.Menu = 0;
            }
            
                0 = this.Menu;
            }
            
            object val_2 = this.Menu.GetComponent<System.Object>();
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  null, y:  null);
            this.Menu.pivot = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  null, y:  null);
            this.Menu.offsetMin = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  null, y:  null);
            this.Menu.offsetMax = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            UnityEngine.Rect val_6 = rect;
            float val_7 = width;
            this.Menu.SetSizeWithCurrentAnchors(axis:  0, size:  UnityEngine.Mathf.Clamp(value:  422622816 - this._peekAmount, min:  val_6.m_YMin, max:  val_6.m_Width));
            UnityEngine.Rect val_10 = rect;
            float val_11 = height;
            this.Menu.SetSizeWithCurrentAnchors(axis:  1, size:  val_11);
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_11, y:  val_10.m_YMin);
            this.Menu.anchoredPosition = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
            bool val_13 = UnityEngine.Object.op_Equality(x:  this._closeButton, y:  0);
            if(val_13 == true)
            {
                    val_13 = this;
                this.CreateCloseButton();
            }
            
            UnityEngine.GameObject val_14 = this.OpenButton.gameObject;
            this.OpenButton.SetActive(value:  true);
            System.Action<System.Threading.Tasks.Task, System.Object> val_15 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  422634864, method:  new IntPtr(422608816));
            this.TabController.add_ActiveTabChanged(value:  7507968);
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            object val_1 = this.Menu.GetComponent<System.Object>();
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  null, y:  null);
            this.Content.anchoredPosition = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            UnityEngine.GameObject val_3 = this._closeButton.gameObject;
            this._closeButton.SetActive(value:  false);
            UnityEngine.GameObject val_4 = this.OpenButton.gameObject;
            this.OpenButton.SetActive(value:  false);
            System.Action<System.Threading.Tasks.Task, System.Object> val_5 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  422812400, method:  new IntPtr(422608816));
            this.TabController.remove_ActiveTabChanged(value:  7507968);
        }
        private void CreateCloseButton()
        {
            var val_15;
            UnityEngine.GameObject val_1 = SRF.SRFTransformExtensions.CreateChild(t:  this.Content, name:  422920880);
            if(this.Content != 0)
            {
                    object val_2 = this.Content.AddComponent<System.Object>();
                val_15 = this.Content;
            }
            else
            {
                    object val_3 = 0.AddComponent<System.Object>();
                val_15 = 0;
            }
            
            object val_4 = this.Content.AddComponent<System.Object>();
            UnityEngine.RectTransform val_5 = SRF.SRFGameObjectExtensions.GetComponentOrAdd<UnityEngine.RectTransform>(obj:  this.Content);
            if(val_15 != 0)
            {
                    val_15.overrideSorting = true;
            }
            else
            {
                    val_15.overrideSorting = true;
            }
            
            val_15.sortingOrder = 122;
            object val_6 = this.Content.AddComponent<System.Object>();
            this.SetRectSize(rect:  this.Content);
            UnityEngine.GameObject val_7 = SRF.SRFTransformExtensions.CreateChild(t:  this.Content, name:  422926112);
            if(this.Content != 0)
            {
                    object val_8 = this.Content.AddComponent<System.Object>();
                this.SetRectSize(rect:  this.Content);
            }
            else
            {
                    object val_9 = 0.AddComponent<System.Object>();
                this.SetRectSize(rect:  0);
            }
            
            object val_10 = this.Content.AddComponent<System.Object>();
            UnityEngine.Color val_11 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            object val_12 = this.Content.AddComponent<System.Object>();
            this._closeButton = this.Content;
            this.Content.transition = 0;
            UnityEngine.Events.UnityAction val_13 = new UnityEngine.Events.UnityAction(object:  422963520, method:  new IntPtr(422934400));
            this._closeButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.GameObject val_14 = this._closeButton.gameObject;
            this._closeButton.SetActive(value:  false);
        }
        private void SetRectSize(UnityEngine.RectTransform rect)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  null, y:  null);
            rect.anchorMin = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  null, y:  null);
            rect.anchorMax = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            UnityEngine.Rect val_3 = rect;
            rect.SetSizeWithCurrentAnchors(axis:  0, size:  width);
            UnityEngine.Rect val_5 = rect;
            rect.SetSizeWithCurrentAnchors(axis:  1, size:  height);
        }
        private void CloseButtonClicked()
        {
            this.Close();
        }
        protected override void Update()
        {
            var val_2;
            float val_10;
            this.Update();
            UnityEngine.Vector2 val_1 = anchoredPosition;
            val_10 = this._targetXPosition;
            val_10 = this._targetXPosition;
            val_10 = this._targetXPosition;
            float val_10 = System.Math.Abs(this._targetXPosition - val_2);
            UnityEngine.Vector2 val_4 = anchoredPosition;
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_8.x, y:  val_8.y);
            this.Content.anchoredPosition = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
        }
        private void TabControllerOnActiveTabChanged(SRDebugger.UI.Other.SRTabController srTabController, SRDebugger.UI.Other.SRTab srTab)
        {
            this.Close();
        }
        public void Open()
        {
            UnityEngine.Rect val_1 = rect;
            float val_2 = width;
            this._targetXPosition = ;
            UnityEngine.GameObject val_3 = this._closeButton.gameObject;
            this._closeButton.SetActive(value:  true);
        }
        public void Close()
        {
            this._targetXPosition = 0f;
            UnityEngine.GameObject val_1 = this._closeButton.gameObject;
            this._closeButton.SetActive(value:  false);
        }
        public MobileMenuController()
        {
            this._maxMenuWidth = 185f;
            this._peekAmount = 45f;
        }
    
    }

}
