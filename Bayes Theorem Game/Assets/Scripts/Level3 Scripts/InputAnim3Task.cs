﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputAnim3Task : MonoBehaviour
{
    public Animation anim;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            anim = GetComponent<Animation>();
            //anim.Play("InputAnim");
        }
    }

    public void AnimPlay()
    {
        anim.Play("InputAnim3Task");
    }
}
