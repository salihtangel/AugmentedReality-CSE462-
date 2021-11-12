using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN_sphere_scale   : MonoBehaviour
{

    public Animator sphereAnim;
    public VirtualButtonBehaviour Vb2;
    // Start is called before the first frame update
    void Start()
    {
        Vb2.RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        sphereAnim.Play("scalesphere");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
