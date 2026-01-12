using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class DoorController : MonoBehaviour
{ 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    [SerializeField] LayerMask filter;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray detector = new Ray(transform.position, transform.forward);
            RaycastHit hitInfo;

            if(Physics.Raycast(detector, out hitInfo, 7f, filter))
            {
                ToggleDoor door = hitInfo.collider.GetComponent<ToggleDoor>();
                if (door != null)
                {
                    door.DoorToggle();
                    door.ButtonPress();
                    Debug.Log("Door toggled");
                }
                else
                {
                    Debug.Log("No door found");
                }
            }
        }
        
    }
}
