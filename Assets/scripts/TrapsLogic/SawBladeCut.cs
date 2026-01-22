using UnityEngine;

public class SawBladeCut : MonoBehaviour
{
    [SerializeField] GameObject Player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DeathCounter.Instance.MuertesC();
            Player.transform.position = new Vector3(-7, 1, 0);
        }
    }
}
