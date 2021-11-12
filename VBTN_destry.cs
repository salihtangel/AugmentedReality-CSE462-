using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN_destry : MonoBehaviour
{
    public GameObject cube;
    public VirtualButtonBehaviour Vb;


    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.SetActive(false);
        
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}
