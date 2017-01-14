using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour { 
    public int points;
    public GameObject sparks;
    private static int score = 0;
    static Text scoreText;
    bool scored;

	void Start () {
        GameObject scoreObj = GameObject.Find("Score");
        scoreText = scoreObj.GetComponent<Text>();
        score += points;
        scoreText.text = score.ToString();
	}
	
    public void AddScore(int score)
    {
        ScoreScript.score += score;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Shape"))
        {
            Instantiate(sparks, this.transform.position, Quaternion.identity);
            Debug.Log("SPARK!");
        }
    }
}
