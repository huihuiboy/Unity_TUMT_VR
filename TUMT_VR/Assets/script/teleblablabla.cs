using UnityEngine;

public class teleblablabla : MonoBehaviour {

    [Header("動畫控制器")]
    public Animator Con;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "HeadCollider" &&  GameManager.havKey)
        {
            Con.SetBool("character_nearby", true);
            
        }
    }
}
