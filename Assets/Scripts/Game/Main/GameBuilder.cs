using Assets.Scripts.Game.Core;

namespace Assets.Scripts.Game.Main
{
    internal static class GameBuilder
    {
        public static Game Build(GameUiComponents uiComponents)
        {
            GameUI gameUI = new GameUI(uiComponents);

            GameSceneLoader sceneLoader = new GameSceneLoader();
            GameAudioSwitcher audioSwitcher = new GameAudioSwitcher();
            GameRepository gameRepository = new GameRepository();

            GameComponents components = new GameComponents(gameUI, sceneLoader, audioSwitcher, gameRepository);

            return new Game(components);
        }
    }
}
