using UnityEngine;

namespace Assets.Scripts.Game.Core
{
    internal class GameAudioSwitcher
    {
        private bool _hasVolume;

        public void Switch()
        {
            if (AudioListener.volume == 0)
            {
                AudioListener.volume = 1;
                _hasVolume = true;
            } else
            {
                AudioListener.volume = 0;
                _hasVolume = false;
            }
        }

        public void SetVolume(bool hasVolume)
        {
            AudioListener.volume = hasVolume ? 1 : 0;
            _hasVolume = hasVolume;
        }

        public bool HasVolume()
        {
            return _hasVolume;
        }
    }
}
