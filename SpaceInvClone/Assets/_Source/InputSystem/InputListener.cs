using PlayerSystem;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private PlayerComponent _playerComponent;
        private PlayerInvoker _playerInvoker;

        void Start()
        {
            _playerInvoker = new PlayerInvoker(_playerComponent);

        }
        void Update()
        {
            ReadMove();
        }

        private void ReadMove()
        {
            _playerInvoker.Move();
        }
    }
}