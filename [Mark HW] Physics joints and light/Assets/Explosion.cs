using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float _explosionForce;
    [SerializeField] private float _explosionRadious;
    [SerializeField] private GameObject _blowAnim;
    
    private void ExplosionFunction()
    {
        var colliders = Physics.SphereCastAll(transform.position, _explosionRadious, transform.forward);
        foreach(var hit in colliders)
        {
            var rigidbory = hit.collider.GetComponent<Rigidbody>();
            if(rigidbory != null)
            {
                rigidbory.AddExplosionForce(_explosionForce, transform.position, _explosionRadious);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Box"))
        {
            ExplosionFunction();
            Instantiate(_blowAnim, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
