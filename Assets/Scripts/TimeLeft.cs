using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class TimeLeft : MonoBehaviour
{

    public float time = 30;
    public TextMeshProUGUI timeUI;
    public TextMeshProUGUI GameOver;
    public Button RestartButton;
    public bool RestartCall = false;
    public bool x = true;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }
    int end = 0;
    // Update is called once per frame
    void Update()
    {

        

        time -= Time.deltaTime;
        if (time >= 0)
        {
            
             
            timeUI.text = "Time: " + time.ToString();
        }
        else {

            timeUI.text = "Time: " + end.ToString();

            GameOverFun();

        }
        
    }
    public void GameOverFun() {

        if (x)
        {
            Time.timeScale = 0;
            x = false;
        }


        GameOver.gameObject.SetActive(true);
        RestartButton.gameObject.SetActive(true);
    }
}
