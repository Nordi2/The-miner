using Assets.CodeBase.Infrastracture.AssetManagment;
using UnityEngine;

public class PlayerFactory : IPlayerFactory
{
    private IAssetProvider _assetProvider;
    private GameObject HeroGameObject { get; set; } 
    public PlayerFactory(IAssetProvider assetProvider)
    {
        _assetProvider = assetProvider;
    }
    public GameObject CreateHero(Vector3 at) 
    {
        HeroGameObject = InstantiateRegistered(AssetPath.HeroPath, at);
        return HeroGameObject;
    }
    private GameObject InstantiateRegistered(string hepoPath, Vector3 position)
    {
        GameObject gameObject = _assetProvider.Instantiate(hepoPath, position);
        return gameObject;
    }
}
