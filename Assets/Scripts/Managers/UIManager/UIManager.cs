using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class UIManager : MonoBehaviour, IUIManager
    {
        [SerializeField] private Transform _mainCanvas;

        private readonly Dictionary<Type,Window> _windows = new Dictionary<Type,Window>();

        public T ShowWindow<T>(string prefabPath, WindowArgument args) where T : Window
        {
            if (_windows.TryGetValue(typeof(T), out var window))
            {
                window.gameObject.SetActive(true);
                if(args != null) window.Show(args);
                return window as T;
            }

            var windowPrefab = Resources.Load<Window>(prefabPath);
            var newWindow = Instantiate(windowPrefab, _mainCanvas) as T;
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