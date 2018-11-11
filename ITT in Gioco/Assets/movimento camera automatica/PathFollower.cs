using UnityEngine;
using System.Collections;
using System;

public class PathFollower : MonoBehaviour {

	public float speed = 3f;
	public Transform pathParent;
	Transform targetPoint;
	int index,i=0;
    //public GameObject cam1, cam2;

	void OnDrawGizmos()
	{
		Vector3 from;
		Vector3 to;
		for (int a=0; a<pathParent.childCount; a++)
		{
			from = pathParent.GetChild(a).position;
			to = pathParent.GetChild((a+1) % pathParent.childCount).position;
			Gizmos.color = new Color (1, 0, 0);
			Gizmos.DrawLine (from, to);
		}
	}
	void Start () {
		index = 0;
		targetPoint = pathParent.GetChild (index);
	}

    void Update () {
        //StartCoroutine(Posizione());
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f && index < 1)
        {
            index++;
            index %= pathParent.childCount;
            targetPoint = pathParent.GetChild(index);
            Debug.Log(index);
            /*for (int a=0;a < 1 ;a++ )
            {
                i++;
                if (i == 2)
                {
                    yield return new WaitForSeconds(2);
                    break;
                }
            }*/
            /*if (index == 10)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
            }*/
        }
    }
}