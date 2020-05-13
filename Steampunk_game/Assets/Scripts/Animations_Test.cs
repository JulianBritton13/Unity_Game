using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations_Test : MonoBehaviour
{
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        
        if(y < 0.25 && y >=0)
        {
            y = 0f;
        }
        else if(y >= 0.25 && y < 0.75)
        {
            y = 0.5f;
        }
        else if(y >= 0.75)
        {
            y = 1f;
        }
        else if(y < 0)
        {
            y = -0.5f;
        }
        animator.SetFloat("xFloat", x);
        animator.SetFloat("yFloat", y);
    }
}
