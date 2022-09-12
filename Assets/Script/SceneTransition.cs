using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SelectCharacter
{
    public class SceneTransition : MonoBehaviour
    {
        private MyGameManagerData myGameManagerData;

        private void Start()
        {
            myGameManagerData = FindObjectOfType<MyGameManager>().GetMyGameManagerData();
        }

        public void GoToOtherScene(string stage)
        {
            //�@���̃V�[���f�[�^��MyGameManager�ɕۑ�
            myGameManagerData.SetNextSceneName(stage);
            //�@�L�����N�^�[�I���V�[����
            SceneManager.LoadScene("SelectCharacter");
        }
        public void GameStart()
        {
            SceneManager.LoadScene(myGameManagerData.GetNextSceneName());
        }
    }
}
