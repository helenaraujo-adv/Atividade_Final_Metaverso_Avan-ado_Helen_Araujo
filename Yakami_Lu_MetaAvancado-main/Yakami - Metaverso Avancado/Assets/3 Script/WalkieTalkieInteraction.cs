using UnityEngine;

public class RadioSom : MonoBehaviour
{
    public AudioSource audioRadio;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioRadio.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioRadio.Stop();
        }
    }
}