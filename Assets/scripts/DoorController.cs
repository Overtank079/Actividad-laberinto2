using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class DoorController : MonoBehaviour
{ 
    [SerializeField] LayerMask interactLayers;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray detector = new Ray(transform.position, transform.forward);
            RaycastHit hitInfo;

            if(Physics.Raycast(detector, out hitInfo, 7f, interactLayers))
            {
                ToggleDoor door = hitInfo.collider.GetComponentInParent<ToggleDoor>();
                if (door != null)
                {
                    door.DoorToggle();
                }
            }
        }
        
    }
}
