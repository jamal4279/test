using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    public GameObject gs;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveRight()
    {
        anim.Play("Walking");
    }
    public void MoveLeft()
    {
        anim.Play("Happy Idle");
    }
    public void Stunt()
    {
        anim.Play("Run To Flip");
    }
}
