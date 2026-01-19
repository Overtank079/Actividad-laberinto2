using TMPro;
using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class DeathCounter : MonoBehaviour
{
    public static DeathCounter Instance;
    [SerializeField] private TextMeshProUGUI DeathCountText;
    int Muertes = 0;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        DeathCountText.text = "Muertes: " + Muertes;
    }
    public void MuertesC()
    {
        Muertes++;
        DeathCountText.text = "Muertes: " + Muertes;
    }
}
