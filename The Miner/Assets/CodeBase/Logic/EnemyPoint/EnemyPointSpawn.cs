using UnityEngine;
using Zenject;

public class EnemyPointSpawn : MonoBehaviour
{
    private IEnemyFactory _enemyFactory;

    [Inject]
    public void Construct(IEnemyFactory enemyFactory) =>
        _enemyFactory = enemyFactory;

    private void Start() =>
        _enemyFactory.CreateEnemy(transform.position, Quaternion.Euler(0, -180, 0));
}
