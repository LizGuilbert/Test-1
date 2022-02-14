using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlodSpawn : MonoBehaviour
{
    public int gold;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public float timeLeft;
    void Start()
    {
        transform.position = new Vector3(Random.Range(-4.0f, 5.0f), transform.position.y,Random.Range(-6.5f,2.6f));
        RefreshText();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        transform.position = new Vector3(Random.Range(-4.0f, 5.0f), transform.position.y,Random.Range(-6.5f,2.6f));
        Addpoints(1);
    }
    
    public void Addpoints(int points)
    {
        gold += points;
        RefreshText();
    }
    
    void RefreshText()
    {
        scoreText.text = "Score : " + gold;
        timerText.text = "Time : " + timeLeft;
    }
    
    
    
    void Update()
    {
        RefreshText();
        timeLeft -= Time.deltaTime;
        if ( timeLeft < 0 )
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Time.timeScale = 0;
    }
}
