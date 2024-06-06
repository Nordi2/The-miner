using UnityEngine;

namespace Assets.CodeBase.Infrastracture.AssetManagment
{
    public interface IAssetProvider
    {
        GameObject Instantiate(string path, Vector3 at);
        GameObject Instantiate(string path, Vector3 at,Quaternion quaternion);
    }
}