using UnityEngine;

namespace Assets.CodeBase.Player
{
    public class PlayerAnimator : MonoBehaviour
    {
        private static readonly int MoveHash = Animator.StringToHash("IsRun");
        private Animator _animator;
        private void Awake() =>
            _animator = GetComponent<Animator>();
        public void Move(bool isRun) =>
            _animator.SetBool(MoveHash, isRun);
    }
}