using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonHandler : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject button;
    public GameObject leftDoor;
    public GameObject rightDoor;
    bool doorOpen;
    // Start is called before the first frame update
    void Start()
    {
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        doorOpen = false;
    }
    private void Update()
    {
        if (doorOpen)
        {
            if (leftDoor.transform.rotation.y != -90)
            {
                leftDoor.transform.Rotate(0, -1, 0);
            }
            if (rightDoor.transform.rotation.y != 90)
            {
                rightDoor.transform.Rotate(0, 1, 0);
            }
        }
        else
        {
            if (leftDoor.transform.rotation.y != 0)
            {
                leftDoor.transform.Rotate(0, 1, 0);
            }
            if (rightDoor.transform.rotation.y != 0)
            {
                rightDoor.transform.Rotate(0, -1, 0);
            }
        }
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        doorOpen = true;   
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        doorOpen = false;
    }
}
