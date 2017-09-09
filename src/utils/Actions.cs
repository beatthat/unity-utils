using UnityEngine;
using System.Collections;
using System.Text;

namespace BeatThat
{
	public static class Actions 
	{
		public static void Exec<T>(T arg, System.Action<T> a)
		{
			if(a != null) {
				a(arg);
			}
		}

		/// <summary>
		/// Minor-optimization functions to avoid allocating arrays in something like Send(params Action[] acts)
		/// </summary>
		public static void Exec(System.Action a)
		{
			if(a != null) {
				a();
			}
		}

		public static void Exec(System.Action a1, System.Action a2)
		{
			if(a1 != null) {
				a1();
			}
			if(a2 != null) {
				a2();
			}
		}

		public static void Exec(System.Action a1, System.Action a2, System.Action a3)
		{
			if(a1 != null) {
				a1();
			}
			if(a2 != null) {
				a2();
			}
			if(a3 != null) {
				a3();
			}
		}
	}
}