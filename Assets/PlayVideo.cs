using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class PlayVideo : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject button;
    public VideoPlayer video;
    // Start is called before the first frame update
    void Start()
    {
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        video.Play();
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        video.Stop();
    }
}
