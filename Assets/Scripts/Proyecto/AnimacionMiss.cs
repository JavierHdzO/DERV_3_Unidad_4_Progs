using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionMiss : MonoBehaviour
{
    public static bool isCorrect = false;

    [SerializeField]
    Animator animator;

  
    //[SerializeField]
    //public static AudioClip audioClip;
    // Start is called before the first frame update

    private void Start()
    {
  
    }

    private void Update()
    {
        if (isCorrect)
        {
            animator.SetBool("isCorrect", true);
            

        }else
        {
            animator.SetBool("isCorrect", false);
        }
    }
}
