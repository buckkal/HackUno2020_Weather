using UnityEngine;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;


public class main : MonoBehaviour/*extends WeatherData*/
{

    public Text fahrenheitText, celciusText, atmosphereText, recommendedText;
    string fahrenheit = "", celcius = "", atmosphere = "", recommended = "";


    void start()
    {
        WeatherData data = new WeatherData();
        update(data);
    }
    void update(WeatherData data)
    {
        fahrenheit = data.getFahrenheit();
        celcius = data.getCelcius();
        atmosphere = data.getAtmosphere();
        recommended = data.getRecommended();

        fahrenheitText.text = fahrenheit;
        celciusText.text = celcius;
        atmosphereText.text = atmosphere;
        recommendedText.text = recommended;
    }

}

