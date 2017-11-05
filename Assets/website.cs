using UnityEngine;
using System.Collections;

public class website : MonoBehaviour {

	public string pageToOpen = "stolpersteine.jimbo.com";

	// check readme file to find out how to change title, colors etc.
	public void Onactivated() {
		InAppBrowser.DisplayOptions options = new InAppBrowser.DisplayOptions();
		options.displayURLAsPageTitle = false;
		options.pageTitle = "InAppBrowser example";

		InAppBrowser.OpenURL(pageToOpen, options);
	}

	public void OnClearCacheClicked() {
		InAppBrowser.ClearCache();
	}
}