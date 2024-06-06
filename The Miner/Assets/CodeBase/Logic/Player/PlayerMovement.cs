using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

namespace Assets.CodeBase.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private GameObject[] Weapoints;

        private int _currentIndex = 0;
        private NavMeshAgent _agent;
        private PlayerAnimator _animator;
        private void Awake()
        {
            _agent = GetComponent<NavMeshAgent>();
            _animator = GetComponentInChildren<PlayerAnimator>();
            Weapoints = GameObject.FindGameObjectsWithTag("Weapoint");
        }
        private void Start()
        {
            transform.position = Weapoints[_currentIndex].transform.position;
        }
        private void Update()
        {
                _agent.SetDestination(Weapoints[_currentIndex].transform.position);
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (_currentIndex == Weapoints.Length - 1)
                {
                    SceneManager.LoadScene("Main");
                }
                _currentIndex++;
            }
            //for (int i = 0; i < Weapoints.Length; i++)
            //{
            //    if (Input.GetKeyDown(KeyCode.W))
            //    {
            //        Debug.Log("+");
            //        _agent.SetDestination(Weapoints[i].position);
            //    }
            //}
            //if (Input.GetKeyDown(KeyCode.W))
            //{
            //    _agent.SetDestination(Weapoints[1].position);
            //    _animator.Move(true);
            //}
            //if (Vector3.Distance(transform.position, Weapoints[1].position) <= 0.1f)
            //{
            //    _animator.Move(false);
            //}
        }
    }
}