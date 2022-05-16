using Data;
using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "ScriptableObjectInstaller", menuName = "Installers/ScriptableObjectInstaller")]
public class ScriptableObjectInstaller : ScriptableObjectInstaller<ScriptableObjectInstaller>
{
    [SerializeField] private LevelIconsData _levelIconsData;
    public override void InstallBindings()
    {
        Container.Bind<LevelIconsData>().FromInstance(_levelIconsData).AsSingle().NonLazy();
    }
}