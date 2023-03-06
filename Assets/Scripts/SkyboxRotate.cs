using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxRotate : MonoBehaviour
{
    Skybox background;
    [SerializeField] float Skyboxspeed;
    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<Skybox>();

    }

    // Update is called once per frame
    void Update()
    {
        background.material.SetFloat("_Rotation", Time.time * Skyboxspeed);
    }
}
