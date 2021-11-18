using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sound
{
    public class PlayerPrefsHandler : MonoBehaviour
    {
        #region Private Methods
        private const string MUSIC_VOLUME_KEY = "music volume";
        private const string SFX_VOLUME_KEY = "sfx volume";

        private const float MIN_VOLUME = 0.0f;
        private const float MAX_VOLUME = 100.0f;
        #endregion

        #region Public Methods
        public static void SetMusicVolume(float musicVolume)
        {
            SetPlayerPrefVolume(MUSIC_VOLUME_KEY, musicVolume);
        }

        public static void SetSfxVolume(float sfxVolume)
        {
            SetPlayerPrefVolume(SFX_VOLUME_KEY, sfxVolume);
        }

        public static float GetMusicVolume()
        {
            return GetPlayerPrefVolume(MUSIC_VOLUME_KEY);
        }

        public static float GetSfxVolume()
        {
            return GetPlayerPrefVolume(SFX_VOLUME_KEY);
        }
        #endregion

        #region Private Methods
        private static void SetPlayerPrefVolume(string key, float volume)
        {
            if (volume >= MIN_VOLUME && volume <= MAX_VOLUME)
            {
                PlayerPrefs.SetFloat(key, volume);
            }
            else
            {
                Debug.LogError($"{key} is out of volume range");
            }

        }

        private static float GetPlayerPrefVolume(string key)
        {
            return PlayerPrefs.GetFloat(key);
        }
        #endregion
    }
}
