using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingLog : IntreactiveObject
{
    public override void Interact(GameObject _player)
    {
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        Collider[] col = GetComponents<Collider>();
        foreach(Collider c in col)
        {
            c.enabled = false;
        }
        StartCoroutine(Destroy());
    }
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
