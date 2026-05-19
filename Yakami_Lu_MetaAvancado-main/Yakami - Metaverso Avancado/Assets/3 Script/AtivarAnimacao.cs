using UnityEngine;

public class AtivarAnimacao : MonoBehaviour
{
    public Animator anim;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.enabled = false;
        }
    }
}