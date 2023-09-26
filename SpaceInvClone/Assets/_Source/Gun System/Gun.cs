using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] public GameObject _bullet;
    [SerializeField] public Transform _shotpoint;

    private float _timeShot;
    public float _starttumeShot;

    // Update is called once per frame
    void Update()
    {

        if (_timeShot <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                Instantiate(_bullet, _shotpoint.position, transform.rotation);
                _timeShot = _starttumeShot;
            }
        }
        else
        {
            _timeShot -= Time.deltaTime;
        }
    }
}
