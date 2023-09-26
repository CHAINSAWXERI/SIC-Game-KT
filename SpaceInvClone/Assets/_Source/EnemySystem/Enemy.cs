using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Experimental.GraphView.GraphView;


public class Enemy : MonoBehaviour
{
    private LoadScene _loadScene;
    [SerializeField] int SceneNum;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Dead End"))
        {
            SceneManager.LoadScene(SceneNum);
        }
        if (collision.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
