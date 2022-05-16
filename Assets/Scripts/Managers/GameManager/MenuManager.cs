using System.Collections;
using Data;
using UnityEngine;
using Zenject;

namespace Managers
{
    public class MenuManager : MonoBehaviour, IMenuManager
    {
        [Inject] private IUIManager _uiManager;
        [Inject] private IUserManager _userManager;
        [Inject] private IStateManager _stateManager;
        [SerializeField] private Transform mainCanvas;

        private void Start()
        {
            _uiManager.Init(mainCanvas);
            _stateManager.EnterState<MenuState>(new MenuStateArgument {MenuManager = this});
        }

        private void Update()
        { 
            _stateManager.ActiveState.Update();
        }

        public void StartLevel(GameStateArgument args)
        {
            _stateManager.EnterState<GameState>(args);
        }

        private void OnApplicationQuit()
        {
           SaveManager.Save(_userManager);
        }
    }
}
