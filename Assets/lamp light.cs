using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampLight : MonoBehaviour
{
    [SerializeField] Light[] bulbs; // Array to hold multiple lights
    [SerializeField] Material bulbOn;
    [SerializeField] Material bulbOff;
    [SerializeField] Renderer[] lampShades; // Array to hold multiple lampshades

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            ToggleLamps(true);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            ToggleLamps(false);
        }
    }

    void ToggleLamps(bool state)
    {
        // Toggle light state
        foreach (Light bulb in bulbs)
        {
            bulb.enabled = state;
        }

        // Toggle material on each lampshade
        foreach (Renderer shade in lampShades)
        {
            shade.material = state ? bulbOn : bulbOff;
        }
    }
}

