using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReSizeButton : MonoBehaviour
{
    public TMP_Text text;
    public RectTransform transformUi;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return null;
        Vector2 size = text.textBounds.size;
        transformUi.sizeDelta = size + new Vector2(10, 10);
    }

    // Update is called once per frame
    void Update()
    {


    }

}
