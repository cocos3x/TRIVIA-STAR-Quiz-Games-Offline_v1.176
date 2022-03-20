using UnityEngine;

namespace SRF.UI
{
    public class SRNumberSpinner : InputField
    {
        // Fields
        private double _currentValue;
        private double _dragStartAmount;
        private double _dragStep;
        public float DragSensitivity;
        public double MaxValue;
        public double MinValue;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            if(1152921513582730960 == 2)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  385925152);
            R4.contentType = 3;
        }
        public override void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_5;
            var val_9;
            UnityEngine.GameObject val_10;
            val_5 = 35634709;
            if(true == 0)
            {
                    return;
            }
            
            if((eventData.<dragging>k__BackingField) == true)
            {
                    return;
            }
            
            UnityEngine.EventSystems.EventSystem val_1 = UnityEngine.EventSystems.EventSystem.current;
            val_9 = 0;
            UnityEngine.GameObject val_2 = R5.gameObject;
            val_10 = R5;
            val_9.SetSelectedGameObject(selected:  val_10, pointer:  R4);
            R5.OnPointerClick(eventData:  R4);
            if(((R5 + 172) != 0) && ((R5 + 172.active) != false))
            {
                    R5.UpdateLabel();
            }
        
        }
        public override void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        public override void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        public override void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_10;
            var val_11;
            var val_12;
            val_10 = 35634710;
            if(true == 0)
            {
                    return;
            }
            
            float val_10 = System.Math.Abs(S16);
            float val_11 = System.Math.Abs(eventData.<delta>k__BackingField);
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Transform val_2 = this.parent;
            val_11 = 1152921504765685760;
            if(386432208 == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_4 = this.gameObject;
            val_10 = 1152921504818614272;
            UnityEngine.GameObject val_5 = UnityEngine.EventSystems.ExecuteEvents.GetEventHandler<UnityEngine.EventSystems.ISelectHandler>(root:  386432208);
            eventData.<pointerDrag>k__BackingField = this;
            if(386432208 == 0)
            {
                    return;
            }
            
            val_11 = 10689492 + 24945533;
            if(val_11 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_12 = null;
            val_12 = null;
            bool val_7 = UnityEngine.EventSystems.ExecuteEvents.Execute<UnityEngine.EventSystems.IUpdateSelectedHandler>(target:  eventData.<pointerDrag>k__BackingField, eventData:  eventData, functor:  UnityEngine.EventSystems.ExecuteEvents.s_BeginDragHandler);
        }
        public override void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_3;
            var val_9;
            var val_11;
            var val_13;
            double val_14;
            var val_16;
            val_9 = 35634711;
            if(0 == 0)
            {
                    return;
            }
            
            val_9 = 1152921504620371968;
            double val_1 = System.Math.Abs(this._dragStep) * D16;
            this._currentValue = this._currentValue;
            double val_2 = System.Math.Round(value:  null, digits:  System.Math.__il2cppRuntimeField_cctor_finished);
            this._currentValue = System.Math.__il2cppRuntimeField_cctor_finished;
            mem2[0] = this.MaxValue;
            val_11 = this.MinValue;
            mem2[0] = this.MinValue;
            val_13 = val_3;
            val_14 = -1;
            double val_5 =  + ;
            if((System.Math.__il2cppRuntimeField_cctor_finished & 1) != 0)
            {
                    val_16 = ;
            }
            
            if(System.Math.__il2cppRuntimeField_cctor_finished == 0)
            {
                     = -;
            }
            
            string val_8 = this.DragSensitivity.ToString();
            this.text = 386544460;
        }
        public override void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this == 0)
            {
                    return;
            }
            
            eventData.Use();
            if(eventData == 0)
            {
                    return;
            }
            
            this.DeactivateInputField();
            this.SendOnSubmit();
        }
        public SRNumberSpinner()
        {
            this.MaxValue = 0;
            mem[1152921513583574748] = 2146435071;
            mem[1152921513583574756] = 1048576;
            this.MinValue = 0;
            this.DragSensitivity = 0.01f;
        }
    
    }

}
