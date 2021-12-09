using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimation : MonoBehaviour
{
    [SerializeField]
    GameObject personajes;

    Animator animation;

    private void Start()
    {
        animation = personajes.GetComponent<Animator>();
  
    }

    public void standing()
    {
        animation.Play("Standing");
    }

    public void walk()
    {
        animation.Play("Walk");
    }

    public void fight()
    {
        animation.Play("fight");
    }

    public void Rifle_turn()
    {
        animation.Play("Rifle_turn");
    }
}
