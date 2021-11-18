using UnityEngine;

namespace Game.Audio.Wwise
{
    public class WwiseSwitchAdapter : MonoBehaviour
    {
        #region Editor Fields

        [SerializeField]
        [Tooltip("Wwise switch that will be triggered")]
        private AK.Wwise.Switch wwiseSwitch = default;

        #endregion

        #region Public Methods

        /// <summary>
        /// Set value of Wwise switch for current GameObject.
        /// </summary>
        public void SetValue()
        {
            SetValue(gameObject);
        }

        /// <summary>
        /// Set value of Wwise switch for given GameObject.
        /// </summary>
        public void SetValue(GameObject obj)
        {
            wwiseSwitch.SetValue(obj);
        }

        #endregion
    }
}
