using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class steps : MonoBehaviour
{
    public Text m_MyText;
    public RawImage imageScrewdriver, imageSpeedController, imageSolderingIron, imageSoldering, imageEnergy, imageFlightController, imageWire, imagePropeller, imagePlate;
    public GameObject ScrewLight, MotorsLight, energyLight, flightControllerLight, wireLight,propellersLight, plateLight , ScrewLight2;
    GameObject[] prop;

    public GameObject dron;
    
    
    // Start is called before the first frame update
    private void Start()
    {
        m_MyText.text = "Добро пожаловать! Вам предоставляется возможность провести сборку квадрокоптера. Места присоединения деталей будут подсвечены голубым \n \n Присоедините 'руки' дрона к центральной части в указанных местах";
        //image.texture = "";
    }

    public void printText(int code)
    {
        
        switch (code)
        {
            case 1:
                ScrewLight.SetActive(true);
                m_MyText.text = "Поместите винты в подсвеченные места";
                break;

            case 2:
                m_MyText.text = "Возьмите отвертку и закрутите винты";
                imageScrewdriver.GetComponent<RawImage>().enabled = true;
                break;

            case 3:
                m_MyText.text = "Установите регулятор поворотов";
                imageScrewdriver.GetComponent<RawImage>().enabled = false;
                imageSpeedController.GetComponent<RawImage>().enabled = true;
                break;

            case 4:

                MotorsLight.SetActive(true);
                m_MyText.text = "Установите моторы на места и прикрутите с помощью отвертки";
                imageScrewdriver.GetComponent<RawImage>().enabled = true;
                imageSpeedController.GetComponent<RawImage>().enabled = false;
                break;

            case 5:
                m_MyText.text = "Необходимо припаять провода моторов к площадкам на регуляторе оборотов";
                imageScrewdriver.GetComponent<RawImage>().enabled = false;
                imageSolderingIron.GetComponent<RawImage>().enabled = true;
                imageSoldering.GetComponent<RawImage>().enabled = true;
                break;

            case 6:
                energyLight.SetActive(true);
                m_MyText.text = "Возьмите провод питания и припаяйте провода к площадкам на регуляторе оборотов";
                imageSolderingIron.GetComponent<RawImage>().enabled = false;
                imageSoldering.GetComponent<RawImage>().enabled = false;
                imageEnergy.GetComponent<RawImage>().enabled = true;
                break;

            case 7:
                //Destroy(energyLight);
                flightControllerLight.SetActive(true);
                m_MyText.text = "Установите контроллер полета";
                imageEnergy.GetComponent<RawImage>().enabled = false;
                //Debug.Log(imageEnergy.GetComponent<RawImage>().enabled);
                imageFlightController.GetComponent<RawImage>().enabled = true;
                break;

            case 8:
                wireLight.SetActive(true);
                imageFlightController.GetComponent<RawImage>().enabled = false;
                m_MyText.text = "Подключите полетный контроллер к регулятору оборотов с помощью коннектора с проводами";
                imageWire.GetComponent<RawImage>().enabled = true;
                break;

            case 9:
                propellersLight.SetActive(true);
                imageWire.GetComponent<RawImage>().enabled = false;
                m_MyText.text = "Вставьте пропеллеры";
                imagePropeller.GetComponent<RawImage>().enabled = true;
                break;

            case 10:
                plateLight.SetActive(true);
                imagePropeller.GetComponent<RawImage>().enabled = false;
                m_MyText.text = "Поставьте и закрепите верхнюю крышку уже известными вам методами";
                imagePlate.GetComponent<RawImage>().enabled = true;
                break;

            case 11:
                ScrewLight2.SetActive(true);
                break;

            case 12:
                imagePlate.GetComponent<RawImage>().enabled = false;
                m_MyText.text = "Поздравляю, Вы справились!";
                prop = GameObject.FindGameObjectsWithTag("Prop");
                for (int i=0; i<prop.Length; i++)
                {
                    prop[i].GetComponent<rotate>().enabled = true;
                }
                dron.SetActive(true);
                break;
                
        }

    }
}
