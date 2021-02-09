using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFallAnim3 : MonoBehaviour
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
        anim.Play("CoinFallAnim3");
    }
}
