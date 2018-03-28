using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    [SerializeField]
    public GameObject[] Player_scoreNum;
    [SerializeField]
    public GameObject[] Enemy_scoreNum;

    public Transform goFarAway;

    GameObject P_ShownScore;
    GameObject E_ShownScore;

    public int Player_score = 0;
    public int Enemy_score = 0;
    //public List<GameObject> playerOneSpawnedNums;
    GameObject zero;
    public Transform Player_NumPos;
    public Transform Enemy_NumPos;
	// Use this for initialization
	void Start () {
      //  playerOneSpawnedNums =
        for(int i = 0;i <= 9; i++)
        {
           GameObject dummy = Instantiate(Player_scoreNum[i], goFarAway);
            if(i == 0)
            {
                zero = dummy;
            }
            Instantiate(Enemy_scoreNum[i], goFarAway);
        }
        

    }
	
	// Update is called once per frame
	void Update () {
        ShowScore(Player_score, Enemy_score);
	}

    void ShowScore(int P_Score, int E_Score)
    {
        switch(P_Score)
        {
            case 0:
                //Player_scoreNum[0].gameObject.SetActive(true);
                //Player_scoreNum[0].transform.position = Player_NumPos.position;
                zero.gameObject.SetActive(true);
                zero.transform.position = Player_NumPos.position;
                zero.transform.rotation = Player_NumPos.rotation;
                break;
            case 1:
                P_ShownScore = Instantiate(Player_scoreNum[1], P_ShownScore.transform);
                break;
            case 2:
                P_ShownScore = Instantiate(Player_scoreNum[2], P_ShownScore.transform);
                break;
            case 3:
                P_ShownScore = Instantiate(Player_scoreNum[3], P_ShownScore.transform);
                break;
            case 4:
                P_ShownScore = Instantiate(Player_scoreNum[4], P_ShownScore.transform);
                break;
            case 5:
                P_ShownScore = Instantiate(Player_scoreNum[5], P_ShownScore.transform);
                break;
            case 6:
                P_ShownScore = Instantiate(Player_scoreNum[6], P_ShownScore.transform);
                break;
            case 7:
                P_ShownScore = Instantiate(Player_scoreNum[7], P_ShownScore.transform);
                break;
            case 8:
                P_ShownScore = Instantiate(Player_scoreNum[8], P_ShownScore.transform);
                break;
            case 9:
                P_ShownScore = Instantiate(Player_scoreNum[9], P_ShownScore.transform);
                break;
        }
        

        switch (E_Score)
        {
            case 0:
                E_ShownScore = Instantiate(Enemy_scoreNum[0], E_ShownScore.transform);
                break;
            case 1:
                E_ShownScore = Instantiate(Enemy_scoreNum[1], E_ShownScore.transform);
                break;
            case 2:
                E_ShownScore = Instantiate(Enemy_scoreNum[2], E_ShownScore.transform);
                break;
            case 3:
                E_ShownScore = Instantiate(Enemy_scoreNum[3], E_ShownScore.transform);
                break;
            case 4:
                E_ShownScore = Instantiate(Enemy_scoreNum[4], E_ShownScore.transform);
                break;
            case 5:
                E_ShownScore = Instantiate(Enemy_scoreNum[5], E_ShownScore.transform);
                break;
            case 6:
                E_ShownScore = Instantiate(Enemy_scoreNum[6],E_ShownScore.transform);
                break;
            case 7:
                E_ShownScore = Instantiate(Enemy_scoreNum[7], E_ShownScore.transform);
                break;
            case 8:
                E_ShownScore = Instantiate(Enemy_scoreNum[8], E_ShownScore.transform);
                break;
            case 9:
                E_ShownScore = Instantiate(Enemy_scoreNum[9], E_ShownScore.transform);
                break;
        }

        //E_ShownScore.transform.position = Enemy_NumPos.transform.position;
        
    }
}
