using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//clase que se encarga de sacar los beats
public class AudioSyncer : MonoBehaviour {

	//Creas el onBeat que luego va a ser sobreesctiro en las funciones que beban de este script
	public virtual void OnBeat()
	{
		//Debug.Log("beat");
		m_timer = 0;
		m_isBeat = true;
	}

	
	public virtual void OnUpdate()
	{ 
		// update audio value
		m_previousAudioValue = m_audioValue;
		m_audioValue = AudioSpectrum.spectrumValue;

		// if audio value went below the bias during this frame
		if (m_previousAudioValue > bias &&
			m_audioValue <= bias)
		{
			// if minimum beat interval is reached
			if (m_timer > timeStep)
				OnBeat();
		}

		// if audio value went above the bias during this frame
		if (m_previousAudioValue <= bias &&
			m_audioValue > bias)
		{
			// if minimum beat interval is reached
			if (m_timer > timeStep)
				OnBeat();
		}

		m_timer += Time.deltaTime;
	}

	private void Update()
	{
		OnUpdate();
	}
    //Los valores que se cambiaran para que vaya a diferentes ritmos 
	public float bias;
	public float timeStep;
	public float timeToBeat;
	public float restSmoothTime;

	private float m_previousAudioValue;
	private float m_audioValue;
	private float m_timer;

	protected bool m_isBeat;
}
