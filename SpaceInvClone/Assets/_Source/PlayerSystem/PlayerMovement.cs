using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlayerSystem
{
    public class PlayerMovement
    {
        public void Move(Rigidbody2D rb, float speed)
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0);
        }

    }
}
