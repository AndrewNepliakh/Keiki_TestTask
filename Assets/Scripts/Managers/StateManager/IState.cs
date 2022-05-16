using System;
using System.Collections;
using UnityEditor;
using UnityEngine;

namespace Managers
{
    public interface IState
    {
        void Enter(StateArgument args = null);
        void Exit();
        void Update();
    }
}
