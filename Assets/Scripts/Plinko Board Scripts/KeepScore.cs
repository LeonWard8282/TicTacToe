using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class KeepScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _plinkoScoreBoard;
    public static int Score = 0;
    public bool togglereset = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( togglereset == true)
        {
            Score = 0;
            togglereset = false;
        }
    }

    public void ScoreBoardMethod()
    {
        _plinkoScoreBoard.text = "Score: " + Score.ToString();


    }

}
