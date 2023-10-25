using System;
using System.Runtime.InteropServices;


namespace Epic.OnlineServices.ProgressionSnapshot
{
	// Token: 0x0200029B RID: 667
	// (Invoke) Token: 0x0600125B RID: 4699
	[Token(Token = "0x200029B")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnSubmitSnapshotCallbackInternal(ref SubmitSnapshotCallbackInfoInternal data);
}
