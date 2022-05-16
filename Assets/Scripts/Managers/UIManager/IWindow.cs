using System;
using System.Collections;

namespace Managers
{
    public interface IWindow
    {
        Action OnClose { get; set; }
        void Show(WindowArgument args);
        void Close();
    }
}