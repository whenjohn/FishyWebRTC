#if !UNITY_WEBGL || UNITY_EDITOR
using Unity.WebRTC;

namespace cakeslice.SimpleWebRTC
{
	internal static class WebRtcTasks
	{
		internal static void ExecutePendingTasks()
		{
			WebRTC.ExecutePendingTasks(1);
		}
	}
}
#endif
