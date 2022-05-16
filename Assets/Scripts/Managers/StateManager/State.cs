namespace Managers
{
    public abstract class State : IState
    {
        protected IUIManager _uiManager;
        protected IStateManager _stateManager;

        protected bool _isStarted;

        public abstract void Enter(StateArgument args = null);
        public abstract void Exit();

        public virtual void Update()
        {
            if (!_isStarted) return;
        }
    }
}