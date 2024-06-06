using UnityEngine;

public interface IEnemyFactory
{
    public GameObject CreateEnemy(Vector3 at, Quaternion quaternion);
}