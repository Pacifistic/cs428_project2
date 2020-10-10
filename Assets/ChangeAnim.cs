using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChangeAnim : MonoBehaviour
{

    public GameObject button;
    public Animator dominyk;

    // Start is called before the first frame update
    void Start()
    {
        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    void OnButtonPressed(VirtualButtonBehaviour vb) {
        Debug.Log("Button Pressed");
        dominyk.SetBool("Button", true);
    }

    void OnButtonReleased(VirtualButtonBehaviour vb) {
        Debug.Log("Button Released");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
