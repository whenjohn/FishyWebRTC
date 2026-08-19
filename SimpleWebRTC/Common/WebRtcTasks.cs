#if !UNITY_WEBGL || UNITY_EDITOR
using Unity.WebRTC;

namespace cakeslice.SimpleWebRTC
{
	public static class WebRtcTasks
	{
		public static void ExecutePendingTasks()
		{
			WebRTC.ExecutePendingTasks(1);
		}
	}
}
#endif
