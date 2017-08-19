using System;
using System.Collections.Generic;


namespace BeatThat
{
	public enum PropertyEventOptions 
	{
		SendOnChange = 0,
		Disable = 1,
		Force = 2
	}

	public static class PropertyEventOptionsExt
	{
		public static void Set<T>(this PropertyEventOptions opt, ref T prop, T val, Action changeEvent)
		{
			if(EqualityComparer<T>.Default.Equals(prop, val) && opt != PropertyEventOptions.Force) {
				return;
			}

			prop = val;

			if(opt != PropertyEventOptions.Disable) {
				changeEvent();
			}
		}
	}
}
