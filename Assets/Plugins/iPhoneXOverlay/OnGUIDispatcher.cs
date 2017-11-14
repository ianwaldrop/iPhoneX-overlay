using UnityEngine;

[ExecuteInEditMode]
public class OnGUIDispatcher : MonoBehaviour
{
	public delegate void OnGUIDelegate();
	public event OnGUIDelegate OnGUIEvent;

	void OnGUI()
	{
		if (OnGUIEvent != null)
		{
			OnGUIEvent();
		}
	}
}