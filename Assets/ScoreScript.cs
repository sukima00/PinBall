using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{

    // スコアを表示するテキスト
    private GameObject scoreText;

    // スコアの初期値
    int score = 0;

    // Use this for initialization
    void Start()
    {

        // シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");

    }

    // Update is called once per frame
    void Update()
    {

        // ScoreTextにスコアを表示
        this.scoreText.GetComponent<Text>().text = "score : " + score;

    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other){

        // タグによって異なる点数を加算する
        if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 10;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 30;
        }
    }
}