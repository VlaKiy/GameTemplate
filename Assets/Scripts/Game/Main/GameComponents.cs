using Assets.Scripts.Game.Core;

namespace Assets.Scripts.Game.Main
{
    internal class GameComponents
    {
        private GameUI _gameUI;
        private GameSceneLoader _sceneLoader;
        private GameAudioSwitcher _audioSwitcher;
        private GameRepository _gameRepository;

        public GameComponents(GameUI gameUI, GameSceneLoader sceneLoader, GameAudioSwitcher audioSwitcher, GameRepository gameRepository)
        {
            _gameUI = gameUI;
            _sceneLoader = sceneLoader;
            _audioSwitcher = audioSwitcher;
            _gameRepository = gameRepository;
        }

        public GameUI GetGameUI() { return _gameUI; }

        public GameSceneLoader GetSceneLoader() { return _sceneLoader; }

        public GameAudioSwitcher GetAudioSwitcher() { return _audioSwitcher; }

        public GameRepository GetRepository() { return _gameRepository; }
    }
}
