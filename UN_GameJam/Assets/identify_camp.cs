﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class identify_camp : MonoBehaviour {
    bool is_marked = false;
    [SerializeField] GameObject marker;
    void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 origin = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
                                         Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.zero, 0f);
            if (hit)
            {
             if (hit.transform.CompareTag("camp"))
                {
                    Debug.Log(hit.transform.gameObject.tag);
                    Instantiate(marker, hit.point, Quaternion.identity);
                }
                
                
            }
        }
    }
}
