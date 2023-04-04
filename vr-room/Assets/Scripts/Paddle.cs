using UnityEngine;

namespace Canoe
{
    public class Paddle : MonoBehaviour
    {
        [SerializeField] private CanoeContinuousMoveProvider _moveProvider;
        [SerializeField] private LayerMask _waterLayer;
        
        public System.Action OnPaddleEnteredWater;
        public System.Action OnPaddleExitedWater;

        private void OnEnable()
        {
            OnPaddleEnteredWater += () => AdjustMoveInput(1);
            OnPaddleExitedWater += () => AdjustMoveInput(0);
        }

        private void OnDisable()
        {
            OnPaddleEnteredWater = null;
            OnPaddleExitedWater = null;
        }

        private void AdjustMoveInput(float forward) => _moveProvider.ForwardSpeed = forward;
        
        private void OnTriggerEnter(Collider other)
        {
            if (_waterLayer.Contains(other.gameObject.layer))
            {
                OnPaddleEnteredWater?.Invoke();
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (_waterLayer.Contains(other.gameObject.layer))
            {
                OnPaddleExitedWater?.Invoke();
            }
        }
    }
}
