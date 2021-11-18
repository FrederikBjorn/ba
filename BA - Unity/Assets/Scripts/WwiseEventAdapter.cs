using System.Collections.Generic;
using UnityEngine;

namespace Game.Audio.Wwise
{
    public class WwiseEventAdapter : MonoBehaviour
    {
        #region Editor Fields

        [SerializeField]
        [Tooltip("Wwise event that will be triggered")]
        private AK.Wwise.Event wwiseEvent = default;

        private readonly HashSet<GameObject> postedGameObjects
            = new HashSet<GameObject>();

        #endregion

        #region Public Methods

        /// <summary>
        /// Post Wwise event for current GameObject.
        /// </summary>
        public void PostEvent()
        {
            PostEvent(gameObject);
        }

        /// <summary>
        /// Post Wwise event for given GameObject.
        /// </summary>
        public void PostEvent(GameObject obj)
        {
            postedGameObjects.Add(obj);
            wwiseEvent.Post(obj);
        }

        /// <summary>
        /// Stop event for current GameObject.
        /// </summary>
        public void StopEvent()
        {
            StopEvent(gameObject);
        }

        /// <summary>
        /// Stop Wwise event for given GameObject.
        /// </summary>
        public void StopEvent(GameObject obj)
        {
            postedGameObjects.Remove(obj);
            wwiseEvent.Stop(obj);
        }

        #endregion

        #region Unity Event Methods

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            foreach (var postedGameObject in postedGameObjects)
            {
                OnDrawMaxRadius(postedGameObject);
            }
        }

        private static void OnDrawMaxRadius(GameObject postedGameObject)
        {
            var maxRadius = AkSoundEngine.GetMaxRadius(postedGameObject);
            if (maxRadius <= 0)
            {
                return;
            }

            Gizmos.DrawWireSphere(
                postedGameObject.transform.position,
                maxRadius
            );
        }

        #endregion
    }
}
