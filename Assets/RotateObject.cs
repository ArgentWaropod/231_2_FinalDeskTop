using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class RotateObject : MonoBehaviour, IVirtualButtonEventHandler
{
    bool rotating;
    public GameObject button;
    public GameObject obj;
    public bool isRotatingLeft;
    // Start is called before the first frame update
    void Start()
    {
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (rotating)
        {
            if (isRotatingLeft)
            {
                obj.transform.Rotate(0, 1, 0);
            }
            else
            {
                obj.transform.Rotate(0, -1, 0);
            }
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        rotating = true;
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        rotating = false;
    }
}
