using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoint : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject CheckpointIndicator;
    void  OnTriggerEnter ( Collider col  ){
        if(col.tag =="Player"){
            SpawnPoint.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            CheckpointIndicator.SetActive(true);
        }
    }
}