using UnityEngine;
using System.Collections;
using System.Windows.Forms;

public class WindowsFrom : MonoBehaviour {

	WindowsFormManager wfm=new WindowsFormManager();

	Form form;
	Button button1;
	TextBox textBox1;

	void Update () {
		if( form !=null){
			wfm.UpdateForm (form);
		}
			
		if(Input.GetKeyDown(KeyCode.Space)){
			CreateDebugForm ();
		}
	}

	void CreateDebugForm(){
		form = wfm.CreateForm ("form","Debug Form");
		button1 = wfm.CreateButton (form,"button1","Debug",50,50,80,30);
		textBox1 = wfm.CreateTextBox (form,"textBox1","",50,80,120,30);

		button1.Click += Button1_Click;

		wfm.ShowForm (form);
	}

	void Button1_Click (object sender, System.EventArgs e)
	{
		Debug.Log(textBox1.Text);
	}
}
