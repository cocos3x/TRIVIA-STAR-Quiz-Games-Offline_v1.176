using UnityEngine;

namespace RestaurantRivals
{
    public class RESRaidAttackFlyout : MonoBehaviour
    {
        // Fields
        private static bool isShowing;
        private UnityEngine.RectTransform windowRT;
        private UnityEngine.UI.Text bodyText;
        private UnityEngine.UI.Image iconNewsSender;
        private UnityEngine.UI.Image iconNewsType;
        private UnityEngine.UI.Button tapArea;
        private UnityEngine.Sprite spriteRefNewsShield;
        private UnityEngine.Sprite spriteRefNewsRaid;
        private UnityEngine.Sprite spriteRefNewsAttack;
        private float slideInDuration;
        private float stayDuration;
        private float slideOutDuration;
        private DG.Tweening.Ease slideInEase;
        private DG.Tweening.Ease slideOutEase;
        private float anchorYMax;
        private float anchorYMin;
        
        // Properties
        public static bool IsShowing { get; }
        
        // Methods
        public static bool get_IsShowing()
        {
            null = null;
            return (bool)RestaurantRivals.RESRaidAttackFlyout.isShowing;
        }
        private void OnClickFlyout()
        {
            this.StopAllCoroutines();
            System.Collections.IEnumerator val_1 = this.SlideOut();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  585813248);
        }
        private void Awake()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  585934464, method:  new IntPtr(585909440));
            this.tapArea.m_OnClick.AddListener(call:  162246656);
        }
        private void OnEnable()
        {
            null = null;
            RestaurantRivals.RESRaidAttackFlyout.isShowing = true;
            UnityEngine.Vector2 val_1 = anchoredPosition;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_1.x, y:  val_1.y);
            this.windowRT.anchoredPosition = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            System.Collections.IEnumerator val_4 = this.SlideInAndOut();
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  586058752);
        }
        private void OnDestroy()
        {
            null = null;
            RestaurantRivals.RESRaidAttackFlyout.isShowing = false;
        }
        public void Setup(RestaurantRivals.NewsArticle data)
        {
            string val_14;
            UnityEngine.UI.Text val_15;
            var val_16;
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.DateTime val_2 = ToUniversalTime();
            System.TimeSpan val_3 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513783122472}, d2:  new System.DateTime());
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Sprite val_5 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C.GetAvatarSpriteByID(id:  data.sender.avatarId);
            this.iconNewsSender.sprite = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C;
            val_14 = data.action;
            if((System.String.op_Equality(a:  val_14, b:  249556960)) != false)
            {
                    this.iconNewsType.sprite = this.spriteRefNewsShield;
                string val_7 = System.String.Format(format:  586299712, arg0:  data.sender.name);
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                RestaurantRivals.RESPlayer val_9 = RestaurantRivals.RESPlayer.Instance;
                public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_18 + 16.UpdateShieldsIcon(shieldCount:  public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_128, showBrokenAnima:  false);
                return;
            }
            
            if((System.String.op_Equality(a:  val_14, b:  249548608)) != false)
            {
                    val_14 = this.spriteRefNewsRaid;
                this.iconNewsType.sprite = val_14;
                val_15 = this.bodyText;
                val_16 = "<color=#FFF770>{0}</color> stole <color=#FFB631>{1}</color> from you";
                string val_11 = System.String.Format(format:  586312192, arg0:  data.sender.name, arg1:  data.amount);
                return;
            }
            
            if((System.String.op_Equality(a:  val_14, b:  249556880)) == false)
            {
                    return;
            }
            
            this.iconNewsType.sprite = this.spriteRefNewsAttack;
            val_15 = this.bodyText;
            val_16 = "<color=#FFF770>{0}</color> attacked your Restaurant";
            string val_13 = System.String.Format(format:  586328784, arg0:  data.sender.name);
        }
        private System.Collections.IEnumerator SlideInAndOut()
        {
            object val_1 = new System.Object();
            typeof(RESRaidAttackFlyout.<SlideInAndOut>d__23).__il2cppRuntimeField_8 = 0;
            typeof(RESRaidAttackFlyout.<SlideInAndOut>d__23).__il2cppRuntimeField_10 = this;
        }
        private System.Collections.IEnumerator SlideIn()
        {
            object val_1 = new System.Object();
            typeof(RESRaidAttackFlyout.<SlideIn>d__24).__il2cppRuntimeField_8 = 0;
            typeof(RESRaidAttackFlyout.<SlideIn>d__24).__il2cppRuntimeField_10 = this;
        }
        private System.Collections.IEnumerator SlideOut()
        {
            object val_1 = new System.Object();
            typeof(RESRaidAttackFlyout.<SlideOut>d__25).__il2cppRuntimeField_8 = 0;
            typeof(RESRaidAttackFlyout.<SlideOut>d__25).__il2cppRuntimeField_10 = this;
        }
        private void ShowNextOrClose()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            RestaurantRivals.NewsArticle val_2 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_20.GetNextArticle();
            this.Setup(data:  public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_20);
            System.Collections.IEnumerator val_3 = this.SlideInAndOut();
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  586866496);
        }
        public RESRaidAttackFlyout()
        {
            this.slideInDuration = 0.5f;
            this.stayDuration = 2f;
            this.slideOutDuration = 0.5f;
            this.slideInEase = 6;
        }
        private static RESRaidAttackFlyout()
        {
        
        }
    
    }

}
