using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransRandomScene : MonoBehaviour
{
    static int _beforeRand = 0;
    static int _sceneNum = 0;
    public void TransScene()
    {
        int rand = Random.Range(0, 4);
        Debug.Log($"{rand}");
        if (_beforeRand != rand)
        {
            _beforeRand = rand;
            _sceneNum++;
            Debug.Log($"{_sceneNum}, {_beforeRand}");
            SceneManager.LoadScene($"TestScene{rand}");
        }
    }
}
