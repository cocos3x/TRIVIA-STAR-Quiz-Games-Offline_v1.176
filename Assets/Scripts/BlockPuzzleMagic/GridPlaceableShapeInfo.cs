using UnityEngine;

namespace BlockPuzzleMagic
{
    public class GridPlaceableShapeInfo : ShapeInfo
    {
        // Fields
        protected System.Collections.Generic.List<BlockPuzzleMagic.GridCell> highlightedCells;
        protected System.Collections.Generic.List<BlockPuzzleMagic.GridCell> gridBlocksUnderShapeBlocks;
        protected bool isMarkedForDiscard;
        
        // Methods
        public override void InitBlockList()
        {
            var val_2;
            this.InitBlockList();
            System.Collections.Generic.List<WGEventButtonV2> val_1 = new System.Collections.Generic.List<WGEventButtonV2>(capacity:  mem[35640147]);
            this.gridBlocksUnderShapeBlocks = null;
            val_2 = 0;
            goto label_2;
            label_5:
            this.gridBlocksUnderShapeBlocks.Add(item:  0);
            val_2 = 1;
            label_2:
            if(val_2 < this.gridBlocksUnderShapeBlocks)
            {
                goto label_5;
            }
        
        }
        protected virtual bool CanPlaceAtCurrentWorldPos(out System.Collections.Generic.List<BlockPuzzleMagic.GridCell> fittingBlocks)
        {
            float val_9;
            float val_10;
            float val_11;
            float val_12;
            var val_25;
            var val_26;
            float val_27;
            var val_28;
            UnityEngine.Object val_29;
            var val_30;
            var val_31;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_25 = 0;
            val_26 = 0;
            val_27 = "UI";
            goto label_5;
            label_54:
            this.gridBlocksUnderShapeBlocks.set_Item(index:  0, value:  0);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_28 = 0;
            if(((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_8 + 0) + 16 + 24) != 0)
            {
                    if(0 <= val_26)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_26 = 0;
                val_26 = val_26 + 0;
                val_28 = mem[(0 + 0) + 16 + 24 + 12];
                val_28 = (0 + 0) + 16 + 24 + 12;
            }
            
            if(((0 + 0) + 16 + 24 + 12 + 12) <= val_26)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_27 = (0 + 0) + 16 + 24 + 12 + 8;
            val_27 = val_27 + 0;
            UnityEngine.Vector3 val_5 = position;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 1.061822E+07f});
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
            typeof(System.String[]).__il2cppRuntimeField_10 = "UI";
            val_29 = UnityEngine.LayerMask.GetMask(layerNames:  477709520);
            int val_13 = UnityEngine.Physics2D.RaycastNonAlloc(origin:  new UnityEngine.Vector2() {x = val_11, y = val_12}, direction:  new UnityEngine.Vector2() {x = val_9, y = val_10}, results:  ((0 + 0) + 16 + 24 + 12 + 8 + 0) + 16, distance:  val_7.x, layerMask:  1065353216);
            if(val_13 < 1)
            {
                goto label_29;
            }
            
            var val_28 = 0;
            var val_29 = 16;
            label_44:
            UnityEngine.Object val_14 = 1065353216 + val_29;
            UnityEngine.Collider2D val_15 = val_14.collider;
            UnityEngine.GameObject val_16 = val_14.gameObject;
            val_29 = val_14;
            UnityEngine.GameObject val_17 = this.gameObject;
            if(val_29 == 1260532864)
            {
                goto label_35;
            }
            
            UnityEngine.Collider2D val_19 = collider;
            UnityEngine.GameObject val_20 = gameObject;
            object val_21 = GetComponentInChildren<System.Object>();
            this.gridBlocksUnderShapeBlocks.set_Item(index:  0, value:  1260532880);
            bool val_22 = UnityEngine.Object.op_Inequality(x:  1260532880, y:  0);
            if(val_22 == true)
            {
                goto label_43;
            }
            
            label_35:
            val_28 = val_28 + 1;
            val_29 = val_29 + 36;
            if(val_28 < val_13)
            {
                goto label_44;
            }
            
            label_29:
            val_25 = 0;
            val_27 = "UI";
            val_26 = val_26;
            if(val_22 == true)
            {
                goto label_45;
            }
            
