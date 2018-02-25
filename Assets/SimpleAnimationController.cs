using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAnimationController : MonoBehaviour {

    public Animator Anim;
    public PlayerMovementAdaptor Movement;

    public void Update()
    {
        Anim.SetBool("Shoot", Input.GetMouseButton(0));
        Anim.SetBool("ADS", Input.GetMouseButton(1));
        Anim.SetBool("Run", Movement.HorizontalMovement.magnitude > 0.5f);
    }
}
