
using UnityEngine;

public class rotation : MonoBehaviour
{
      public float speed =2f;
      void Start (){
}
    void Update()
    {
       transform.Rotate(0 ,speed , 0);
    }
}