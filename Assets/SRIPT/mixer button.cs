using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mixerbutton : MonoBehaviour



{

    AudioHighPassFilter _filtrehaut;
    AudioLowPassFilter _filtrebas;
    AudioChorusFilter _choruseffet;
    AudioDistortionFilter _disto;
    AudioEchoFilter _delai;

    void Start()
    {
        _filtrehaut = gameObject.GetComponent<AudioHighPassFilter>();
        _filtrebas = gameObject.GetComponent<AudioLowPassFilter>();
        _choruseffet = gameObject.GetComponent<AudioChorusFilter>();
        _delai = gameObject.GetComponent<AudioEchoFilter>();
        _disto = gameObject.GetComponent<AudioDistortionFilter>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
    

    { _filtrehaut.enabled = !_filtrehaut.enabled;
    }
    

        if(Input.GetKeyDown(KeyCode.Mouse1))
    

    { _filtrebas.enabled = !_filtrebas.enabled;
    }

    if(Input.GetKeyDown(KeyCode.Alpha2))
    

    { _disto.enabled = !_disto.enabled;
    }

    if(Input.GetKeyDown(KeyCode.Alpha3))
    

    { _choruseffet.enabled = !_choruseffet.enabled;
    }

    if(Input.GetKeyDown(KeyCode.Alpha4))
    

    { _delai.enabled = !_delai.enabled;
    }






    }
}
