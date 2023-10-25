using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000766 RID: 1894
	// (Invoke) Token: 0x060030A7 RID: 12455
	[Token(Token = "0x2000766")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryDefinitionsCompleteCallbackInternal(ref OnQueryDefinitionsCompleteCallbackInfoInternal data);
}
