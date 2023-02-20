using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScr : MonoBehaviour
{

    private void Start()
    {
        
    }
    public void OnButtonPress()
    {
        //Tl.time = 30;
        //Tl.GameOver.gameObject.SetActive(false);
        //Tl.RestartButton.gameObject.SetActive(false);

        //Tl.RestartCall = true;
        //Debug.Log("RESTART PRESSED!" + Tl.RestartCall);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

}
