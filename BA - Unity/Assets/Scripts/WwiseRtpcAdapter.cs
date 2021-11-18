using UnityEngine;

namespace Game.Audio.Wwise
{
    public class WwiseRtpcAdapter : MonoBehaviour
    {
        #region Editor Fields

        [SerializeField]
        [Tooltip("Wwise Real-time Parameter Control (RTPC) that will be triggered")]
        private AK.Wwise.RTPC wwiseRtpc = default;

        #endregion

        #region Public Methods

        /// <returns>
        /// Global value of underlying RTPC.
        /// </returns>
        public float GetGlobalValue()
        {
            return wwiseRtpc.GetGlobalValue();
        }

        /// <returns>
        /// Value of underlying RTPC which is attached to current GameObject.
        /// </returns>
        public float GetValue()
        {
            return GetValue(gameObject);
        }

        /// <returns>
        /// Value of underlying RTPC which is attached to provided GameObject.
        /// </returns>
        public float GetValue(GameObject obj)
        {
            return wwiseRtpc.GetValue(obj);
        }

        /// <summary>
        /// Set global value of underlying RTPC.
        /// </summary>
        public void SetGlobalValue(float value)
        {
            wwiseRtpc.SetGlobalValue(value);
            Debug.Log (value);

        }

        /// <summary>
        /// Set value of underlying RTPC for current GameObject.
        /// </summary>
        public void SetValue(float value)
        {
            SetValue(gameObject, value);
            Debug.Log (value);
        }

        /// <summary>
        /// Set value of underlying RTPC for provided GameObject.
        /// </summary>
        public void SetValue(GameObject obj, float value)
        {
            wwiseRtpc.SetValue(obj, value);
        Debug.Log (value);
        }

        #endregion
    }
}
