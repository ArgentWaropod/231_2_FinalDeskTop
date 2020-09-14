using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Vuforia;

public class CatchFish : MonoBehaviour, IVirtualButtonEventHandler
{
    float activeTimer;
    float inactiveTimer;
    int count = 0;
    bool reset;
    public GameObject button;
    public GameObject fish;
    public TextMeshPro textCounter;


    // Start is called before the first frame update
    void Start()
    {
        fish.gameObject.SetActive(false);
        reset = true;
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (!fish.gameObject.activeSelf)
        {
            inactiveTimer -= Time.deltaTime;
            if (inactiveTimer <= 0)
            {
                fish.gameObject.SetActive(true);
                activeTimer = setActiveTimer();
                reset = false;
            }
        }
        else
        {
            activeTimer -= Time.deltaTime;
            if (activeTimer <= 0)
            {
                fish.gameObject.SetActive(false);
                inactiveTimer = setInactiveTimer();
                reset = true;
            }
        }
        textCounter.SetText("Fish Caught = " + count);
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (!reset)
        {
            count++;
            fish.gameObject.SetActive(false);
            reset = true;
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    }

    float setActiveTimer()
    {
        return Random.Range(0.25f, 3);
    }
    float setInactiveTimer()
    {
        return Random.Range(3, 10);
    }
}
