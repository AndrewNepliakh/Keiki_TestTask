using System.Collections;
using UnityEngine;

namespace Managers
{
    public interface IUIManager
    {
        void Init(Transform mainCanvas);
        T ShowWindow<T>(string prefabPath, WindowArgument args = null) where T : Window;
        void CloseWindow<T>() where T : Window;
    }
}