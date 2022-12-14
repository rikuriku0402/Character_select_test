using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SelectCharacter
{
    public class GameStart : MonoBehaviour
    {
        private MyGameManagerData myGameManagerData;

        // Start is called before the first frame update
        void Start()
        {
            myGameManagerData = FindObjectOfType<MyGameManager>().GetMyGameManagerData();
            Instantiate(myGameManagerData.GetCharacter(), Vector3.zero, Quaternion.identity);
            //Instantiate(myGameManagerData.GetCamera(),Vector3.zero,Quaternion.identity);
        }
    }
}