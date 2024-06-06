using UnityEngine;
using Zenject;

public class PlayerCreator : MonoBehaviour
{
    private  IPlayerFactory _playerFactory;
    [Inject]
    public void Construct(IPlayerFactory playerFactory) 
    {
        _playerFactory = playerFactory;
    }
    private void Start()
    {
        _playerFactory.CreateHero(transform.position);
    }
}
