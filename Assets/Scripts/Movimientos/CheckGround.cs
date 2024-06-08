using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool isGrounded = false;
    public LayerMask terrain;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (LayerMask.NameToLayer("Terrain") == collision.gameObject.layer)
        {
            isGrounded = true;
            MovPlatform.canDoubleJump = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (LayerMask.NameToLayer("Terrain") == collision.gameObject.layer)
        {
            isGrounded = false;
        }
    }
}