using UnityEngine;

public class ScriptSalida : MonoBehaviour
{
    [SerializeField] GameObject toActivate;
    private void OnTriggerEnter(Collider other)
    {
        toActivate.SetActive(true);
    }
}
