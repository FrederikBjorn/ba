using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Sound
{
    public class AudioHandler : MonoBehaviour
    {
        #region Private Fields
        [Tooltip("String Name for Music in Wwise"), SerializeField]
        private string musicVolumeName = "Music";
        [Tooltip("String Name for SFXs in Wwise"), SerializeField]
        private string sfxVolumeName = "SFX";
        #endregion

        #region Unity Events Methods
        private void Start()
        {
            DontDestroyOnLoad(this);

            GetPlayerPrefsMusicVolume();
        }

        private void GetPlayerPrefsMusicVolume()
        {
            SetMusicAudio(PlayerPrefsHandler.GetMusicVolume());
            SetSfxAudio(PlayerPrefsHandler.GetSfxVolume());
        }
        #endregion

        #region Public Methods
        public void ChangeMusicVolume(float volume)
        {
            SetMusicAudio(volume);
        }

        public void ChangeSfxVolume(float volume)
        {
            SetSfxAudio(volume);
        }
        #endregion

        #region Private Methods
        private void SetMusicAudio(float volume)
        {
            AkSoundEngine.SetRTPCValue(musicVolumeName, volume);
        }

        private void SetSfxAudio(float volume)
        {
            AkSoundEngine.SetRTPCValue(sfxVolumeName, volume);
        }
        #endregion
    }
}
