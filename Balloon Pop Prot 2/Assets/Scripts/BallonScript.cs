using UnityEngine;

public class BallonScript : MonoBehaviour
{
    public int clickToPop = 3;
    public float scaleToIncrease = 0.10f;
    public int scoreToGive;

    public float upperBound = 15.0f;

    public ScoreManager scoreManager;

    public GameObject popEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        GetComponent<ScoreManager>();
    }

    void OnMouseDown()
    {
        clickToPop -= 1;
        transform.localScale += Vector3.one + scaleToIncrease;

        if (clickToPop == 0)
        {
            scoreManager.IncreaseScoreText(scoreToGive);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
