using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartUpManager : MonoBehaviour
{

	// Use this for initialization
	private IEnumerator Start ()
	{
		while (!LocalizationManager.instance.GetIsReady ()) {
			yield return null;//mean wait one frame
		}

		SceneManager.LoadScene ("MenuScreen");
	}
}
