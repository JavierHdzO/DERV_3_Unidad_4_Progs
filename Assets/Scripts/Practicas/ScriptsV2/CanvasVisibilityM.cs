using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasVisibilityM : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Canvas canvas;
    public void setEnabledCanvas(bool state)
    {
        canvas.enabled = state;
    }
}
