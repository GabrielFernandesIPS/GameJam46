using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Inciar Variaveis
    [SerializeField] private float followSpeed;
    [SerializeField] private Transform player;
    [SerializeField] private float yOffset;
    private float xOffset;
    public float xOffsetFOV;
    
    private void FixedUpdate()
    {
        FlipOffset();
        Vector3 newPos = new Vector3(player.position.x + xOffset, player.position.y + yOffset, -10f);
        //-10f é o default da camera para ver a cena
        transform.position = Vector3.Slerp(transform.position, newPos, followSpeed * Time.deltaTime);
    }
    void FlipOffset()
    {
        if(player.rotation.eulerAngles.y == 0)
        {
            xOffset = xOffsetFOV;

        }else if(player.rotation.eulerAngles.y == 180)
        {
            xOffset = -xOffsetFOV;
        }
    }
}
