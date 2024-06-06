using UnityEngine;

public class WeapointArray : MonoBehaviour
{
    [SerializeField]private Weapoint[] _weapoints;
    private void Start() =>
        _weapoints = GetComponentsInChildren<Weapoint>();
    public Weapoint[] GetWeapointArray() =>
        _weapoints;
}
