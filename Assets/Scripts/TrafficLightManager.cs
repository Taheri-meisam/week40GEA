using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightManager : MonoBehaviour
{
    public GameObject redLight;
    public GameObject greenLight;
    public int lightStatus;

    // Start is called before the first frame update
    void Start()
    {
        redLight.GetComponent<Renderer>().material.color = Color.white;
        greenLight.GetComponent<Renderer>().material.color = Color.white;
        lightStatus = 0;
        InvokeRepeating("LightManagement", 2.0f, 3.0f);
    }

    public int LightManagement()
    {
        if (lightStatus == 0)
        {
            greenLight.GetComponent<Renderer>().material.color = Color.green;
            redLight.GetComponent<Renderer>().material.color = Color.white;
            lightStatus = 1;
            return lightStatus;

        }
        else if (lightStatus == 1)
        {
            greenLight.GetComponent<Renderer>().material.color = Color.white;
            redLight.GetComponent<Renderer>().material.color = Color.red;
            lightStatus = 0;
            return lightStatus;
        }
        return -1;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
