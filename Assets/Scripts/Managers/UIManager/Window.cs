using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Managers
{
    public abstract class Window : MonoBehaviour, IWindow
    {
        public Action OnClose { get; set; }
        public void Show(WindowArgument args)
        {
          
        }

        public void Close()
        {
           
        }
    }
}