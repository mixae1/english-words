using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultsMenuScript : MenuScript
{
    protected new void Start()
    {
        InitMenu(new string[] { "Удалить первый результат",
            "Удалить все результаты" }, MenuHandler);
        base.Start();
    }
    void MenuHandler(int n)
    {
        var content = GameObject.Find("Content").transform;
        var emptyResults = false;
        if (n == 0)
        {
            if (content.childCount > 0)
                Destroy(content.GetChild(0).gameObject);
            if (content.childCount > 0)
                es.SetSelectedGameObject(content.GetChild(0).gameObject);
            else
                emptyResults = true;
            if (content.childCount > 1)
                es.SetSelectedGameObject(content.GetChild(1).gameObject);
            else
                emptyResults = true;
        }
        else if (n == 1)
        {
            for (int i = 0; i < content.childCount; i++)
                Destroy(content.GetChild(i).gameObject);
            emptyResults = true;
        }
        if (emptyResults)
            es.SetSelectedGameObject(GameObject.Find("HLButton"));
    }
}
