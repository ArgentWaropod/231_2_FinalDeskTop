using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Vuforia;

public class EatTree : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject button;
    public GameObject[] trees;
    int counter;
    int totalSize;
    float percentage;
    public TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        counter = trees.Length;
        totalSize = counter;
    }
    private void Update()
    {
        text.SetText("Percent Eat: " + ((counter / totalSize) * 100) + "%");

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        trees[counter].gameObject.SetActive(false);
        counter--;
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }
}
