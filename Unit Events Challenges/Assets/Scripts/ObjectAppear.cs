using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAppear : MonoBehaviour
{
   [SerializeField] private GameObject myCube;

   public void ActivateCube()
   {
    myCube.SetActive(true);
   }
}
