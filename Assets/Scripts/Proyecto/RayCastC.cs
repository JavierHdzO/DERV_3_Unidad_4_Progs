using UnityEngine;
using UnityEngine.UI;

public class RayCastC : MonoBehaviour
{
    public static string nombreSeleccionado = "";

    private string selectableTag = "Seleectable";
    [SerializeField]
    Camera cam;
    [SerializeField]
    Image image;

    private void Update()
    {

        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit,60))
        {
            var selection = hit.transform;
            if (selection.tag.Equals(selectableTag))
            {
                image.color = Color.red;
                if (Input.GetMouseButton(0))
                {
                    nombreSeleccionado = selection.name;
                    Debug.Log(selection.name);
                }
            }
            else 
            {
                Debug.Log(selection.tag);
                image.color = Color.green;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(cam.transform.position, cam.transform.forward * 60);

    }


}
