using Assets.Scripts.Game.Core;
using UnityEngine;
using YG;

namespace Assets.Scripts.Game.Main
{
    internal class Game
    {
        private GameUI _gameUI;
        private GameSceneLoader _sceneLoader;
        private GameAudioSwitcher _audioSwitcher;
        private GameRepository _gameRepository;

        public Game(GameComponents components)
        {
            _gameUI = components.GetGameUI();
            _sceneLoader = components.GetSceneLoader();
            _audioSwitcher = components.GetAudioSwitcher();
            _gameRepository = components.GetRepository();

            _gameRepository.OnScopeChanged += _gameUI.SetScopeText;

            _gameUI.OnPlayButtonClicked += OnPlayClicked;
            _gameUI.OnRestartButtonClicked += OnRestartClicked;
            _gameUI.OnVolumeButtonClicked += OnVolumeClicked;
            _gameUI.OnPauseButtonClicked += OnPauseClicked;
            _gameUI.OnResumeButtonClicked += OnResumeClicked;
        }

        public void Run()
        {
            if (YandexGame.SDKEnabled)
            {
                StartGame();
            }
            else
            {
                _gameUI.ShowSplashScreen();
                YandexGame.GetDataEvent += StartGame;
            }
            
        }

        private void StartGame()
        {
            YandexGame.GetDataEvent -= StartGame;

            _audioSwitcher.SetVolume(YandexGame.savesData.hasVolume);
            _gameUI.SetVolumeButtonIcon(_audioSwitcher.HasVolume());

            _gameUI.HideSplashScreen();
        }

        private void OnPlayClicked()
        {
            _sceneLoader.LoadScene(GameConstants.GAME_SCENE_NAME);
            YandexGame.SaveProgress();
        }

        private void OnRestartClicked()
        {
            _sceneLoader.ReloadCurrentScene();
        }

        private void OnVolumeClicked()
        {
            _audioSwitcher.Switch();
            YandexGame.savesData.hasVolume = _audioSwitcher.HasVolume();

            _gameUI.SetVolumeButtonIcon(_audioSwitcher.HasVolume());
        }

        private void OnPauseClicked()
        {
            _gameUI.ShowPauseScreen();
            _gameUI.HidePauseButton();

            Time.timeScale = 0;
        }

        private void OnResumeClicked()
        {
            _gameUI.HidePauseScreen();
            _gameUI.ShowPauseButton();

            Time.timeScale = 1;
        }
    }
}
