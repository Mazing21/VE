using UnityEngine;
public class UICOntrollerInGame : MonoBehaviour
{
    public GameObject ESKMenu,miniMap;
    public static bool ESKMenuIsOpen = false;
    private void Start()
    {
        ESKMenu.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ESKMenuIsOpen == false)
            {
                ESKMenu.SetActive(true);
                miniMap.SetActive(false);
                Cursor.lockState = CursorLockMode.Confined;
                ESKMenuIsOpen = true;
            }
            else
            {
                ESKMenu.SetActive(false);
                miniMap.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                ESKMenuIsOpen = false;
            }
        }
    }
}
