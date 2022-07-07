using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        float playerX = player.transform.position.x;
        transform.position  = new Vector3(playerX,5f ,-1f);
    }
}
