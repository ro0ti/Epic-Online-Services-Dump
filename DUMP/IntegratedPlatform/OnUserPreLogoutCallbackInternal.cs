using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004E9 RID: 1257
	// (Invoke) Token: 0x0600202A RID: 8234
	[Token(Token = "0x20004E9")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate IntegratedPlatformPreLogoutAction OnUserPreLogoutCallbackInternal(ref UserPreLogoutCallbackInfoInternal data);
}
