using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeFunction : MonoBehaviour
{
    [SerializeField] private HingeJoint _conntectionJoinfOfRope;
    private void OnMouseDown()
    {
        Destroy(_conntectionJoinfOfRope);
    } 
}
