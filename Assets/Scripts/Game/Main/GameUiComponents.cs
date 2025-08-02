using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.Main
{
    internal class GameUiComponents: MonoBehaviour
    {
        [SerializeField] private Button _playButton;
        [SerializeField] private Button _restartButton;
        [SerializeField] private Button _pauseButton;
        [SerializeField] private Button _resumeButton;
        [SerializeField] private Button _volumeButton;
        
        [SerializeField] private Sprite _volumeOnIcon;
        [SerializeField] private Sprite _volumeOffIcon;

        [SerializeField] private GameObject _splashScreen;
        [SerializeField] private GameObject _pauseScreen;

        [SerializeField] private TextMeshProUGUI _scopeText;

        public Button GetPlayButton() { return _playButton; }

        public Button GetRestartButton() { return _restartButton; }

        public Button GetPauseButton() { return _pauseButton; }

        public Button GetResumeButton() { return _resumeButton; }

        public Button GetVolumeButton() { return _volumeButton; }

        public Sprite GetVolumeOnIcon() { return _volumeOnIcon; }
        public Sprite GetVolumeOffIcon() { return _volumeOffIcon; }

        public GameObject GetSplashScreen() { return _splashScreen; }

        public GameObject GetPauseScreen() { return _pauseScreen; }

        public TextMeshProUGUI GetScopeText() { return _scopeText; }

    }
}
