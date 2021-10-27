using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBGScroll : MonoBehaviour
{
    // Ref: https://youtu.be/-6H-uYh80vc

    [Tooltip("Reference Raw Image Here!")] [SerializeField] private RawImage rawIMG;    // Set scrolling image's "Wrap Mode" to "Repeat"
    [Tooltip("Set the speed of the X and Y")] [SerializeField] private float x, y;

    void Update()
    {
        rawIMG.uvRect = new Rect(rawIMG.uvRect.position + new Vector2(x, y) * Time.deltaTime, rawIMG.uvRect.size);
    }
}
