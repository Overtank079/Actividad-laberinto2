using UnityEngine;

public class Info : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] LayerMask LayerToInteract;
    [SerializeField] GameObject Canvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ;
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitinfo, 3f, LayerToInteract))
        {
            Canvas.SetActive(true);
        }
        else
        {
            Canvas.SetActive(false);
        }
    }
}
