using System;
using UnityEngine;

public class ToggleDoor : MonoBehaviour
{
    Animator Anim;
    Boolean isOpen = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DoorToggle()
    {

        if (isOpen == false)
        {
            isOpen = true;
            Anim.SetBool("Open", true);
        }
        else if (isOpen == true)
        {
            isOpen = false;
            Anim.SetBool("Open", false);
        }
    }
}
