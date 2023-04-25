using UnityEngine;
public class PlayerPlane : MonoBehaviour
{
    public GameObject Player;
    void Update()
    {
        gameObject.transform.position = new Vector3(Player.transform.position.x,190 ,Player.transform.position.y);
    }
}