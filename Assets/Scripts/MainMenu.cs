using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public bool gameOver = true;

    [SerializeField] 
    private GameObject _popUpCanvasObject;
    private Canvas popUpCanvas;

    private void Awake () 
    {
        popUpCanvas = _popUpCanvasObject.GetComponent<Canvas>();
        Time.timeScale = 0f;
    }

    public void PlayGame() 
    {
        gameOver = false;
        Time.timeScale = 1f;
    }

    public void QuitGame() 
    {
        Application.Quit();

    }

    public void HideInfo() 
    {
        _popUpCanvasObject.SetActive(false);
    }

}