            goto label_51;
            label_43:
            val_25 = 0;
            val_27 = "UI";
            val_26 = val_26;
            if(val_22 == true)
            {
                goto label_47;
            }
            
            if(val_22 != false)
            {
                    if(isFilled != true)
            {
                    if(0 != 0)
            {
                    0 = 1;
            }
            
            }
            
            }
            
            if(1 == 0)
            {
                goto label_51;
            }
            
            label_47:
            var val_30 = 0;
            val_30 = val_30 | (val_28 >> 5);
            Add(item:  1260532880);
            label_45:
            val_26 = val_26 + 1;
            label_5:
            if(val_26 < (((0 + 0) + 16 + 24 + 12 >> 5) + 12))
            {
                goto label_54;
            }
            
            val_30 = val_2;
            if(val_30 == 0)
            {
                    val_30 = val_2;
            }
            
            val_31 = 0;
            if((System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze) < 1)
            {
                    0 = 1;
            }
            
            if(((~val_30) | 1) != 1)
            {
                goto label_56;
            }
            
            mem2[0] = val_30;
            val_31 = 1;
            return (bool)val_31;
            label_51:
            val_31 = 0;
            label_56:
            mem2[0] = val_31;
            return (bool)val_31;
        }
        protected virtual void HighlightCellsMarkedByShape(System.Collections.Generic.List<BlockPuzzleMagic.GridCell> targetBlocks)
        {
            var val_3;
            var val_4;
            val_3 = 0;
            goto label_1;
            label_7:
            if(true <= val_3)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            if((this.highlightedCells.Contains(item:  (0 + 0) + 16)) != true)
            {
                    this.highlightedCells.Add(item:  (0 + 0) + 16);
            }
            
            val_3 = 1;
            label_1:
            if(val_3 < this.highlightedCells)
            {
                goto label_7;
            }
            
            val_4 = 4;
            goto label_8;
            label_18:
            if(this.highlightedCells <= ((0 + 0) + 16))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_2 = UnityEngine.Object.op_Inequality(x:  (0 + 0) + 16 + 16, y:  0);
            if(val_2 != false)
            {
                    if(val_2 <= ((0 + 0) + 16))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                2621443.SetHighlight(_colorData:  (0 + 0) + 16);
            }
            
            val_4 = 5;
            label_8:
            if((val_4 - 4) < 2621443)
            {
                goto label_18;
            }
        
        }
        protected virtual void StopHighlighting()
        {
            System.Collections.Generic.List<BlockPuzzleMagic.GridCell> val_1;
            var val_2;
            val_1 = this.highlightedCells;
            if(val_1 == 0)
            {
                    return;
            }
            
            val_2 = 0;
            goto label_2;
            label_7:
            val_1 = this.highlightedCells;
            if(val_1 == 0)
            {
                    val_1 = 0;
            }
            
            if(val_2 >= R7)
            {
                goto label_4;
            }
            
            label_8:
            if(0 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_1 = 0;
            val_1 = val_1 + 0;
            (0 + 0) + 16.StopHighlighting();
            val_1 = this.highlightedCells;
            val_2 = 1;
            label_2:
            if(val_1 == 0)
            {
                goto label_7;
            }
            
            if(val_2 < ((0 + 0) + 16))
            {
                goto label_8;
            }
            
            label_4:
            val_1.Clear();
        }
        public override void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(true == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.OnDragZen(eventData:  eventData);
        }
        protected void OnDragZen(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.OnDrag(eventData:  eventData);
            if(this == 0)
            {
                    return;
            }
        
        }
        protected void OnDragChallenge(UnityEngine.EventSystems.PointerEventData eventData)
        {
            float val_8;
            float val_9;
            float val_10;
            var val_12;
            float val_13;
            float val_14;
            float val_16;
            float val_17;
            float val_18;
            float val_25;
            float val_26;
            UnityEngine.EventSystems.PointerEventData val_59;
            float val_60;
            DG.Tweening.RotateMode val_61;
            float val_62;
            float val_63;
            var val_64;
            bool val_65;
            float val_66;
            val_59 = eventData;
            val_60 = 0;
            this.isMarkedForDiscard = false;
            if((System.String.op_Equality(a:  1261188248, b:  1235593280)) == false)
            {
                goto label_6;
            }
            
            val_61 = 1152921504901095424;
            val_62 = 1152921511021127616;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static BlockPuzzleMagic.BBLGameplayUIController MonoSingleton<BlockPuzzleMagic.BBLGameplayUIController>::get_Instance().__il2cppRuntimeField_20.BlockRaycasts) == false)
            {
                goto label_6;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_63 = mem[public static BlockPuzzleMagic.BBLGameplayUIController MonoSingleton<BlockPuzzleMagic.BBLGameplayUIController>::get_Instance().__il2cppRuntimeField_20 + 52];
            val_63 = public static BlockPuzzleMagic.BBLGameplayUIController MonoSingleton<BlockPuzzleMagic.BBLGameplayUIController>::get_Instance().__il2cppRuntimeField_20 + 52;
            if(val_59 == 0)
            {
                goto label_11;
            }
            
            UnityEngine.Camera val_5 = val_59.pressEventCamera;
            val_64 = val_59;
            goto label_12;
            label_6:
            val_65 = this.isMarkedForDiscard;
            goto label_13;
            label_11:
            UnityEngine.Camera val_6 = 0.pressEventCamera;
            val_64 = 0;
            label_12:
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 1.128564E+07f, y = eventData.<position>k__BackingField});
            UnityEngine.Vector3 val_11 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_9, z = val_10});
            UnityEngine.Vector3 val_15 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_63, y = val_13, z = val_14});
            val_62 = val_16;
            UnityEngine.Rect val_19 = rect;
            val_60 = val_17;
            bool val_20 = Contains(point:  new UnityEngine.Vector3() {x = val_62, y = val_60, z = val_18});
            this.isMarkedForDiscard = val_20;
            val_59 = val_59;
            label_13:
            if(val_20 == true)
            {
                    val_20 = 1;
            }
            
            if(this.isMarkedForDiscard == true)
            {
                    val_66 = 1;
            }
            
            if(val_20 != false)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                UnityEngine.GameObject val_22 = public static BlockPuzzleMagic.BBLGameplayUIController MonoSingleton<BlockPuzzleMagic.BBLGameplayUIController>::get_Instance().__il2cppRuntimeField_20.gameObject;
                UnityEngine.Transform val_23 = public static BlockPuzzleMagic.BBLGameplayUIController MonoSingleton<BlockPuzzleMagic.BBLGameplayUIController>::get_Instance().__il2cppRuntimeField_20.transform;
                UnityEngine.Vector3 val_24 = position;
                val_66 = val_26;
                UnityEngine.GameObject val_27 = this.gameObject;
                UnityEngine.Transform val_28 = this.transform;
                UnityEngine.Vector3 val_29 = position;
                if(1261188232 != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  1261188232, complete:  false);
            }
            
                val_63 = 0;
                DG.Tweening.Sequence val_30 = DG.Tweening.DOTween.Sequence();
                mem[1152921514457981976] = 0;
                UnityEngine.GameObject val_31 = this.gameObject;
                UnityEngine.Transform val_32 = this.transform;
                DG.Tweening.Tweener val_33 = DG.Tweening.ShortcutExtensions.DOMove(target:  1261200304, endValue:  new UnityEngine.Vector3() {x = val_25, y = val_66, z = val_8}, duration:  val_29.x, snapping:  false);
                DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  1261200304);
                UnityEngine.GameObject val_35 = this.gameObject;
                UnityEngine.Transform val_36 = this.transform;
                UnityEngine.Vector3 val_37 = UnityEngine.Vector3.zero;
                DG.Tweening.Tweener val_38 = DG.Tweening.ShortcutExtensions.DOScale(target:  1261200304, endValue:  new UnityEngine.Vector3(), duration:  val_37.x);
                DG.Tweening.Sequence val_39 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  1261200304);
                twelvegigs.Autopilot.AutopilotManager val_40 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                DG.Tweening.Sequence val_41 = DG.Tweening.DOTween.Sequence();
                UnityEngine.Transform val_42 = public static BlockPuzzleMagic.BBLGameplayUIController MonoSingleton<BlockPuzzleMagic.BBLGameplayUIController>::get_Instance().__il2cppRuntimeField_20 + 24.transform;
                val_10 = 0;
                val_9 = 0;
                val_8 = 0;
                UnityEngine.Vector3 val_43 = new UnityEngine.Vector3(x:  val_37.x, y:  val_37.y, z:  val_37.z);
                val_61 = 15820;
                val_61 = 1036831949;
                DG.Tweening.Tweener val_44 = DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  public static BlockPuzzleMagic.BBLGameplayUIController MonoSingleton<BlockPuzzleMagic.BBLGameplayUIController>::get_Instance().__il2cppRuntimeField_20 + 24, endValue:  new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z}, duration:  val_37.x, mode:  val_61);
                DG.Tweening.Sequence val_45 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  public static BlockPuzzleMagic.BBLGameplayUIController MonoSingleton<BlockPuzzleMagic.BBLGameplayUIController>::get_Instance().__il2cppRuntimeField_20 + 24);
                val_59 = 0;
                UnityEngine.Transform val_46 = public static BlockPuzzleMagic.BBLGameplayUIController MonoSingleton<BlockPuzzleMagic.BBLGameplayUIController>::get_Instance().__il2cppRuntimeField_20 + 24.transform;
                val_62 = public static BlockPuzzleMagic.BBLGameplayUIController MonoSingleton<BlockPuzzleMagic.BBLGameplayUIController>::get_Instance().__il2cppRuntimeField_20 + 24;
                val_14 = val_59;
                val_13 = val_59;
                val_12 = val_59;
                UnityEngine.Vector3 val_47 = new UnityEngine.Vector3(x:  val_37.x, y:  val_37.y, z:  val_37.z);
                DG.Tweening.Tweener val_48 = DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  val_62, endValue:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z}, duration:  val_37.x, mode:  1045220557);
                DG.Tweening.Sequence val_49 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  val_62);
                UnityEngine.Transform val_50 = public static BlockPuzzleMagic.BBLGameplayUIController MonoSingleton<BlockPuzzleMagic.BBLGameplayUIController>::get_Instance().__il2cppRuntimeField_20 + 24.transform;
                val_17 = val_59;
                val_16 = val_59;
                val_18 = val_59;
                UnityEngine.Vector3 val_51 = new UnityEngine.Vector3(x:  val_37.x, y:  val_37.y, z:  val_37.z);
                DG.Tweening.Tweener val_52 = DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  public static BlockPuzzleMagic.BBLGameplayUIController MonoSingleton<BlockPuzzleMagic.BBLGameplayUIController>::get_Instance().__il2cppRuntimeField_20 + 24, endValue:  new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z}, duration:  val_37.x, mode:  val_61);
                DG.Tweening.Sequence val_53 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  public static BlockPuzzleMagic.BBLGameplayUIController MonoSingleton<BlockPuzzleMagic.BBLGameplayUIController>::get_Instance().__il2cppRuntimeField_20 + 24);
                return;
            }
            
            if(0 != 0)
            {
                    if(val_20 != false)
            {
                    DG.Tweening.TweenExtensions.Complete(t:  val_20);
            }
            
                val_61 = 0;
                DG.Tweening.Sequence val_54 = DG.Tweening.DOTween.Sequence();
                val_62 = 0;
                mem[1152921514457981976] = 0;
                UnityEngine.GameObject val_55 = this.gameObject;
                UnityEngine.Transform val_56 = this.transform;
                DG.Tweening.Tweener val_57 = DG.Tweening.ShortcutExtensions.DOScale(target:  1261200304, endValue:  new UnityEngine.Vector3(), duration:  val_19.m_XMin);
                DG.Tweening.Sequence val_58 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  1261200304);
            }
            
            this.OnDrag(eventData:  val_59);
            if(this == 0)
            {
                    return;
            }
        
        }
        public override void SnapBackAndReset(System.Action onComplete)
        {
            this.SnapBackAndReset(onComplete:  onComplete);
            if(this.isMarkedForDiscard == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_2 = CanUsePowerup(powerupType:  0, showStoreIfOOC:  true, oocDelay:  null);
        }
        public override bool CanResolveAction()
        {
            if(this.isMarkedForDiscard != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                return (bool)CanUsePowerup(powerupType:  0, showStoreIfOOC:  false, oocDelay:  null);
            }
            
            if(R1 > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        protected virtual void Discard()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UsePowerup(powerupType:  0, freeUsage:  false);
        }
        public override void Consume()
        {
            this.Consume();
        }
        public GridPlaceableShapeInfo()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.highlightedCells = null;
        }
    
    }

}
