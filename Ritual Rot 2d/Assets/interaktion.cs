using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;


public class interaktion : MonoBehaviour
{
    public bool skrift = false;
    void OnTriggerEnter(Collider other)
        {
            skrift = true;
        }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
