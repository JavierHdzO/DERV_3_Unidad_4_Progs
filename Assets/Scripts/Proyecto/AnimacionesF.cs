using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionesF : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    Animator animator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalk", true);
               
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("isWalk", false);

        }


    }
}
