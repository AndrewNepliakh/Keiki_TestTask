using Managers;
using UnityEngine;
using Zenject;

namespace Infrastructure
{
    public class MenuSceneInstaller : MonoInstaller
    {
        [SerializeField] private MenuManager menuManager;

        public override void InstallBindings()
        {
            Container.Bind<IMenuManager>().FromInstance(menuManager).AsSingle();
        }
    }
}
