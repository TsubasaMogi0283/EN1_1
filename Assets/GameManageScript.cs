//using・・・includeみたいなやつ
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using Debug = UnityEngine.Debug;


//ヘッダは無いよ!!

//C#は勝手にdeleteしてくれる(ガベージコレクション)
//ただ、いつされるのかが分からない



//Drawも無いよ、Unityが全部やってくれる
//ファイル名クラス名を一致させてね
//MonoBehaviourは継承
public class GameManagerScript : MonoBehaviour
{
    //配列の宣言
    int[] map;

    //内容をまとめたい時・・・
    string debugText = "";


    // Start is called before the first frame update
    void Start()
    {



        // アッタチは押さなくていいよ
        //文字を出力する機能
        // Debug.Log("Hello World!");


        //配列の実態の作成と初期化
        map = new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0 };



        for (int i = 0; i < map.Length; i++)
        {
            // Debug.Log(map[i] + ",");
            debugText += map[i].ToString() + ",";
        }

        //結合した文字列を出力
        Debug.Log(debugText);


    }

    // Update is called once per frame
    void Update()
    {



        //右キーを入力した場合
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            //見つからなかった時の為に-1で初期化
            int playerIndex = -1;

            //int playerIndex = GetPlayerIndex();

            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] == 1)
                {
                    playerIndex = i;



                    break;
                }


            }

            if (playerIndex < map.Length - 1)
            {
                map[playerIndex + 1] = 1;
                map[playerIndex] = 0;
            }
            if (playerIndex >= map.Length - 1)
            {
                map[playerIndex] = 1;
            }

            //MoveNuber(1, playerIndex, playerIndex + 1);
            PrintfArray();

        }

        //左キーを入力した場合
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            //見つからなかった時の為に-1で初期化
            int playerIndex = -1;

            //int playerIndex = GetPlayerIndex();

            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] == 1)
                {
                    playerIndex = i;



                    break;
                }


            }

            if (playerIndex < map.Length - 1)
            {
                map[playerIndex - 1] = 1;
                map[playerIndex] = 0;

            }


            //MoveNuber(1, playerIndex, playerIndex + 1);
            PrintfArray();

        }


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //上キーを入力した場合
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //スペースキーを入力した場合
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //エンターキーを入力した場合
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            //テンキーのエンターキーを入力した場合
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            //数字キーを入力した場合
        }
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            //テンキーの数字キーを入力した場合
        }



        if (Input.GetKey(KeyCode.Space))
        {
            //スペースキーを押している間
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //スペースキーを押した瞬間
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //スペースキーを離した瞬間
        }



    }








    void PrintfArray()
    {
        string debugText = "";
        for (int i = 0; i < map.Length; i++)
        {
            debugText += map[i].ToString() + ",";
        }
        Debug.Log(debugText);
    }


    void Stract()
    {
        map = new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0, };
        PrintfArray();
    }

    int GetPlayerIndex()
    {
        for (int i = 0; i < map.Length; i++)
        {
            if (map[i] == 1)
            {
                return i;
            }
        }
        return -1;
    }

    bool MoveNumber(int number, int moveFrom, int moveTo)
    {
        if (moveTo < 0 || moveTo >= map.Length)
        {
            return false;
        }
        map[moveTo] = number;
        map[moveFrom] = 0;
        return true;


    }

}
