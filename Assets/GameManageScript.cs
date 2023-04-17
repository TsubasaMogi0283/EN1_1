//using�E�E�Einclude�݂����Ȃ��
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using Debug = UnityEngine.Debug;


//�w�b�_�͖�����!!

//C#�͏����delete���Ă����(�K�x�[�W�R���N�V����)
//�����A�������̂���������Ȃ�



//Draw��������AUnity���S������Ă����
//�t�@�C�����N���X������v�����Ă�
//MonoBehaviour�͌p��
public class GameManagerScript : MonoBehaviour
{
    //�z��̐錾
    int[] map;

    //���e���܂Ƃ߂������E�E�E
    string debugText = "";


    // Start is called before the first frame update
    void Start()
    {



        // �A�b�^�`�͉����Ȃ��Ă�����
        //�������o�͂���@�\
        // Debug.Log("Hello World!");


        //�z��̎��Ԃ̍쐬�Ə�����
        map = new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0 };



        for (int i = 0; i < map.Length; i++)
        {
            // Debug.Log(map[i] + ",");
            debugText += map[i].ToString() + ",";
        }

        //����������������o��
        Debug.Log(debugText);


    }

    // Update is called once per frame
    void Update()
    {



        //�E�L�[����͂����ꍇ
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            //������Ȃ��������ׂ̈�-1�ŏ�����
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

        //���L�[����͂����ꍇ
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            //������Ȃ��������ׂ̈�-1�ŏ�����
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
            //��L�[����͂����ꍇ
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //�X�y�[�X�L�[����͂����ꍇ
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //�G���^�[�L�[����͂����ꍇ
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            //�e���L�[�̃G���^�[�L�[����͂����ꍇ
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            //�����L�[����͂����ꍇ
        }
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            //�e���L�[�̐����L�[����͂����ꍇ
        }



        if (Input.GetKey(KeyCode.Space))
        {
            //�X�y�[�X�L�[�������Ă����
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //�X�y�[�X�L�[���������u��
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //�X�y�[�X�L�[�𗣂����u��
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
