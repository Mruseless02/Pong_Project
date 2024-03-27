using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int player_1_Score = 0;
    public int player_2_Score = 0;
    public TMP_Text txt_PlayerScore_1;
    public TMP_Text txt_PlayerScore_2;

    public static GameManager Instance;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        txt_PlayerScore_1.text = PlayerScore_1.Tostring();
        txt_PlayerScore_2.text = PlayerScore_2.Tostring();
    }
}
