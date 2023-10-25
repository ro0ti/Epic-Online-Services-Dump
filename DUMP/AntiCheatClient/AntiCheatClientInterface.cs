using System;
using Epic.OnlineServices.AntiCheatCommon;


namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x020006F8 RID: 1784
	[Token(Token = "0x20006F8")]
	public sealed class AntiCheatClientInterface : Handle
	{
		// Token: 0x06002D9B RID: 11675 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D9B")]
		[Address(RVA = "0x56DD30", Offset = "0x56C330", VA = "0x18056DD30")]
		public AntiCheatClientInterface()
		{
		}

		// Token: 0x06002D9C RID: 11676 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D9C")]
		[Address(RVA = "0x56DCF0", Offset = "0x56C2F0", VA = "0x18056DCF0")]
		public AntiCheatClientInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x0000BC24 File Offset: 0x00009E24
		[Token(Token = "0x6002D9D")]
		[Address(RVA = "0x56C510", Offset = "0x56AB10", VA = "0x18056C510")]
		public Result AddExternalIntegrityCatalog(ref AddExternalIntegrityCatalogOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x0000BC3C File Offset: 0x00009E3C
		[Token(Token = "0x6002D9E")]
		[Address(RVA = "0x56C5F0", Offset = "0x56ABF0", VA = "0x18056C5F0")]
		public ulong AddNotifyClientIntegrityViolated(ref AddNotifyClientIntegrityViolatedOptions options, object clientData, OnClientIntegrityViolatedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x0000BC54 File Offset: 0x00009E54
		[Token(Token = "0x6002D9F")]
		[Address(RVA = "0x56C7B0", Offset = "0x56ADB0", VA = "0x18056C7B0")]
		public ulong AddNotifyMessageToPeer(ref AddNotifyMessageToPeerOptions options, object clientData, OnMessageToPeerCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x0000BC6C File Offset: 0x00009E6C
		[Token(Token = "0x6002DA0")]
		[Address(RVA = "0x56C970", Offset = "0x56AF70", VA = "0x18056C970")]
		public ulong AddNotifyMessageToServer(ref AddNotifyMessageToServerOptions options, object clientData, OnMessageToServerCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x0000BC84 File Offset: 0x00009E84
		[Token(Token = "0x6002DA1")]
		[Address(RVA = "0x56CB30", Offset = "0x56B130", VA = "0x18056CB30")]
		public ulong AddNotifyPeerActionRequired(ref AddNotifyPeerActionRequiredOptions options, object clientData, OnPeerActionRequiredCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x0000BC9C File Offset: 0x00009E9C
		[Token(Token = "0x6002DA2")]
		[Address(RVA = "0x56CCF0", Offset = "0x56B2F0", VA = "0x18056CCF0")]
		public ulong AddNotifyPeerAuthStatusChanged(ref AddNotifyPeerAuthStatusChangedOptions options, object clientData, OnPeerAuthStatusChangedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		[Token(Token = "0x6002DA3")]
		[Address(RVA = "0x56CEB0", Offset = "0x56B4B0", VA = "0x18056CEB0")]
		public Result BeginSession(ref BeginSessionOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x0000BCCC File Offset: 0x00009ECC
		[Token(Token = "0x6002DA4")]
		[Address(RVA = "0x56CFA0", Offset = "0x56B5A0", VA = "0x18056CFA0")]
		public Result EndSession(ref EndSessionOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x0000BCE4 File Offset: 0x00009EE4
		[Token(Token = "0x6002DA5")]
		[Address(RVA = "0x56D020", Offset = "0x56B620", VA = "0x18056D020")]
		public Result GetProtectMessageOutputLength(ref GetProtectMessageOutputLengthOptions options, out uint outBufferSizeBytes)
		{
			return Result.Success;
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x0000BCFC File Offset: 0x00009EFC
		[Token(Token = "0x6002DA6")]
		[Address(RVA = "0x56D400", Offset = "0x56BA00", VA = "0x18056D400")]
		public Result PollStatus(ref PollStatusOptions options, out AntiCheatClientViolationType outViolationType, out Utf8String outMessage)
		{
			return Result.Success;
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x0000BD14 File Offset: 0x00009F14
		[Token(Token = "0x6002DA7")]
		[Address(RVA = "0x56D4F0", Offset = "0x56BAF0", VA = "0x18056D4F0")]
		public Result ProtectMessage(ref ProtectMessageOptions options, ArraySegment<byte> outBuffer, out uint outBytesWritten)
		{
			return Result.Success;
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x0000BD2C File Offset: 0x00009F2C
		[Token(Token = "0x6002DA8")]
		[Address(RVA = "0x56D640", Offset = "0x56BC40", VA = "0x18056D640")]
		public Result ReceiveMessageFromPeer(ref ReceiveMessageFromPeerOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x0000BD44 File Offset: 0x00009F44
		[Token(Token = "0x6002DA9")]
		[Address(RVA = "0x56D740", Offset = "0x56BD40", VA = "0x18056D740")]
		public Result ReceiveMessageFromServer(ref ReceiveMessageFromServerOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x0000BD5C File Offset: 0x00009F5C
		[Token(Token = "0x6002DAA")]
		[Address(RVA = "0x56D830", Offset = "0x56BE30", VA = "0x18056D830")]
		public Result RegisterPeer(ref RegisterPeerOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DAB")]
		[Address(RVA = "0x56D8E0", Offset = "0x56BEE0", VA = "0x18056D8E0")]
		public void RemoveNotifyClientIntegrityViolated(ulong notificationId)
		{
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DAC")]
		[Address(RVA = "0x56D950", Offset = "0x56BF50", VA = "0x18056D950")]
		public void RemoveNotifyMessageToPeer(ulong notificationId)
		{
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DAD")]
		[Address(RVA = "0x56D9C0", Offset = "0x56BFC0", VA = "0x18056D9C0")]
		public void RemoveNotifyMessageToServer(ulong notificationId)
		{
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DAE")]
		[Address(RVA = "0x56DA30", Offset = "0x56C030", VA = "0x18056DA30")]
		public void RemoveNotifyPeerActionRequired(ulong notificationId)
		{
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DAF")]
		[Address(RVA = "0x56DAA0", Offset = "0x56C0A0", VA = "0x18056DAA0")]
		public void RemoveNotifyPeerAuthStatusChanged(ulong notificationId)
		{
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x0000BD74 File Offset: 0x00009F74
		[Token(Token = "0x6002DB0")]
		[Address(RVA = "0x56DB10", Offset = "0x56C110", VA = "0x18056DB10")]
		public Result UnprotectMessage(ref UnprotectMessageOptions options, ArraySegment<byte> outBuffer, out uint outBytesWritten)
		{
			return Result.Success;
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x0000BD8C File Offset: 0x00009F8C
		[Token(Token = "0x6002DB1")]
		[Address(RVA = "0x56DC60", Offset = "0x56C260", VA = "0x18056DC60")]
		public Result UnregisterPeer(ref UnregisterPeerOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DB2")]
		[Address(RVA = "0x56D0E0", Offset = "0x56B6E0", VA = "0x18056D0E0")]
		[MonoPInvokeCallback(typeof(OnClientIntegrityViolatedCallbackInternal))]
		internal static void OnClientIntegrityViolatedCallbackInternalImplementation(ref OnClientIntegrityViolatedCallbackInfoInternal data)
		{
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DB3")]
		[Address(RVA = "0x56D180", Offset = "0x56B780", VA = "0x18056D180")]
		[MonoPInvokeCallback(typeof(OnMessageToPeerCallbackInternal))]
		internal static void OnMessageToPeerCallbackInternalImplementation(ref OnMessageToClientCallbackInfoInternal data)
		{
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DB4")]
		[Address(RVA = "0x56D220", Offset = "0x56B820", VA = "0x18056D220")]
		[MonoPInvokeCallback(typeof(OnMessageToServerCallbackInternal))]
		internal static void OnMessageToServerCallbackInternalImplementation(ref OnMessageToServerCallbackInfoInternal data)
		{
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DB5")]
		[Address(RVA = "0x56D2C0", Offset = "0x56B8C0", VA = "0x18056D2C0")]
		[MonoPInvokeCallback(typeof(OnPeerActionRequiredCallbackInternal))]
		internal static void OnPeerActionRequiredCallbackInternalImplementation(ref OnClientActionRequiredCallbackInfoInternal data)
		{
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DB6")]
		[Address(RVA = "0x56D360", Offset = "0x56B960", VA = "0x18056D360")]
		[MonoPInvokeCallback(typeof(OnPeerAuthStatusChangedCallbackInternal))]
		internal static void OnPeerAuthStatusChangedCallbackInternalImplementation(ref OnClientAuthStatusChangedCallbackInfoInternal data)
		{
		}

		// Token: 0x0400143E RID: 5182
		[Token(Token = "0x400143E")]
		public const int AddexternalintegritycatalogApiLatest = 1;

		// Token: 0x0400143F RID: 5183
		[Token(Token = "0x400143F")]
		public const int AddnotifyclientintegrityviolatedApiLatest = 1;

		// Token: 0x04001440 RID: 5184
		[Token(Token = "0x4001440")]
		public const int AddnotifymessagetopeerApiLatest = 1;

		// Token: 0x04001441 RID: 5185
		[Token(Token = "0x4001441")]
		public const int AddnotifymessagetoserverApiLatest = 1;

		// Token: 0x04001442 RID: 5186
		[Token(Token = "0x4001442")]
		public const int AddnotifypeeractionrequiredApiLatest = 1;

		// Token: 0x04001443 RID: 5187
		[Token(Token = "0x4001443")]
		public const int AddnotifypeerauthstatuschangedApiLatest = 1;

		// Token: 0x04001444 RID: 5188
		[Token(Token = "0x4001444")]
		public const int BeginsessionApiLatest = 3;

		// Token: 0x04001445 RID: 5189
		[Token(Token = "0x4001445")]
		public const int EndsessionApiLatest = 1;

		// Token: 0x04001446 RID: 5190
		[Token(Token = "0x4001446")]
		public const int GetprotectmessageoutputlengthApiLatest = 1;

		// Token: 0x04001447 RID: 5191
		[Token(Token = "0x4001447")]
		[FieldOffset(Offset = "0x18")]
		public IntPtr PeerSelf;

		// Token: 0x04001448 RID: 5192
		[Token(Token = "0x4001448")]
		public const int PollstatusApiLatest = 1;

		// Token: 0x04001449 RID: 5193
		[Token(Token = "0x4001449")]
		public const int ProtectmessageApiLatest = 1;

		// Token: 0x0400144A RID: 5194
		[Token(Token = "0x400144A")]
		public const int ReceivemessagefrompeerApiLatest = 1;

		// Token: 0x0400144B RID: 5195
		[Token(Token = "0x400144B")]
		public const int ReceivemessagefromserverApiLatest = 1;

		// Token: 0x0400144C RID: 5196
		[Token(Token = "0x400144C")]
		public const int RegisterpeerApiLatest = 3;

		// Token: 0x0400144D RID: 5197
		[Token(Token = "0x400144D")]
		public const int RegisterpeerMaxAuthenticationtimeout = 120;

		// Token: 0x0400144E RID: 5198
		[Token(Token = "0x400144E")]
		public const int RegisterpeerMinAuthenticationtimeout = 40;

		// Token: 0x0400144F RID: 5199
		[Token(Token = "0x400144F")]
		public const int UnprotectmessageApiLatest = 1;

		// Token: 0x04001450 RID: 5200
		[Token(Token = "0x4001450")]
		public const int UnregisterpeerApiLatest = 1;
	}
}
