using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevelCondicion : MonoBehaviour
{
    public int level;
    public CherryCollector cherryCollector; // Referencia al script CherryCollector

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && cherryCollector.CollectedCherries >= cherryCollector.TargetCherries)
        {
            SceneManager.LoadScene(level);
        }
    }
}
