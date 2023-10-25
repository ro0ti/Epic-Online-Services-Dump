using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005B0 RID: 1456
	[Token(Token = "0x20005B0")]
	public sealed class CustomInvitesInterface : Handle
	{
		// Token: 0x0600253C RID: 9532 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600253C")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public CustomInvitesInterface()
		{
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600253D")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public CustomInvitesInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600253E")]
		[Address(RVA = "0x540440", Offset = "0x53EA40", VA = "0x180540440")]
		public void AcceptRequestToJoin(ref AcceptRequestToJoinOptions options, object clientData, OnAcceptRequestToJoinCallback completionDelegate)
		{
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x00009A7C File Offset: 0x00007C7C
		[Token(Token = "0x600253F")]
		[Address(RVA = "0x540580", Offset = "0x53EB80", VA = "0x180540580")]
		public ulong AddNotifyCustomInviteAccepted(ref AddNotifyCustomInviteAcceptedOptions options, object clientData, OnCustomInviteAcceptedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x00009A94 File Offset: 0x00007C94
		[Token(Token = "0x6002540")]
		[Address(RVA = "0x5406C0", Offset = "0x53ECC0", VA = "0x1805406C0")]
		public ulong AddNotifyCustomInviteReceived(ref AddNotifyCustomInviteReceivedOptions options, object clientData, OnCustomInviteReceivedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x00009AAC File Offset: 0x00007CAC
		[Token(Token = "0x6002541")]
		[Address(RVA = "0x540800", Offset = "0x53EE00", VA = "0x180540800")]
		public ulong AddNotifyCustomInviteRejected(ref AddNotifyCustomInviteRejectedOptions options, object clientData, OnCustomInviteRejectedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x00009AC4 File Offset: 0x00007CC4
		[Token(Token = "0x6002542")]
		[Address(RVA = "0x540940", Offset = "0x53EF40", VA = "0x180540940")]
		public ulong AddNotifyRequestToJoinAccepted(ref AddNotifyRequestToJoinAcceptedOptions options, object clientData, OnRequestToJoinAcceptedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x00009ADC File Offset: 0x00007CDC
		[Token(Token = "0x6002543")]
		[Address(RVA = "0x540A80", Offset = "0x53F080", VA = "0x180540A80")]
		public ulong AddNotifyRequestToJoinReceived(ref AddNotifyRequestToJoinReceivedOptions options, object clientData, OnRequestToJoinReceivedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x00009AF4 File Offset: 0x00007CF4
		[Token(Token = "0x6002544")]
		[Address(RVA = "0x540BC0", Offset = "0x53F1C0", VA = "0x180540BC0")]
		public ulong AddNotifyRequestToJoinRejected(ref AddNotifyRequestToJoinRejectedOptions options, object clientData, OnRequestToJoinRejectedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x00009B0C File Offset: 0x00007D0C
		[Token(Token = "0x6002545")]
		[Address(RVA = "0x540D00", Offset = "0x53F300", VA = "0x180540D00")]
		public ulong AddNotifyRequestToJoinResponseReceived(ref AddNotifyRequestToJoinResponseReceivedOptions options, object clientData, OnRequestToJoinResponseReceivedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x00009B24 File Offset: 0x00007D24
		[Token(Token = "0x6002546")]
		[Address(RVA = "0x540E40", Offset = "0x53F440", VA = "0x180540E40")]
		public ulong AddNotifySendCustomNativeInviteRequested(ref AddNotifySendCustomNativeInviteRequestedOptions options, object clientData, OnSendCustomNativeInviteRequestedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x00009B3C File Offset: 0x00007D3C
		[Token(Token = "0x6002547")]
		[Address(RVA = "0x540F80", Offset = "0x53F580", VA = "0x180540F80")]
		public Result FinalizeInvite(ref FinalizeInviteOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002548")]
		[Address(RVA = "0x5417F0", Offset = "0x53FDF0", VA = "0x1805417F0")]
		public void RejectRequestToJoin(ref RejectRequestToJoinOptions options, object clientData, OnRejectRequestToJoinCallback completionDelegate)
		{
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002549")]
		[Address(RVA = "0x541930", Offset = "0x53FF30", VA = "0x180541930")]
		public void RemoveNotifyCustomInviteAccepted(ulong inId)
		{
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600254A")]
		[Address(RVA = "0x5419A0", Offset = "0x53FFA0", VA = "0x1805419A0")]
		public void RemoveNotifyCustomInviteReceived(ulong inId)
		{
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600254B")]
		[Address(RVA = "0x541A10", Offset = "0x540010", VA = "0x180541A10")]
		public void RemoveNotifyCustomInviteRejected(ulong inId)
		{
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600254C")]
		[Address(RVA = "0x541A80", Offset = "0x540080", VA = "0x180541A80")]
		public void RemoveNotifyRequestToJoinAccepted(ulong inId)
		{
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600254D")]
		[Address(RVA = "0x541AF0", Offset = "0x5400F0", VA = "0x180541AF0")]
		public void RemoveNotifyRequestToJoinReceived(ulong inId)
		{
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600254E")]
		[Address(RVA = "0x541B60", Offset = "0x540160", VA = "0x180541B60")]
		public void RemoveNotifyRequestToJoinRejected(ulong inId)
		{
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600254F")]
		[Address(RVA = "0x541BD0", Offset = "0x5401D0", VA = "0x180541BD0")]
		public void RemoveNotifyRequestToJoinResponseReceived(ulong inId)
		{
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002550")]
		[Address(RVA = "0x541C40", Offset = "0x540240", VA = "0x180541C40")]
		public void RemoveNotifySendCustomNativeInviteRequested(ulong inId)
		{
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002551")]
		[Address(RVA = "0x541CB0", Offset = "0x5402B0", VA = "0x180541CB0")]
		public void SendCustomInvite(ref SendCustomInviteOptions options, object clientData, OnSendCustomInviteCallback completionDelegate)
		{
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002552")]
		[Address(RVA = "0x541DF0", Offset = "0x5403F0", VA = "0x180541DF0")]
		public void SendRequestToJoin(ref SendRequestToJoinOptions options, object clientData, OnSendRequestToJoinCallback completionDelegate)
		{
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x00009B54 File Offset: 0x00007D54
		[Token(Token = "0x6002553")]
		[Address(RVA = "0x541F30", Offset = "0x540530", VA = "0x180541F30")]
		public Result SetCustomInvite(ref SetCustomInviteOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002554")]
		[Address(RVA = "0x541030", Offset = "0x53F630", VA = "0x180541030")]
		[MonoPInvokeCallback(typeof(OnAcceptRequestToJoinCallbackInternal))]
		internal static void OnAcceptRequestToJoinCallbackInternalImplementation(ref AcceptRequestToJoinCallbackInfoInternal data)
		{
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002555")]
		[Address(RVA = "0x5410D0", Offset = "0x53F6D0", VA = "0x1805410D0")]
		[MonoPInvokeCallback(typeof(OnCustomInviteAcceptedCallbackInternal))]
		internal static void OnCustomInviteAcceptedCallbackInternalImplementation(ref OnCustomInviteAcceptedCallbackInfoInternal data)
		{
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002556")]
		[Address(RVA = "0x541180", Offset = "0x53F780", VA = "0x180541180")]
		[MonoPInvokeCallback(typeof(OnCustomInviteReceivedCallbackInternal))]
		internal static void OnCustomInviteReceivedCallbackInternalImplementation(ref OnCustomInviteReceivedCallbackInfoInternal data)
		{
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002557")]
		[Address(RVA = "0x541230", Offset = "0x53F830", VA = "0x180541230")]
		[MonoPInvokeCallback(typeof(OnCustomInviteRejectedCallbackInternal))]
		internal static void OnCustomInviteRejectedCallbackInternalImplementation(ref CustomInviteRejectedCallbackInfoInternal data)
		{
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002558")]
		[Address(RVA = "0x5412E0", Offset = "0x53F8E0", VA = "0x1805412E0")]
		[MonoPInvokeCallback(typeof(OnRejectRequestToJoinCallbackInternal))]
		internal static void OnRejectRequestToJoinCallbackInternalImplementation(ref RejectRequestToJoinCallbackInfoInternal data)
		{
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002559")]
		[Address(RVA = "0x541380", Offset = "0x53F980", VA = "0x180541380")]
		[MonoPInvokeCallback(typeof(OnRequestToJoinAcceptedCallbackInternal))]
		internal static void OnRequestToJoinAcceptedCallbackInternalImplementation(ref OnRequestToJoinAcceptedCallbackInfoInternal data)
		{
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600255A")]
		[Address(RVA = "0x541420", Offset = "0x53FA20", VA = "0x180541420")]
		[MonoPInvokeCallback(typeof(OnRequestToJoinReceivedCallbackInternal))]
		internal static void OnRequestToJoinReceivedCallbackInternalImplementation(ref RequestToJoinReceivedCallbackInfoInternal data)
		{
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600255B")]
		[Address(RVA = "0x5414C0", Offset = "0x53FAC0", VA = "0x1805414C0")]
		[MonoPInvokeCallback(typeof(OnRequestToJoinRejectedCallbackInternal))]
		internal static void OnRequestToJoinRejectedCallbackInternalImplementation(ref OnRequestToJoinRejectedCallbackInfoInternal data)
		{
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600255C")]
		[Address(RVA = "0x541560", Offset = "0x53FB60", VA = "0x180541560")]
		[MonoPInvokeCallback(typeof(OnRequestToJoinResponseReceivedCallbackInternal))]
		internal static void OnRequestToJoinResponseReceivedCallbackInternalImplementation(ref RequestToJoinResponseReceivedCallbackInfoInternal data)
		{
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600255D")]
		[Address(RVA = "0x541600", Offset = "0x53FC00", VA = "0x180541600")]
		[MonoPInvokeCallback(typeof(OnSendCustomInviteCallbackInternal))]
		internal static void OnSendCustomInviteCallbackInternalImplementation(ref SendCustomInviteCallbackInfoInternal data)
		{
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600255E")]
		[Address(RVA = "0x5416A0", Offset = "0x53FCA0", VA = "0x1805416A0")]
		[MonoPInvokeCallback(typeof(OnSendCustomNativeInviteRequestedCallbackInternal))]
		internal static void OnSendCustomNativeInviteRequestedCallbackInternalImplementation(ref SendCustomNativeInviteRequestedCallbackInfoInternal data)
		{
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600255F")]
		[Address(RVA = "0x541750", Offset = "0x53FD50", VA = "0x180541750")]
		[MonoPInvokeCallback(typeof(OnSendRequestToJoinCallbackInternal))]
		internal static void OnSendRequestToJoinCallbackInternalImplementation(ref SendRequestToJoinCallbackInfoInternal data)
		{
		}

		// Token: 0x04001082 RID: 4226
		[Token(Token = "0x4001082")]
		public const int AcceptrequesttojoinApiLatest = 1;

		// Token: 0x04001083 RID: 4227
		[Token(Token = "0x4001083")]
		public const int AddnotifycustominviteacceptedApiLatest = 1;

		// Token: 0x04001084 RID: 4228
		[Token(Token = "0x4001084")]
		public const int AddnotifycustominvitereceivedApiLatest = 1;

		// Token: 0x04001085 RID: 4229
		[Token(Token = "0x4001085")]
		public const int AddnotifycustominviterejectedApiLatest = 1;

		// Token: 0x04001086 RID: 4230
		[Token(Token = "0x4001086")]
		public const int AddnotifyrequesttojoinacceptedApiLatest = 1;

		// Token: 0x04001087 RID: 4231
		[Token(Token = "0x4001087")]
		public const int AddnotifyrequesttojoinreceivedApiLatest = 1;

		// Token: 0x04001088 RID: 4232
		[Token(Token = "0x4001088")]
		public const int AddnotifyrequesttojoinrejectedApiLatest = 1;

		// Token: 0x04001089 RID: 4233
		[Token(Token = "0x4001089")]
		public const int AddnotifyrequesttojoinresponsereceivedApiLatest = 1;

		// Token: 0x0400108A RID: 4234
		[Token(Token = "0x400108A")]
		public const int AddnotifysendcustomnativeinviterequestedApiLatest = 1;

		// Token: 0x0400108B RID: 4235
		[Token(Token = "0x400108B")]
		public const int FinalizeinviteApiLatest = 1;

		// Token: 0x0400108C RID: 4236
		[Token(Token = "0x400108C")]
		public const int MaxPayloadLength = 500;

		// Token: 0x0400108D RID: 4237
		[Token(Token = "0x400108D")]
		public const int RejectrequesttojoinApiLatest = 1;

		// Token: 0x0400108E RID: 4238
		[Token(Token = "0x400108E")]
		public const int SendcustominviteApiLatest = 1;

		// Token: 0x0400108F RID: 4239
		[Token(Token = "0x400108F")]
		public const int SendrequesttojoinApiLatest = 1;

		// Token: 0x04001090 RID: 4240
		[Token(Token = "0x4001090")]
		public const int SetcustominviteApiLatest = 1;
	}
}
