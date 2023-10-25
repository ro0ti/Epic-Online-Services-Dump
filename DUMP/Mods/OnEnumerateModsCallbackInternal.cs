using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Mods
{
	// Token: 0x02000372 RID: 882
	// (Invoke) Token: 0x060017B2 RID: 6066
	[Token(Token = "0x2000372")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnEnumerateModsCallbackInternal(ref EnumerateModsCallbackInfoInternal data);
}
