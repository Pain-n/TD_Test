using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Controller : MonoBehaviour
{
    public Button NextSceneButton;
    public int NextSceneID;

    private void Start()
    {
        NextSceneButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(NextSceneID, LoadSceneMode.Single);
        });
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.up);


            if(hit.collider != null)
            {
                if (hit.transform.tag == "Character")
                {
                    hit.transform.GetComponent<Animator>().Play("run");
                }

                if (hit.transform.name == "Pointer")
                {
                    NextSceneButton.interactable = true;
                }
            }
        }
    }
}
