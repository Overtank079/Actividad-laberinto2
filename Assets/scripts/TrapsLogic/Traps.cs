using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Traps : MonoBehaviour
{
    [SerializeField] Animator TrapAnimation;
    [SerializeField] GameObject Player;
    bool Playerinside = false;
    bool Respawn = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        TrapAnimation.SetBool("IsReady?", true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Playerinside = true;
        }
        if (other.CompareTag("Player") && TrapAnimation.GetBool("IsReady?"))
        {
            StartCoroutine(Cooldown());
        }
        if (TrapAnimation.GetBool("Kill") && Playerinside == true && !Respawn)
        {
            Respawn = true;
            Player.transform.position = new Vector3(-7, 1, 0);
            DeathCounter.Instance.MuertesC();

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Playerinside = false;
        }

    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(1);
        TrapAnimation.SetTrigger("PlayerDetected");
        TrapAnimation.SetBool("Kill", true);
        TrapAnimation.SetBool("CD", true);
        yield return new WaitForSeconds(1);
        TrapAnimation.SetBool("Kill", false);
        TrapAnimation.SetBool("IsReady?", false);
        TrapAnimation.ResetTrigger("PlayerDetected");
        yield return new WaitForSeconds(6);
        Respawn = false;
        TrapAnimation.SetBool("CD", false);
        TrapAnimation.SetBool("IsReady?", true);
    }
}
