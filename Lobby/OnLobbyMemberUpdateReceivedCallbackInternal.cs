﻿using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200044F RID: 1103
	// (Invoke) Token: 0x06001CB4 RID: 7348
	[Token(Token = "0x200044F")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnLobbyMemberUpdateReceivedCallbackInternal(ref LobbyMemberUpdateReceivedCallbackInfoInternal data);
}
