namespace Managers
{
    public class MenuState : IState
    {
        private IUIManager _uiManager;

        public MenuState(IUIManager uiManager)
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