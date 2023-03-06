using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotator : MonoBehaviour
{


    [SerializeField] Vector3 m_rotationAxis;

    
    void Update()
    {
        RotateIt();
    }

    void RotateIt() => transform.Rotate(m_rotationAxis * Time.deltaTime);



}
