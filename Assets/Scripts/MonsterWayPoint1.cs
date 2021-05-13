using UnityEngine;

public class MonsterWayPoint : MonoBehaviour
{

    public Vector3 Position => transform.position;



private void OnDrawGizmos()
    {

        // to see where way points are)
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 0.1f);
    }
}