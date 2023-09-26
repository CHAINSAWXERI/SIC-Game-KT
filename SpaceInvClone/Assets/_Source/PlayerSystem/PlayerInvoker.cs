using UnityEngine;

namespace PlayerSystem
{
    public class PlayerInvoker
    {
        private PlayerMovement _playerMovement;
        private PlayerComponent _playerComponent;

        public PlayerInvoker(PlayerComponent playerComponent)
        {
            _playerComponent = playerComponent;
            _playerMovement = new PlayerMovement();
        }

        public void Move()
        {
            _playerMovement.Move(_playerComponent.Rb, _playerComponent.movSpeed);
        }

    }
}
