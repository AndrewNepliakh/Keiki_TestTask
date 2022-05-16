using System;
using Data;
using Managers;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Controllers
{
    public class LevelWindow : Window
    {
        [SerializeField] private Button _homeButton;
        [SerializeField] private Transform _leftPanel;
        [SerializeField] private Transform _rightPanel;
        [Inject] private LevelIconsData _levelIconsData;
        private IGameManager _gameManager;
        public override void Show(WindowArgument args)
        {
            SetTailsIcons();
            _homeButton.onClick.AddListener(OnHomeButtonClicked);
        }

        private void SetTailsIcons()
        {
            for (var i = 0; i < _levelIconsData.levelIconModels.Count; i++)
            {
                TailIcon tailIcon;
                
                if ((i + 1) < _levelIconsData.levelIconModels.Count / 2)
                {
                    tailIcon = Instantiate(_levelIconsData.tailIconPrefab, _leftPanel);
                    tailIcon.Init(_levelIconsData.levelIconModels[i].type, _levelIconsData, _gameManager.CheckResult);
                }
            }
        }

        private void OnHomeButtonClicked()
        {
            
        }

        public override void Close()
        {
           
        }
    }
}