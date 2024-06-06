using Assets.CodeBase.Infrastracture.AssetManagment;
using UnityEngine;

public class EnemyFactory : IEnemyFactory
{
    private GameObject EnemyGameObject { get; set; }
    private IAssetProvider _assetProvider;

    public EnemyFactory(IAssetProvider assetProvider) =>
        _assetProvider = assetProvider;

    private GameObject InstantiateRegistered(string enemyPath, Vector3 at, Quaternion quaternion)
    {
        GameObject EnemyGameObject = _assetProvider.Instantiate(enemyPath, at, quaternion);
        return EnemyGameObject;
    }

    public GameObject CreateEnemy(Vector3 at, Quaternion quaternion)
    {
        GameObject gameObject = InstantiateRegistered(AssetPath.EnemyPath, at, quaternion);
        return gameObject;
    }
}
