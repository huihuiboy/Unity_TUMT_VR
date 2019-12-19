using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static bool havKey;

    //公開且參數只能零或一個
    public void Throwing(GameObject obj)
    {
        print("Throw");
        havKey = true;
        Destroy(obj);
    }
    public void Taking()
    {
        print("Taking");

    }
    public void Take()
    {
        print("Take");
    }


}
