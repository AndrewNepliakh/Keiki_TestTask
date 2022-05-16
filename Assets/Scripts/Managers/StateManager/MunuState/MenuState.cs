using Controllers;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class MenuState : IState
    {
        private IUIManager _uiManager;
        private IMenuManager _menuManager;

        public MenuState(IUIManager uiManager)
        {
            _uiManager = uiManager;
        }
        public void Enter(StateArgument args = null)
        {
            _menuManager = ((MenuStateArgument)args).MenuManager;
            _uiManager.ShowWindow<MenuWindow>(Constants.MENU_WINDOW_PATH, new MenuWindowArgument{MenuManager = _menuManager});
        }

        public void Exit()
        {
            
        }

        public void Update()
        {
            
        }
    }
}