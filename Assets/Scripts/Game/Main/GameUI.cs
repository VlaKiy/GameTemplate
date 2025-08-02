using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.Main
{
    internal class GameUI
    {
        public event Action OnPlayButtonClicked;
        public event Action OnRestartButtonClicked;
        public event Action OnPauseButtonClicked;
        public event Action OnResumeButtonClicked;
        public event Action OnVolumeButtonClicked;

        private Button _playButton;
        private Button _restartButton;
        private Button _pauseButton;
        private Button _resumeButton;
        private Button _volumeButton;

        private Sprite _volumeOnIcon;
        private Sprite _volumeOffIcon;

        private GameObject _splashScreen;
        private GameObject _pauseScreen;

        private TextMeshProUGUI _scopeText;

        public GameUI(GameUiComponents uiComponents) 
        { 
            _playButton = uiComponents.GetPlayButton();
            _restartButton = uiComponents.GetRestartButton();
            _pauseButton = uiComponents.GetPauseButton();
            _resumeButton = uiComponents.GetResumeButton();
            _volumeButton = uiComponents.GetVolumeButton();

            _volumeOnIcon = uiComponents.GetVolumeOnIcon();
            _volumeOffIcon = uiComponents.GetVolumeOffIcon();

            _splashScreen = uiComponents.GetSplashScreen();
            _pauseScreen = uiComponents.GetPauseScreen();

            _scopeText = uiComponents.GetScopeText();

            AddListeners();
        }

        private void AddListeners()
        {
            if (_playButton != null)
                _playButton.onClick.AddListener(() => OnPlayButtonClicked?.Invoke());

            if (_restartButton != null)
                _restartButton.onClick.AddListener(() => OnRestartButtonClicked?.Invoke());

            if (_pauseButton != null)
                _pauseButton.onClick.AddListener(() => OnPauseButtonClicked?.Invoke());

            if (_resumeButton != null)
                _resumeButton.onClick.AddListener(() => OnResumeButtonClicked?.Invoke());

            if (_volumeButton != null)
                _volumeButton.onClick.AddListener(() => OnVolumeButtonClicked?.Invoke());
        }

        public void SetScopeText(int scopeAmount)
        {
            if (_scopeText == null)
                return;

            _scopeText.text = scopeAmount.ToString(); 
        }

        public void SetVolumeButtonIcon(bool hasVolume)
        {
            if (hasVolume)
                SetVolumeButtonIconOn();
            else
                SetVolumeButtonIconOff();
        }

        public void SetVolumeButtonIconOn()
        {
            if (_volumeButton == null || _volumeOnIcon == null)
                return;

            _volumeButton.GetComponent<Image>().sprite = _volumeOnIcon;
        }

        public void SetVolumeButtonIconOff()
        {
            if (_volumeButton == null || _volumeOffIcon == null)
                return;

            _volumeButton.GetComponent<Image>().sprite = _volumeOffIcon;
        }

        public void ShowSplashScreen()
        {
            _splashScreen.SetActive(true);
        }

        public void HideSplashScreen()
        {
            _splashScreen.SetActive(false);
        }

        public void ShowPauseScreen()
        {
            _pauseScreen.SetActive(true);
        }

        public void HidePauseScreen()
        {
            _pauseScreen.SetActive(false);
        }

        public void ShowPauseButton()
        {
            _pauseButton.gameObject.SetActive(true);
        }

        public void HidePauseButton()
        {
            _pauseButton.gameObject.SetActive(false);
        }
    }
}
