using System;
using Data;
using Managers;
using UnityEngine;
using UnityEngine.UI;

namespace Controllers
{
    public class TailIcon : LevelIcon
    {
        private Action<AnimalType> _onButtonClick;

        public void Init(AnimalType type, LevelIconsData levelIconsData, Action<AnimalType> callback)
        {
            _type = type;
            _levelIconsData = levelIconsData;

            _onButtonClick += callback;
            _icon.sprite = _levelIconsData.GetTailSpriteByType(_type);
            _actionButton.onClick.AddListener(OnActionButtonClick);
        }

        private void OnActionButtonClick()
        {
            _onButtonClick?.Invoke(_type);
        }
    }
}