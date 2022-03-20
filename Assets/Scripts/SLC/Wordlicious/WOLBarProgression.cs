using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLBarProgression : MonoSingleton<SLC.Wordlicious.WOLBarProgression>
    {
        // Fields
        private UnityEngine.UI.Text levelText;
        private UnityEngine.UI.Slider slider;
        private UnityEngine.UI.Text text;
        private int requiredPoints;
        private int points;
        
        // Methods
        public void LoadLevel(int requiredPoints)
        {
            this.requiredPoints = requiredPoints;
            string val_1 = System.String.Format(format:  694050880, arg0:  13152256);
            Player val_2 = App.Player;
            string val_3 = System.String.Format(format:  2127161280, arg0:  13152256);
            if(this.levelText != 0)
            {
                    return;
            }
        
        }
        public void UpdatePoints(int points)
        {
            int val_1 = UnityEngine.Mathf.Min(a:  this.requiredPoints, b:  points);
            this.points = val_1;
            float val_2 = UnityEngine.Mathf.Max(a:  (float)this.requiredPoints, b:  null);
            float val_4 = (float)val_1;
            val_4 = val_4 / 1065353216;
            string val_3 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            if(this.text != 0)
            {
                    return;
            }
        
        }
        public WOLBarProgression()
        {
        
        }
    
    }

}
