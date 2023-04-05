using UnityEngine;

namespace Canoe
{
    public class Paddle : MonoBehaviour
    {
        [SerializeField] private CanoeContinuousMoveProvider _moveProvider;
        [SerializeField] private LayerMask _waterLayer;
        
        private void Move(float forward) => _moveProvider.ForwardSpeed = forward;
        
        private void OnTriggerEnter(Collider other)
        {
            if (_waterLayer.Contains(other.gameObject.layer))
            {
                Move(1);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (_waterLayer.Contains(other.gameObject.layer))
            {
                Move(0);
            }
        }
    }
}
