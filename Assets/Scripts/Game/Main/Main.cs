using UnityEngine;

namespace Assets.Scripts.Game.Main
{
    public class Main : MonoBehaviour
    {
        private GameUiComponents uiComponents;
        private Game game;

        private void Awake()
        {
            uiComponents = GetComponent<GameUiComponents>();

            game = GameBuilder.Build(uiComponents);
        }

        private void Start()
        {
            game.Run();  
        }
    }
}