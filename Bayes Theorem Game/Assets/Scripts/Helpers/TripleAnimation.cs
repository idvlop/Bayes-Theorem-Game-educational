using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleAnimation : MonoBehaviour
{

    public Animation anim1;
    public Animation anim2;
    public Animation anim3;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            anim1 = GetComponent<Animation>();
            anim2 = GetComponent<Animation>();
            anim3 = GetComponent<Animation>();
            //anim.Play("InputAnim");
        }
    }

    public void AnimPlay()
    {
        anim1.Play("Chel1Anim");
        anim2.Play("Chel2Anim");
        anim3.Play("Chel3Anim");
    }
}