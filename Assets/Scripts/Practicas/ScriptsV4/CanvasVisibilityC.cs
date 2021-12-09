using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasVisibilityC : MonoBehaviour
{
    [SerializeField]
    Canvas canvas;

    public void setEnabledCanvas(bool state)
    {
        canvas.enabled = state;
    }

}
