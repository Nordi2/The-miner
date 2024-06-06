using UnityEngine;

public interface IPlayerFactory
{
    GameObject CreateHero(Vector3 at);
}