using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Game.Audio.Wwise
{
    public class WwiseEventAdapterList : MonoBehaviour
    {
        #region Editor Fields

        [SerializeField]
        [Tooltip("List of Wwise event adapters that will be triggered")]
        private List<WwiseEventAdapter> wwiseEventAdapters = default;

        #endregion

        #region Public Methods

        /// <summary>
        ///     Post event for each adapter in the list.
        /// </summary>
        public void PostEvents()
        {
            OnWwiseEventAdapter(adapter => adapter.PostEvent());
        }

        /// <summary>
        ///     Post event at provided GameObject for each adapter in the list.
        /// </summary>
        public void PostEvents(GameObject obj)
        {
            OnWwiseEventAdapter(adapter => adapter.PostEvent(obj));
        }

        /// <summary>
        ///     Post event for each adapter in the list if its name matches the provided one.
        /// </summary>
        public void PostEvent(string adapterName)
        {
            OnWwiseEventAdapter(adapterName, adapter => adapter.PostEvent());
        }

        /// <summary>
        ///     Stop event for each adapter in the list if its name matches the provided one.
        /// </summary>
        public void StopEvent(string adapterName)
        {
            OnWwiseEventAdapter(adapterName, adapter => adapter.StopEvent());
        }

        /// <summary>
        ///     Post event at provided GameObject for each adapter in the list if its name matches
        ///     the provided one.
        /// </summary>
        public void PostEvent(string adapterName, GameObject obj)
        {
            OnWwiseEventAdapter(adapterName, adapter => adapter.PostEvent(obj));
        }

        #endregion

        #region Private Methods

        private void OnWwiseEventAdapter(Action<WwiseEventAdapter> action)
        {
            foreach (var adapter in wwiseEventAdapters)
            {
                action.Invoke(adapter);
            }
        }

        private void OnWwiseEventAdapter(string adapterName, Action<WwiseEventAdapter> action)
        {
            var adapters = wwiseEventAdapters.Where(adapter => adapter.name == adapterName);
            foreach (var wwiseEventAdapter in adapters)
            {
                action.Invoke(wwiseEventAdapter);
            }
        }

        #endregion
    }
}
