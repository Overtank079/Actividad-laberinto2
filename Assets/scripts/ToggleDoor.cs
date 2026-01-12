using System;
using UnityEngine;

public class ToggleDoor : MonoBehaviour
{
    Animator DoorToOpenA;
    Animator DAnim;
    [SerializeField] GameObject DoorToOpen;
    Boolean isOpen = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DoorToOpenA = DoorToOpen.GetComponent<Animator>();
         DAnim = GetComponent<Animator>();
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
            DoorToOpenA.SetBool("Open", true);
        }
        else if (isOpen == true)
        {
            isOpen = false;
            DoorToOpenA.SetBool("Open", false);
        }
    }
    public void ButtonPress()
    {

            DAnim.SetBool("Pressed", true);
    }
}
