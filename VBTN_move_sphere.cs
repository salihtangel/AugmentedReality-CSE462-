using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN_sclale_sphere : MonoBehaviour
{

    public Animator sphereAnim;
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        sphereAnim.Play("movesphere");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
