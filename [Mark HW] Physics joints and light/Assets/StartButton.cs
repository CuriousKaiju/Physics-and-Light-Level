using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{

    [SerializeField] private CatapultStarter _catapultStarter;
    private void OnMouseDown()
    {
        _catapultStarter.StartCatapult();
    }
}
