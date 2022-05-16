using System.Collections;

namespace Managers
{
    public interface IStateManager
    {
        IState ActiveState { get; }
        IState EnterState<T>(StateArgument args = null) where T : IState;
    }
}