using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public static MainMenu mm;
    public GameObject gameLabel;

    public enum GameState
    {
        Ready,
        Start,
        Quit
    }
    // Start is called before the first frame update
    private void Awake()
    {
        if (mm = null)
        {
            mm = this;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClickStartGame()
    {
        Debug.Log("Start");
        StartCoroutine(ReadyToStart());
    }

    public void OnClickQuit()
    {

        //Application.Quit();

        //UnityEngine에서 사용
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
         Application.Quit();
        #endif
    }




    public GameState gState;
    // Start is called before the first frame update
    void Start()
    {
        gState = GameState.Ready;


    }

    // Update is called once per frame



    IEnumerator ReadyToStart()
    {
        gameLabel.SetActive(false);

        yield return new WaitForSeconds(2f);
        gState = GameState.Start;
    }

}
