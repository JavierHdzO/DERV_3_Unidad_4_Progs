using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCanva : MonoBehaviour
{
    [SerializeField]
    Canvas canvas;

    public void setEnableCanvas(bool state) 
    {
        canvas.enabled = state;

    }
}
