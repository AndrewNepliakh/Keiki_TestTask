using System;
using System.Collections.Generic;
using Zenject;

namespace Managers
{
    public class StateManager : IStateManager
    {
        public IState ActiveState => _activeState;
        
        private readonly Dictionary<Type, IState> _states;
        private IState _activeState;

        [Inject]
        public StateManager(IUserManager userManager, IUIManager uiManager)
        {
            _states = new Dictionary<Type, IState>
            {
                {typeof(InitialState), new InitialState(userManager)},
                {typeof(InitialState), new MenuState(uiManager)},
                {typeof(InitialState), new GameState(uiManager)}
            };
        }

        public IState EnterState<T>(StateArgument args = null) where T : IState
        {
            _activeState?.Exit();
            var state = _states[typeof(T)];
            _activeState = state;
            state.Enter(args);
            return state;
        }
    }
}