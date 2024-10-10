using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class MoveTheSquare : MonoBehaviour
{
    public XRLever lever;
    public Animator anim;
    //public float forwardSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*float forwardVelocity = forwardSpeed * (lever.value ? 1 : 0);

        Vector3 velocity= new Vector3(0, 0, forwardVelocity);
        transform.position += velocity*Time.deltaTime;*/

        // the above is the code to move the cube forward upon pushing the lever.

        //triggering an animation using lever
        string state = (lever.value ? "cubeMovement" : "default");
        anim.Play(state);

    }
}
