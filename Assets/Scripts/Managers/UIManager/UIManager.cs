using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Managers
{
    public class UIManager : IUIManager
    {
        [Inject] private DiContainer _diContainer;
        private Transform _mainCanvas;
        private readonly Dictionary<Type,Window> _windows = new Dictionary<Type,Window>();

        public void Init(Transform mainCanvas)
        {
            _mainCanvas = mainCanvas;
        }

        public T ShowWindow<T>(string prefabPath, WindowArgument args) where T : Window
        {
            if (_windows.TryGetValue(typeof(T), out var window))
            {
                window.gameObject.SetActive(true);
                if(args != null) window.Show(args);
                return window as T;
            }

            var windowPrefab = Resources.Load<Window>(prefabPath);
            var newWindow = _diContainer.InstantiatePrefab(windowPrefab, _mainCanvas).GetComponent<T>();
            if(args != null) newWindow.Show(args);
            _windows.Add(typeof(T), newWindow);
            return newWindow;
        }
        
        public void CloseWindow<T>() where T : Window
        {
            if (!_windows.TryGetValue(typeof(T), out var window)) return;
            window.Close();
            window.gameObject.SetActive(false);
        }
    }
}