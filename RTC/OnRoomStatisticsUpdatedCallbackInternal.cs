using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000277 RID: 631
	// (Invoke) Token: 0x0600116D RID: 4461
	[Token(Token = "0x2000277")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnRoomStatisticsUpdatedCallbackInternal(ref RoomStatisticsUpdatedInfoInternal data);
}
