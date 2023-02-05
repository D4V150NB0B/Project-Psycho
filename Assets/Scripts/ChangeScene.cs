using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene: MonoBehaviour
{
    public GameObject canvaSiguiente;
    public void MoveToScene(int sceneID)
    {
        Instantiate(canvaSiguiente, new Vector3(0, 0, 0), Quaternion.identity);
        Destroy(transform.gameObject.GetComponentInParent<Canvas>().gameObject);
    }
 }

