using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    public Image bloodOverlay; // Reference to the blood PNG on the canvas
    public AttributesManager playerAttributes; // Reference to the player's attributes manager

    void Update()
    {
        // Calculate the blood opacity based on the player's current health
        float healthPercent = Mathf.Clamp01((float)playerAttributes.health / 100f);
        float bloodOpacity = Mathf.Lerp(1f, 0f, healthPercent); // Blood is fully opaque at 0 health, transparent at full health

        Color newColor = bloodOverlay.color;
        newColor.a = bloodOpacity;
        bloodOverlay.color = newColor;
    }
}