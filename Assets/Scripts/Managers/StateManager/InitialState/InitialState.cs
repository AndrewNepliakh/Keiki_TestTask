using System;
using System.Collections;
using UnityEngine.SceneManagement;
using Zenject;

namespace Managers
{
    public class InitialState : IState
    {
        private IUserManager _userManager;
        private IStateManager _stateManager;

        public InitialState(IUserManager userManager)
        {
            _userManager = userManager;
        }

        public void Enter(StateArgument args)
        {
            LoadUserData();
            SceneManager.LoadScene(Constants.MENU_SCENE);
        }

        public void Exit()
        {
        }

        public void Update()
        {
        }

        private void LoadUserData()
        {
            var saveData = SaveManager.Load();
            _userManager.Init(saveData.UserData);
        }
    }
}