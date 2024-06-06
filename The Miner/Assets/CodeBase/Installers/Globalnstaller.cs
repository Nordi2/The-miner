using Assets.CodeBase.Infrastracture.AssetManagment;
using Zenject;

public class Globalnstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        RegisterAssetProvider();
    }

    private void RegisterAssetProvider() =>
        Container
        .Bind<IAssetProvider>()
        .To<AssetProvider>()
        .AsSingle();
}
