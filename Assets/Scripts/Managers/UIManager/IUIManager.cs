using System.Collections;

namespace Managers
{
    public interface IUIManager
    {
        T ShowWindow<T>(string prefabPath, WindowArgument args = null) where T : Window;
        void CloseWindow<T>() where T : Window;
    }
}