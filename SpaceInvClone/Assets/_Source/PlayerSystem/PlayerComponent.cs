using UnityEngine;

namespace PlayerSystem
{
    [RequireComponent(typeof (Rigidbody2D))]
    public class PlayerComponent : MonoBehaviour
    {
        [SerializeField] private float MovSpeed;
        public float movSpeed => MovSpeed;
        [SerializeField] private Rigidbody2D rb;
        public Rigidbody2D Rb => rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }
    }
}

