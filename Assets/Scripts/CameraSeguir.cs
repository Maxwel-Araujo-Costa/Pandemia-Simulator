using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeguir : MonoBehaviour
{
    public Transform player;
    private void FixedUpdate(){
        Vector2 novaCamera = new Vector2(player.position.x + 2, player.position.y + 2);
        transform.position = Vector2.Lerp(transform.position, novaCamera, 0.1f);
    }
}
