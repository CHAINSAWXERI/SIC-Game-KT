using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] public GameObject _enemy;

    private float _timeStart;
    private float _rndposition;
    private Vector2 _whereToSpawn;

    private void Start()
    {
        _timeStart = Random.Range(1, 6);
        _rndposition = Random.Range(-8.5f, 6.68f);
    }
    void Update()
    {

        if (_timeStart <= 0)
        {
            _whereToSpawn = new Vector2(_rndposition, transform.position.y);
            Instantiate(_enemy, _whereToSpawn, transform.rotation);
            _timeStart = Random.Range(1, 6);
            _rndposition = Random.Range(-8.5f, 6.68f);
        }
        else
        {
            _timeStart -= Time.deltaTime;
        }
    }
}
