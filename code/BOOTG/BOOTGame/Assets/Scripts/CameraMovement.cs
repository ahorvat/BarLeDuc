using UnityEngine;
using System.Collections;
/**
 * A camera to help with Orthagonal mode when you need it to lock to pixels.  Desiged to be used on android and retina devices.
 */
public class CameraMovement : MonoBehaviour {
	/**
	 * The target size of the view port.
	 */
	public Vector2 targetViewportSizeInPixels = new Vector2(1024.0f, 768.0f);
	/**
	 * Snap movement of the camera to pixels.
	 */
	public bool lockToPixels = true;
	/**
	 * The number of target pixels in every Unity unit.
	 */
	public float pixelsPerUnit = 32.0f;
	/**
	 * A game object that the camera will follow the x and y position of.
	 */
	public GameObject followTarget;

	private Camera _camera;
	private int _currentScreenWidth = 0;
	private int _currentScreenHeight = 0;

	private float _pixelLockedPPU = 32.0f;
	private Vector2 _winSize;

	private SpriteRenderer spriteBounds;

	protected void Start(){
		// persist camera
		DontDestroyOnLoad(gameObject);

		_camera = this.GetComponent<Camera>();
		if(!_camera){
			Debug.LogWarning("No camera for pixel perfect cam to use");
		}else{
			_camera.orthographic = true;
			ResizeCamToTargetSize();
		}
			
		// Get background bounds
		spriteBounds = GameObject.FindGameObjectWithTag("Background").GetComponentInChildren<SpriteRenderer>();
	}

	public void ResizeCamToTargetSize(){
		if(_currentScreenWidth != Screen.width || _currentScreenHeight != Screen.height){
			// check our target size here to see how much we want to scale this camera
			float percentageX = Screen.width/targetViewportSizeInPixels.x;
			float percentageY = Screen.height/targetViewportSizeInPixels.y;
			float targetSize = 0.0f;
			if(percentageX > percentageY){
				targetSize = percentageY;
			}else{
				targetSize = percentageX;
			}
			int floored = Mathf.FloorToInt(targetSize);
			if(floored < 1){
				floored = 1;
			}
			// now we have our percentage let's make the viewport scale to that
			float camSize = ((Screen.height/2)/floored)/pixelsPerUnit;
			_camera.orthographicSize = camSize;
			_pixelLockedPPU = floored * pixelsPerUnit;
		}
		_winSize = new Vector2(Screen.width, Screen.height);
	}

	public void Update(){
		if(_winSize.x != Screen.width || _winSize.y != Screen.height){
			ResizeCamToTargetSize();
		}
		if(_camera && followTarget){
			Vector2 newPosition = new Vector2(followTarget.transform.position.x, followTarget.transform.position.y);

			this.checkBounds(ref newPosition);

			float nextX = Mathf.Round(_pixelLockedPPU * newPosition.x);
			float nextY = Mathf.Round(_pixelLockedPPU * newPosition.y);


			_camera.transform.position = new Vector3(nextX/_pixelLockedPPU, nextY/_pixelLockedPPU, _camera.transform.position.z);
		}
	}

	public void checkBounds(ref Vector2 pos){

		float viewportDiameter = targetViewportSizeInPixels.x / 2.0f;

		float leftBound = spriteBounds.bounds.min.x + viewportDiameter;
		float rightBound = spriteBounds.bounds.max.x - viewportDiameter;

//		var pos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, _camera.transform.position.z);
		pos.x = Mathf.Clamp (pos.x, leftBound, rightBound);
//		_camera.transform.position = pos;
	}
}