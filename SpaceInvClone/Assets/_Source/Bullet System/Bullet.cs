using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float _speed;
    public float _lifetime;
    public float _distance;
    public LayerMask _whatIsSolid;
    private float _maTime = 3f;
    private float _timeLeft;

    private void Start()
    {
        _timeLeft = _maTime;
    }
    private void Update()
    {
        if (_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
            Debug.DrawRay(transform.position, -transform.right * _distance);
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
