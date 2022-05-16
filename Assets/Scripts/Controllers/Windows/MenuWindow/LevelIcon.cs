using System;
using Data;
using Managers;
using UnityEngine;
using UnityEngine.UI;

namespace Controllers
{
    public class LevelIcon : MonoBehaviour
    {
        protected AnimalType _type;

        [SerializeField] protected Image _icon;
        [SerializeField] protected Button _actionButton;

        protected LevelIconsData _levelIconsData;
        private Action<GameStateArgument> _onButtonClick;
        
        public void Init(AnimalType type, LevelIconsData levelIconsData, Action<GameStateArgument> onClick)
        {
            _type = type;
            _levelIconsData = levelIconsData;

            _onButtonClick += onClick;
            _icon.sprite = _levelIconsData.GetSpriteByType(_type);
            _actionButton.onClick.AddListener(OnActionButtonClick);
        }

        private void OnActionButtonClick()
        {
            _onButtonClick?.Invoke(new GameStateArgument{AnimalType = _type});
        }

        private void OnDisable()
        {
           Debug.LogError(">>>>> Disable <<<<<<");
           _actionButton.onClick.RemoveListener(OnActionButtonClick);
        }

        private void OnDestroy()
        {
            Debug.LogError(">>>>> OnDestroy <<<<<<");
            _actionButton.onClick.RemoveListener(OnActionButtonClick);
        }
    }
}