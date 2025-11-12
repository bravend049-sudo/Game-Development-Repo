using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour
{
    public int scoreToGive;
    public float bobHeight;
    public float bobSpeed;
    private float startYPos;

    private void Start()
    {
        startYPos = transform.position.y;
    }

    private void Update()
    {
        float newY = startYPos + (Mathf.Sin(Time.time * bobSpeed) * bobHeight);
        transform.position = new Vector3(transform.position.x, newY, 0);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerControllerScript2D>().AddScore(scoreToGive);
            Destroy(gameObject);
        }
    }
}
