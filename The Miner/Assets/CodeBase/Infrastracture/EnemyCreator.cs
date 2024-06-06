using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    [SerializeField] private EnemyPointSpawn[] _enemyPointSpawns;
    private void Awake() =>
        _enemyPointSpawns = GetComponentsInChildren<EnemyPointSpawn>();
}
