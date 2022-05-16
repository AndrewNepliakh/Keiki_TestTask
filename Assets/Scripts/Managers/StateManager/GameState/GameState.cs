using Controllers;
using Data;

namespace Managers
{
    public class GameState : IState
    {
        private IUIManager _uiManager;
        private AnimalType _animalType;

        public GameState(IUIManager uiManager)
        {
            _uiManager = uiManager;
        }
        public void Enter(StateArgument args = null)
        {
            _animalType = ((GameStateArgument)args).AnimalType;
            _uiManager.ShowWindow<LevelWindow>(Constants.LEVEL_WINDOW_PATH);
        }

        public void Exit()
        {
            
        }

        public void Update()
        {
           
        }
    }
}