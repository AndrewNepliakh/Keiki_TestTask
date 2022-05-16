using System;
using Data;
using UnityEngine;
using Zenject;

namespace Managers
{
    public class GameManager : MonoBehaviour, IGameManager
    {
        [Inject] private IUIManager _uiManager;
        [Inject] private IUserManager _userManager;
        [Inject] private IStateManager _stateManager;
        [SerializeField] private Transform mainCanvas;
       
        private void Start()
        {
            _uiManager.Init(mainCanvas);
            _stateManager.EnterState<GameState>();
        }

        private void Update()
        {
            _stateManager.ActiveState.Update();
        }

        public void CheckResult(AnimalType type)
        {
            
        }
    }
}