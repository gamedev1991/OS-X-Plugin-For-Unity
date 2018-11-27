using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;

public class PluginImport : MonoBehaviour {

	//Lets make our calls from the Plugin
	[DllImport ("TestPlugin")]
	private static extern int PrintANumber();
	
	[DllImport ("TestPlugin")]
	private static extern IntPtr PrintHello();
	
	[DllImport ("TestPlugin")]
	private static extern int AddTwoIntegers(int i1,int i2);

	[DllImport ("TestPlugin")]
	private static extern float AddTwoFloats(float f1,float f2);	


	public delegate void Callback(string message);
	[DllImport ("TestPlugin")]
	private static extern void CallUnityMethod(Callback UnityMethodCalledFromXcode);	

	void UnityMethodCalledFromXcode(string message)
	{
		Debug.Log ("Message = " + message);
	}

	void Start () {
		Debug.Log(PrintANumber());
		Debug.Log(Marshal.PtrToStringAuto (PrintHello()));
		Debug.Log(PrintHello());
		Debug.Log(AddTwoIntegers(2,2));
		Debug.Log(AddTwoFloats(2.5F,4F));
		CallUnityMethod (UnityMethodCalledFromXcode);
	}
		
}
