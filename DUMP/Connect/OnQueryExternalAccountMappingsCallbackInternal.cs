using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x0200062A RID: 1578
	// (Invoke) Token: 0x06002861 RID: 10337
	[Token(Token = "0x200062A")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryExternalAccountMappingsCallbackInternal(ref QueryExternalAccountMappingsCallbackInfoInternal data);
}
