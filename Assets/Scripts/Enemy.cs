using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnPrticleCollision(GameObject other)
    {
        Destroy(this.gameObject);       
    }
}
