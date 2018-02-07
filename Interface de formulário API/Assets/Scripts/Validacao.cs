using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Validacao : MonoBehaviour {

	[SerializeField]
	private InputField campoFisioterapeuta;
	[SerializeField]
	private InputField campoPaciente;
	[SerializeField]
	private Text aviso = null;
	[SerializeField]
	private Button avancar;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void validar () {
		string fisioterapeuta = campoFisioterapeuta.text;
		string paciente = campoPaciente.text;

		if (fisioterapeuta == "" || paciente == "") {
			aviso.CrossFadeAlpha (100f, 1f, false);
			aviso.color = Color.red;
			aviso.text = "Os campos acima são obrigatórios.";
			aviso.CrossFadeAlpha (0f, 2f, false);
		} else {
			Application.LoadLevel ("Parametros");
		}
	}

	public void configuracao(){
		Application.LoadLevel ("Configuracoes");
	}

	public void voltar(){
		Application.LoadLevel ("Paciente");
	}
}
