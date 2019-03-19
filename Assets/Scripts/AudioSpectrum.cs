using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//codigo para analizar las canciones y sacar su espectro 
public class AudioSpectrum : MonoBehaviour {

	private void Update()
    {
        // adquiere los datos
        AudioListener.GetSpectrumData(m_audioSpectrum, 0, FFTWindow.Hamming);

        // Asigna un valor de espectro
      
        if (m_audioSpectrum != null && m_audioSpectrum.Length > 0)
        {
            spectrumValue = m_audioSpectrum[0] * 100;
        }
    }

    private void Start()
    {
        /// inicializa el bufer
        m_audioSpectrum = new float[128];
    }

    // la extracion del beat
    public static float spectrumValue {get; private set;}

    
    private float[] m_audioSpectrum;

}
