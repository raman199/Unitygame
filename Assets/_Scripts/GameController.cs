using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    
  [Header("Stone Configuration")]
    public int StoneNum;
    public GameObject stone;

    public Transform stoneContainer;

    public List<GameObject> stones;

  [Header("Scoreboard")]
  public Text LivesLabel;
  public Text  ScoreLabel;
 
 private int _lives;
 public int Lives
 {
     get { return _lives; }
     set { 
         _lives = value; 
         LivesLabel.text = "Lives : " + _lives.ToString();
         if(_lives < 1)
         {
             SceneManager.LoadScene("End");
         }
             }
 }
 
 private int _score;
 public int Score
 {
     get { return _score; }
     set { _score = value;  ScoreLabel.text = "Score :" + _score.ToString(); }
 }
 


    // Start is called before the first frame update
    void Start()
    {
        stones = new List<GameObject>(); 
        _buildStoneList();
        Lives = 5;
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void _buildStoneList()
    {
       for(int count = 0; count < StoneNum; count++)
       {
           var newstone = Instantiate(stone);
           newstone.transform.parent = stoneContainer.transform;
;           stones.Add(newstone);
       }

    }
}
