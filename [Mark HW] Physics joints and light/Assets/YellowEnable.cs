using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowEnable : MonoBehaviour
{
    [SerializeField] private GameObject _blowAnim;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            Instantiate(_blowAnim, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
