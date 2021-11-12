using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class Anim2 : MonoBehaviour
{
    public Animator anim1;
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        anim1.Play("a_Running");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
