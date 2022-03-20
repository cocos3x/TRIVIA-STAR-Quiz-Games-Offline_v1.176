using UnityEngine;

namespace SLC.Minigames.WordBalloon
{
    public class WordBalloonLetterTile : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler
    {
        // Fields
        private UnityEngine.UI.Text label;
        private UnityEngine.UI.Image sprite;
        private string value;
        public bool interactable;
        private SLC.Minigames.WordBalloon.WordBalloonLetterSlot parentSlot;
        private SLC.Minigames.WordBalloon.LetterTileState currentState;
        private bool isHighlighted;
        private DG.Tweening.Tweener moveTween;
        
        // Properties
        public string Value { get; }
        
        // Methods
        public string get_Value()
        {
        
        }
        public void Initialize(SLC.Minigames.WordBalloon.WordBalloonLetterSlot slotToAttachTo, string letter)
        {
            var val_4;
            this.parentSlot = slotToAttachTo;
            this.value = letter;
            this.currentState = 0;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  992989360, method:  new IntPtr(992964336));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_3C, b:  7454720);
            val_4 = public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_3C;
            if(val_4 != 0)
            {
                    if(val_4 == null)
            {
                goto label_7;
            }
            
            }
            
            val_4 = 0;
            label_7:
            public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_3C = val_4;
            this.UpdatePosition(isAnimated:  false, delayed:  true);
        }
        private void OnDestroy()
        {
            var val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  993113648, method:  new IntPtr(992964336));
            System.Delegate val_3 = System.Delegate.Remove(source:  public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_3C, value:  7454720);
            val_4 = public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_3C;
            if(val_4 != 0)
            {
                    if(val_4 == null)
            {
                goto label_6;
            }
            
            }
            
            val_4 = 0;
            label_6:
            public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_3C = val_4;
        }
        private void OnGridChanged()
        {
            this.UpdatePosition(isAnimated:  true, delayed:  true);
        }
        private void UpdatePosition(bool isAnimated, bool delayed)
        {
            if(delayed != false)
            {
                    System.Collections.IEnumerator val_1 = this.UpdatePositionDelayed(isAnimated:  isAnimated);
                UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  993345840);
                return;
            }
            
            if(this.moveTween != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.moveTween, complete:  false);
            }
            
            UnityEngine.GameObject val_3 = this.gameObject;
            UnityEngine.Transform val_4 = this.transform;
            UnityEngine.Transform val_5 = this.parentSlot.transform;
            if(isAnimated != false)
            {
                    UnityEngine.Vector3 val_6 = position;
                DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOMove(target:  993345840, endValue:  new UnityEngine.Vector3(), duration:  val_6.x, snapping:  true);
                object val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  993345840, ease:  30);
                this.moveTween = this;
                return;
            }
            
            UnityEngine.Vector3 val_9 = position;
            this.position = new UnityEngine.Vector3();
        }
        private System.Collections.IEnumerator UpdatePositionDelayed(bool isAnimated)
        {
            typeof(WordBalloonLetterTile.<UpdatePositionDelayed>d__14).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WordBalloonLetterTile.<UpdatePositionDelayed>d__14).__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            typeof(WordBalloonLetterTile.<UpdatePositionDelayed>d__14).__il2cppRuntimeField_14 = isAnimated;
        }
        public void ChangeState(SLC.Minigames.WordBalloon.LetterTileState incomingState)
        {
            float val_2;
            float val_3;
            float val_4;
            UnityEngine.UI.Image val_6;
            float val_7;
            float val_8;
            float val_9;
            float val_11;
            if(incomingState == 1)
            {
                goto label_0;
            }
            
            if(incomingState != 0)
            {
                goto label_3;
            }
            
            if(this.isHighlighted == false)
            {
                goto label_2;
            }
            
            this.Highlight();
            goto label_3;
            label_0:
            UnityEngine.Color val_1 = color;
            val_6 = this.sprite;
            val_7 = val_2;
            val_8 = val_3;
            val_9 = val_4;
            val_11 = 16051;
            val_11 = 1051931443;
            goto label_6;
            label_2:
            UnityEngine.Color val_5 = color;
            val_6 = this.sprite;
            val_7 = val_2;
            val_8 = val_3;
            val_9 = val_4;
            val_11 = 1f;
            label_6:
            val_6.color = new UnityEngine.Color() {r = val_7, g = val_8, b = val_9, a = val_11};
            label_3:
            this.currentState = incomingState;
        }
        public void Highlight()
        {
            float val_2;
            float val_3;
            float val_4;
            UnityEngine.Color val_1 = color;
            this.sprite.color = new UnityEngine.Color() {r = val_2, g = val_3, b = val_4, a = 0.15f};
            this.isHighlighted = true;
        }
        public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.interactable == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_38 = 1;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            RegisterSlotForInput(incomingSlot:  this.parentSlot);
        }
        public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.interactable == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnPointerUp(eventData:  MonoSingleton<T>.__il2cppRuntimeField_cctor_finished);
        }
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData pointerEventData)
        {
            if(this.interactable == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            RegisterSlotForInput(incomingSlot:  this.parentSlot);
        }
        public WordBalloonLetterTile()
        {
            this.interactable = true;
        }
    
    }

}
