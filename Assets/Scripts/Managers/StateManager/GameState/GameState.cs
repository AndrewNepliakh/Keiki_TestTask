namespace Managers
{
    public class GameState : IState
    {
        private IUIManager _uiManager;

        public GameState(IUIManager uiManager)
        {
            _uiManager = uiManager;
        }
        public void Enter(StateArgument args = null)
        {
            
        }

        public void Exit()
        {
           
        }

        public void Update()
        {
           
        }
    }
}