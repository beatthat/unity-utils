using UnityEngine;

namespace BeatThat
{

	/// <summary>
	/// Adding comments to GameObjects in the Inspector.
	/// </summary>
	public class Comment : MonoBehaviour 
	{
		[Multiline(10)]
		public string text;
	}
}
