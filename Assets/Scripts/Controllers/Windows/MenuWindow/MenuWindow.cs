using System.Collections.Generic;
using Data;
using Managers;
using UnityEngine;
using Zenject;

namespace Controllers
{
    public class MenuWindow : Window
    {
        [SerializeField] private Transform _gridGroup;
        [Inject] private LevelIconsData _levelIconsData;
        private IMenuManager _menuManager;

        private List<LevelIconsData> _icons = new List<LevelIconsData>();
        
        public override void Show(WindowArgument args)
        {
            _menuManager = ((MenuWindowArgument)args).MenuManager;
            SetLevelIcons();
        }

        private void SetLevelIcons()
        {
            var prefab = _levelIconsData.levelIconPrefab;
            
            foreach (var levelIconModel in _levelIconsData.levelIconModels)
            {
                var levelIcon = Instantiate(prefab, _gridGroup);
                levelIcon.Init(levelIconModel.type, _levelIconsData, _menuManager.StartLevel);
            }
        }

        public override void Close()
        {
           
        }
    }
}