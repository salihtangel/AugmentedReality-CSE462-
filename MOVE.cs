﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MOVE : MonoBehaviour
{
    public Animator cubeAnim;
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeAnim.Play("movecube");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
