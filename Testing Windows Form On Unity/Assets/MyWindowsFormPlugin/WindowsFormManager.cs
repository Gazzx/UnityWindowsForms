using UnityEngine;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

public class WindowsFormManager {

	/// <summary>
	/// Creates a new form.
	/// </summary>
	/// <returns>The form that we created.</returns>
	/// <param name="name">the form name .</param>
	/// <param name="text">the form text.</param>
	public Form CreateForm(string name="form",string text="form"){
		Form form=new Form();
		form.Name=name;
		form.Text = text;

		return form;
	}

	/// <summary>
	/// Shows the passed form.
	/// </summary>
	/// <param name="form">The form that you want to show.</param>
	public void ShowForm(Form form){
		form.ShowDialog ();
	}

	public void UpdateForm(Form form){
		form.Update ();
	}

	/// <summary>
	/// Creates a button.
	/// </summary>
	/// <returns>The button that we create.</returns>
	/// <param name="form">the Form that we want to add the button into.</param>
	/// <param name="name">the name of the button.</param>
	/// <param name="text">the text of the button.</param>
	/// <param name="posX">the X position of the button</param>
	/// <param name="posY">the Y position of the button.</param>
	/// <param name="width">the width of the button.</param>
	/// <param name="height">the height of the button.</param>
	public Button CreateButton(Form form,string name="button",string text="button",int posX=50,int posY=50,int width =80,int height=30){
		Button button=new Button();
		button.Name = name;
		button.Text = text;
		button.Location = new Point(posX,posY);
		button.Width = width;
		button.Height = height;
		form.Controls.Add (button);
		return button;
	}		

	/// <summary>
	/// Creates a textBox.
	/// </summary>
	/// <returns>The textBox that we create.</returns>
	/// <param name="form">the Form that we want to add the textBox into.</param>
	/// <param name="name">the name of the textBox.</param>
	/// <param name="text">the text of the textBox.</param>
	/// <param name="posX">the X position of the textBox</param>
	/// <param name="posY">the Y position of the textBox.</param>
	/// <param name="width">the width of the textBox.</param>
	/// <param name="height">the height of the textBox.</param>
	public TextBox CreateTextBox(Form form,string name="textBox",string text="",int posX=50,int posY=50,int width =120,int height=30){
		TextBox textBox =new TextBox();
		textBox.Name = name;
		textBox.Text = text;
		textBox.Location = new Point(posX,posY);
		textBox.Width = width;
		textBox.Height = height;
		form.Controls.Add (textBox);
		return textBox;
	}

	//I added this Method to test GitHub Pushing & pulling
	void GitHub(){

	}
}
