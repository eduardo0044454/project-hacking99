using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    private int menuCounter;
    private int selectControllerCounter;
    private int backCounter;
    private int enterCounter;
    public GameObject[] selectBox;
    public GameObject[] canvasScreen;

    // Use this for initialization
    void Start ()
    {
        menuCounter = 1;
        selectControllerCounter = 1;
        enterCounter = 0;
        backCounter = 1;
        selectBox[0].SetActive(false);
        selectBox[1].SetActive(false);
        selectBox[2].SetActive(false);
        selectBox[3].SetActive(false);
        selectBox[4].SetActive(false);

        canvasScreen[0].SetActive(true);
        canvasScreen[1].SetActive(false);
        canvasScreen[1].SetActive(false);

        Debug.Log("TETAAAAAAAAAAAAAAAAA");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (canvasScreen[0].active)
        {
            //TELA DE MENU PRINCIPAL
            if ((Input.GetKeyDown(KeyCode.DownArrow)) || (Input.GetKeyDown(KeyCode.S)))
            {
                menuCounter++;
            }

            if ((Input.GetKeyDown(KeyCode.UpArrow)) || (Input.GetKeyDown(KeyCode.W)))
            {
                menuCounter--;
            }

            if (menuCounter == 1)
            {
                selectBox[0].SetActive(true);
                selectBox[1].SetActive(false);
            }

            if (menuCounter == 2)
            {
                selectBox[0].SetActive(false);
                selectBox[1].SetActive(true);
            }

            if (menuCounter <= 0)
            {
                menuCounter = 1;
            }

            if (menuCounter >= 2)
            {
                menuCounter = 2;
            }
            //TELA DE MENU PRINCIPAL

            //SELEÇÃO DE OPÇÃO
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (menuCounter == 1)
                {
                    canvasScreen[2].SetActive(true);
                    canvasScreen[0].SetActive(false);
                    canvasScreen[1].SetActive(false);

                    selectBox[0].SetActive(false);
                    selectBox[1].SetActive(false);
                }

                if (menuCounter == 2)
                {
                    canvasScreen[1].SetActive(true);
                    canvasScreen[0].SetActive(false);
                    canvasScreen[2].SetActive(false);

                    selectBox[0].SetActive(false);
                    selectBox[1].SetActive(false);
                }
            }
            //SELEÇÃO DE OPÇÃO
        }

        if (canvasScreen[1].active)
        {
            selectBox[4].SetActive(true);
            if (Input.GetKeyDown(KeyCode.Return))
            {
                enterCounter++;
            }

            if (enterCounter == 2)
            {
                canvasScreen[0].SetActive(true);
                canvasScreen[1].SetActive(false);
                Start();
            }
        }

        if (canvasScreen[2].active)
        {
            if ((Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.LeftArrow)))
            {
                selectControllerCounter--;
            }

            if ((Input.GetKeyDown(KeyCode.D)) || (Input.GetKeyDown(KeyCode.RightArrow)))
            {
                selectControllerCounter++;
            }

            if (selectControllerCounter == 1)
            {
                selectBox[2].SetActive(true);
                selectBox[3].SetActive(false);
            }

            if (selectControllerCounter == 2)
            {
                selectBox[3].SetActive(true);
                selectBox[2].SetActive(false);
            }

            if (selectControllerCounter <= 1)
            {
                selectControllerCounter = 1;
            }

            if (selectControllerCounter >= 2)
            {
                selectControllerCounter = 2;
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                enterCounter++;
            }

            if ((selectControllerCounter == 1) && (enterCounter == 2) && backCounter == 1)
            {
                Application.LoadLevel(1);
                //SceneManager.LoadLevel(1);
                Debug.Log("teta");
            }

            if ((selectControllerCounter == 2) && (enterCounter == 2) && backCounter == 1)
            {
                Application.LoadLevel(1);
                //SceneManager.LoadLevel(1);
                Debug.Log("TETA");
            }

            if ((Input.GetKeyDown(KeyCode.S)) || (Input.GetKeyDown(KeyCode.DownArrow)))
            {
                backCounter++;
            }

            if ((Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.UpArrow))))
            {
                backCounter--;
            }

            if (backCounter <= 1)
            {
                backCounter = 1;
            }

            if (backCounter >= 2)
            {
                backCounter = 2;
                selectBox[4].SetActive(true);
                selectBox[2].SetActive(false);
                selectBox[3].SetActive(false);
            }

            if (backCounter == 1)
            {
                selectBox[4].SetActive(false);
            }

            if ((Input.GetKeyDown(KeyCode.Return)) && (backCounter == 2))
            {
                canvasScreen[0].SetActive(true);
                canvasScreen[1].SetActive(false);
                Start();
            }
        }
	}
}