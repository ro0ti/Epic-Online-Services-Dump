﻿using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Friends
{
	// Token: 0x02000515 RID: 1301
	// (Invoke) Token: 0x0600214D RID: 8525
	[Token(Token = "0x2000515")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnQueryFriendsCallbackInternal(ref QueryFriendsCallbackInfoInternal data);
}
