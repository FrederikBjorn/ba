using UnityEngine;

namespace Game.Audio.Wwise
{
    public class WwiseStateAdapter : MonoBehaviour
    {
        #region Editor Fields

        [SerializeField]
        [Tooltip("Wwise state that will be triggered")]
        private AK.Wwise.State wwiseState = default;

        #endregion

        #region Public Methods

        /// <summary>
        /// Set value of Wwise state.
        /// </summary>
        public void SetValue()
        {
            wwiseState.SetValue();
        }

        #endregion
    }
}
