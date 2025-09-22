using UnityEngine;

public class DeleteParticle : MonoBehaviour
{

    public int timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, timer);
    }
}
