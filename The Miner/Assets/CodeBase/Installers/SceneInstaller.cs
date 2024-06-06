using Zenject;

public class SceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        RegisterPlayerFactory();
        RegisterEnemyFactory();
    }

    private void RegisterEnemyFactory()
    {
        Container
            .BindInterfacesTo<EnemyFactory>()
            .AsSingle();
    }

    private void RegisterPlayerFactory()
    {
        Container
            .Bind<IPlayerFactory>()
            .To<PlayerFactory>()
            .AsSingle();
    }
}
