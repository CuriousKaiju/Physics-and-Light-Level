using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatapultStarter : MonoBehaviour
{
    
    [SerializeField] private float _movingSpeed;
    [SerializeField] private float _blastInitialTime;
    [SerializeField] private Transform _finishPosition;
    [SerializeField] private FixedJoint _fixedJoint;
    [SerializeField] private Text _timer;
    private bool _catapultCanMove;

    void FixedUpdate()
    {
        if(_catapultCanMove)
        {
            _blastInitialTime -= Time.deltaTime;
            _timer.text = _blastInitialTime.ToString("0.00");
            transform.position = Vector3.MoveTowards(transform.position, _finishPosition.position, _movingSpeed);
            if(_blastInitialTime <= 0)
            {
                _catapultCanMove = false;
                _timer.text = "0.00";
                Destroy(_fixedJoint);
            }
        }
    }
    public void StartCatapult()
    {
        _catapultCanMove = true;
    }
    
}
