using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectSetActive : MonoBehaviour
{
    [SerializeField]
    List<GameObject> _player = new List<GameObject>();

    [SerializeField]
    List<GameObject> _camera = new List<GameObject>();
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _player[0].SetActive(false);
            _player[1].SetActive(true);
            _camera[0].SetActive(false);
            _camera[1].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            _player[1].SetActive(false);
            _player[0].SetActive(true);
            _camera[1].SetActive(false);
            _camera[0].SetActive(true);
        }
    }
}
