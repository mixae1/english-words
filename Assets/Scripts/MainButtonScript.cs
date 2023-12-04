using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtonScript : MonoBehaviour
{
    public DataScript data;
    public void OnClickHandler()
    {
        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 1:
                data.CurrentTopicIndex = transform.GetSiblingIndex();
                SceneManager.LoadScene(6);
                return;
            case 6:
                data.PlayAudio(transform.GetSiblingIndex());
                return;
        }
    }
}