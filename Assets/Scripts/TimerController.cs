using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    [SerializeField]
    float timer = 121.0F;

    [SerializeField]
    Text textTimer;

    Level3DManager levelManager;

    void Awake()
    {
        levelManager = FindObjectOfType<Level3DManager>();

    }

    void Update()
    {
        timer -= Time.deltaTime;

        textTimer.text = "" + timer.ToString();

        Finish();
    } 

    void Finish()
    {
        if (timer < 0.0F)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
