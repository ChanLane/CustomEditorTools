using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;


namespace ChandlerLane.CustomEditor
{
    public class SimpleAttribute : MonoBehaviour
    {
        [FilePath(Extensions = ".unity")]
        public string scenePath;

        [Button(ButtonSizes.Large)]
        public void SayHello()
        {
            Debug.Log("Hello Button!");
        }
    }    
}

