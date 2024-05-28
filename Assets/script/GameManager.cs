using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int Score_L;
    public int Score_R;
    public string WinnerL,WinnerR;
    public TMP_Text Winner;

    public TMP_Text Player_Score_L;
    public TMP_Text Player_Score_R;
    public GameObject Pannelwin;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        Score_L = 0;
        Score_R = 0;

        Player_Score_L.text = Score_L.ToString();
        Player_Score_R.text = Score_R.ToString();
    }

    public void score(string wallID)
    {
        if (wallID == "Goal_L")
        {
            Score_R = Score_R + 1;
            Player_Score_R.text = Score_R.ToString();
            scoring();
        }

        else 
        {
            Score_L = Score_L + 1;
            Player_Score_L.text = Score_L.ToString();
            scoring();
        }
        
    }

    public void scoring()
    {
        if(Score_L == 10)
        {
            Winner.text = WinnerL;
            Pannelwin.SetActive(true);
        }
        else if(Score_R == 10)
        {
            Winner.text = WinnerR;
            Pannelwin.SetActive(true);
        }
    }
}
