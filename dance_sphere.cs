using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class dance_sphere : MonoBehaviour
{
    public Animator danceSphere;
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        danceSphere.Play("dancesphere");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
