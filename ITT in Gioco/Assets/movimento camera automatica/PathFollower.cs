using UnityEngine;
using System.Collections;
using System;

public class PathFollower : MonoBehaviour {

	public float speed = 3f;
	public Transform pathParent;
	Transform targetPoint;
    int index,index2;
    public GameObject cam1, cam2;

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
        index2 = 0;
        targetPoint = pathParent.GetChild (index);
        targetPoint = pathParent.GetChild (index2);
    }

    void Update () {
        //StartCoroutine(Posizione());
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f && index < 2)
        {
            index++;
            index %= pathParent.childCount;
            targetPoint = pathParent.GetChild(index);
            Debug.Log(index);
            if (index==1)
            {
                cam1.SetActive(false);
                Debug.Log("Disattivata prima camera");
                cam2.SetActive(true);
                Debug.Log("Attivata seconda camera");
                Posizione();
                //Debug.Log("Vado a Posizione");
            }

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
    void Posizione()
    {
        Debug.Log("Partito void Posizione");
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);
        //if (index==2 && Vector3.Distance(transform.position, targetPoint.position) < 0.1f)
        //{
            index2++;
            Debug.Log("Incrementata index2");
            index2 %= pathParent.childCount;
            targetPoint = pathParent.GetChild(index2);
            Debug.Log(index2);
            if (index2==2)
            {
                Debug.Log("Entrato in if index2==1");
                cam2.SetActive(false);
                Debug.Log("Disattivo seconda camera");
                //Debug.Log("Fermo tutto");
                //break;
            }
            
            //}
            //Debug.Log("Fermo void Posizione ragione condizione for");
    }//end posizione

    /*private IEnumerator Posizione()
        {
            throw new NotImplementedException();
        }*/
}
