using UnityEngine;

namespace BlockPuzzleMagic
{
    public class BBLGameplayUIHelper
    {
        // Methods
        public static void ShowGameplayOverlay(UnityEngine.Transform[] contentToShow)
        {
            UnityEngine.Color val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            BlockPuzzleMagic.BBLGameplayUIHelper.ShowGameplayOverlay(bgColor:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.r}, setBgColorInstantly:  false, contentToShow:  contentToShow);
        }
        public static void ShowGameplayOverlay(UnityEngine.Color bgColor, UnityEngine.Transform[] contentToShow)
        {
            BlockPuzzleMagic.BBLGameplayUIHelper.ShowGameplayOverlay(bgColor:  new UnityEngine.Color() {r = bgColor.r, g = bgColor.g, b = bgColor.b, a = bgColor.a}, setBgColorInstantly:  false, contentToShow:  contentToShow);
        }
        public static void ShowGameplayOverlay(UnityEngine.Color bgColor, bool setBgColorInstantly = False, UnityEngine.Transform[] contentToShow)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Interactable = true;
            BlockRaycasts = true;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Nullable<UnityEngine.Color> val_4 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = bgColor.r, g = bgColor.g, b = bgColor.b, a = bgColor.a});
            if(setBgColorInstantly == true)
            {
                    0.15f = 0;
            }
            
            SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_4.HasValue}, fadeInDuration:  0f, fadeOutDuration:  null);
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowOverlay(contentToOverlay:  contentToShow);
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_10;
            ShowOverlay(contentToOverlay:  -2028557104);
        }
        public static void CloseGameplayOverlay(bool immediate = False, System.Action onOverlayClosed)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CloseOverlay(forceImmediate:  immediate, onClosed:  onOverlayClosed);
        }
        public static void PlayLevelIntroAnimation(int pulseOrigin)
        {
            var val_3;
            var val_4;
            System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> val_1 = BlockPuzzleMagic.BBLGameplayUIHelper.GetGridRingedPattern(center:  pulseOrigin);
            val_3 = 0;
            goto label_1;
            label_16:
            val_4 = 0;
            goto label_2;
            label_14:
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((pulseOrigin + 12) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = pulseOrigin + 8;
            val_3 = val_3 + 0;
            if(((pulseOrigin + 8 + 0) + 16 + 12) <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = (pulseOrigin + 8 + 0) + 16 + 8;
            val_4 = val_4 + 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            (public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + (((pulseOrigin + 8 + 0) + 16 + 8 + 0) + 16) << 2) + 16.PlayInitialAnimation(animationDelay:  0f);
            val_4 = 1;
            label_2:
            if((pulseOrigin + 12) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = pulseOrigin + 8;
            val_5 = val_5 + 0;
            if(val_4 < ((pulseOrigin + 8 + 0) + 16 + 12))
            {
                goto label_14;
            }
            
            val_3 = 1;
            label_1:
            if(val_3 < (pulseOrigin + 12))
            {
                goto label_16;
            }
        
        }
        public static void PlayLevelClearAnimation()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            if(null != 0)
            {
                    val_6 = null;
                val_7 = UnityEngine.Random.Range(min:  0, max:  System.Int32[].__il2cppRuntimeField_namespaze);
            }
            else
            {
                    val_6 = 12;
                val_7 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
            var val_3 = null + (val_7 << 2);
            System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> val_4 = BlockPuzzleMagic.BBLGameplayUIHelper.GetGridRingedPattern(center:  (null + (val_2) << 2) + 16);
            val_8 = 0;
            goto label_4;
            label_19:
            val_9 = 0;
            goto label_5;
            label_17:
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(((null + (val_2) << 2) + 16 + 12) <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_6 = (null + (val_2) << 2) + 16 + 8;
            val_6 = val_6 + 0;
            if((((null + (val_2) << 2) + 16 + 8 + 0) + 16 + 12) <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = ((null + (val_2) << 2) + 16 + 8 + 0) + 16 + 8;
            val_7 = val_7 + 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            (public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + ((((null + (val_2) << 2) + 16 + 8 + 0) + 16 + 8 + 0) + 16) << 2) + 16.PlayLevelClearAnimation(animationDelay:  0f);
            val_9 = 1;
            label_5:
            if(((null + (val_2) << 2) + 16 + 12) <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_8 = (null + (val_2) << 2) + 16 + 8;
            val_8 = val_8 + 0;
            if(val_9 < (((null + (val_2) << 2) + 16 + 8 + 0) + 16 + 12))
            {
                goto label_17;
            }
            
            val_8 = 1;
            label_4:
            if(val_8 < ((null + (val_2) << 2) + 16 + 12))
            {
                goto label_19;
            }
        
        }
        private static System.Collections.Generic.List<System.Collections.Generic.List<int>> GetGridRingedPattern(int center)
        {
            var val_4;
            var val_5;
            int val_31;
            int val_32;
            var val_33;
            var val_34;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_32 = 0;
            val_32 = (public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 20.rowCount) * val_32;
            UnityEngine.Vector2 val_3 = BlockPuzzleMagic.GridLayout.GetColumnRowIndexFromGridIndex(gridIndex:  1212758848);
            if(center >= 0)
            {
                    new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>() = val_32;
            }
            
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) > center)
            {
                    System.Collections.Generic.List<System.Int32> val_7 = new System.Collections.Generic.List<System.Int32>();
                Add(item:  center);
                Add(item:  80883712);
            }
            
            var val_34 = 1;
            do
            {
                System.Collections.Generic.List<System.Int32> val_8 = new System.Collections.Generic.List<System.Int32>();
                if(center >= 0)
            {
                    Add(item:  center);
            }
            
                UnityEngine.Vector2 val_10 = BlockPuzzleMagic.GridLayout.GetColumnRowIndexFromGridIndex(gridIndex:  1212758848);
                val_31 = val_4;
                val_32 = (1 * 0) + center;
                if(val_32 < val_32)
            {
                    Add(item:  val_32);
            }
            
                UnityEngine.Vector2 val_11 = BlockPuzzleMagic.GridLayout.GetColumnRowIndexFromGridIndex(gridIndex:  1212758848);
                if(1 >= 1)
            {
                    var val_33 = 0;
                do
            {
                float val_18 = (val_5 + 1f) + 0f;
                UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  (val_31 + (-1f)) - 0f, y:  val_11.y);
                UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  (val_31 + 1f) + 0f, y:  val_11.y);
                val_31 = (val_5 + (-1f)) - 0f;
                UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  (val_4 + (-1f)) - 0f, y:  val_11.y);
                UnityEngine.Vector2 val_27 = new UnityEngine.Vector2(x:  (val_4 + 1f) + 0f, y:  val_11.y);
                if((((1 >= 1) && (1 < 0)) && (1 >= 1)) && (1 <= 1))
            {
                    val_31 = BlockPuzzleMagic.GridLayout.GetGridIndexFromColumnRowIndex(gridColRow:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
                Add(item:  val_31);
            }
            
                if((((null > 0) && (null < 0)) && (null >= 0)) && (null <= 0))
            {
                    val_31 = BlockPuzzleMagic.GridLayout.GetGridIndexFromColumnRowIndex(gridColRow:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
                Add(item:  val_31);
            }
            
                if((((null >= 0) && (null < 0)) && (null > 0)) && (null < 0))
            {
                    val_31 = BlockPuzzleMagic.GridLayout.GetGridIndexFromColumnRowIndex(gridColRow:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y});
                Add(item:  val_31);
            }
            
                val_32 = val_27.x;
                if((((null > 0) && (null < 0)) && (null > 0)) && (null < 0))
            {
                    val_31 = BlockPuzzleMagic.GridLayout.GetGridIndexFromColumnRowIndex(gridColRow:  new UnityEngine.Vector2() {x = val_32, y = val_27.y});
                Add(item:  val_31);
            }
            
                val_33 = val_33 + 1;
            }
            while(val_34 != val_33);
            
            }
            
                if(null != 0)
            {
                    val_34 = System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze;
            }
            else
            {
                    val_34 = 0;
                val_33 = 0;
            }
            
                if(val_33 >= 1)
            {
                    Add(item:  80883712);
            }
            
                val_34 = val_34 + 1;
            }
            while(val_34 > 0);
        
        }
        public BBLGameplayUIHelper()
        {
        
        }
    
    }

}
