using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiControllerIngame : MonoBehaviour

{
    public Controls controlSystem;
    public Controls.MoveCubeActions moveCubeActions;
    public GameObject panelPause;
    [SerializeField] List<GameObject> SectionInMenu;
    public int indexOfIntemActive;
    public Image loadingBar;

    // Start is called before the first frame update
    void Start()
    {
        controlSystem = new Controls();
        moveCubeActions = controlSystem.MoveCube;
        moveCubeActions.Enable();
        DontDestroyOnLoad(gameObject);
    }

    public void SetPanelActive(int panel)
    {
        Debug.Log("Se Cambio el item con indice" + panel);
        foreach(var item in SectionInMenu)
        {
            item.SetActive(false);
        }

        SectionInMenu[panel].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (moveCubeActions.PauseGame.triggered)
        {
            Debug.Log("entro al menu");
            panelPause.SetActive(!panelPause.activeSelf);
        }
    }

    public async void LoadNewScene()
    {
        var scene = SceneManager.LoadSceneAsync("newAditiveScene",LoadSceneMode.Additive);
        scene.allowSceneActivation = false;
        Debug.Log("PROGRESS LOADING: " + scene.progress);
        loadingBar.fillAmount = scene.progress;
        do
        {
           
            Debug.Log("PROGRESS LOADING: " + scene.progress);
            loadingBar.fillAmount = scene.progress;
        } while (scene.progress < 0.9f);

        Debug.Log("PROGRESS COMPLETE : " + scene.progress);
        loadingBar.fillAmount = scene.progress;
        scene.allowSceneActivation = true;
    }

    
}
