using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSceneChange : MonoBehaviour
{
    public string sceneToLoad;
    public string spawnPoint;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            GameManager.Instance.levelManager.LoadSceneWithSpawnPoint(sceneToLoad, spawnPoint);
        }
    }
}
