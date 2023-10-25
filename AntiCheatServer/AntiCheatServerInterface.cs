using System;
using Epic.OnlineServices.AntiCheatCommon;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x02000699 RID: 1689
	[Token(Token = "0x2000699")]
	public sealed class AntiCheatServerInterface : Handle
	{
		// Token: 0x06002B65 RID: 11109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B65")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public AntiCheatServerInterface()
		{
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B66")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public AntiCheatServerInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x0000AD54 File Offset: 0x00008F54
		[Token(Token = "0x6002B67")]
		[Address(RVA = "0x56DD60", Offset = "0x56C360", VA = "0x18056DD60")]
		public ulong AddNotifyClientActionRequired(ref AddNotifyClientActionRequiredOptions options, object clientData, OnClientActionRequiredCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x0000AD6C File Offset: 0x00008F6C
		[Token(Token = "0x6002B68")]
		[Address(RVA = "0x56DF20", Offset = "0x56C520", VA = "0x18056DF20")]
		public ulong AddNotifyClientAuthStatusChanged(ref AddNotifyClientAuthStatusChangedOptions options, object clientData, OnClientAuthStatusChangedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x0000AD84 File Offset: 0x00008F84
		[Token(Token = "0x6002B69")]
		[Address(RVA = "0x56E0E0", Offset = "0x56C6E0", VA = "0x18056E0E0")]
		public ulong AddNotifyMessageToClient(ref AddNotifyMessageToClientOptions options, object clientData, OnMessageToClientCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x0000AD9C File Offset: 0x00008F9C
		[Token(Token = "0x6002B6A")]
		[Address(RVA = "0x56E2A0", Offset = "0x56C8A0", VA = "0x18056E2A0")]
		public Result BeginSession(ref BeginSessionOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x0000ADB4 File Offset: 0x00008FB4
		[Token(Token = "0x6002B6B")]
		[Address(RVA = "0x56E340", Offset = "0x56C940", VA = "0x18056E340")]
		public Result EndSession(ref EndSessionOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x0000ADCC File Offset: 0x00008FCC
		[Token(Token = "0x6002B6C")]
		[Address(RVA = "0x56E3C0", Offset = "0x56C9C0", VA = "0x18056E3C0")]
		public Result GetProtectMessageOutputLength(ref GetProtectMessageOutputLengthOptions options, out uint outBufferSizeBytes)
		{
			return Result.Success;
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x0000ADE4 File Offset: 0x00008FE4
		[Token(Token = "0x6002B6D")]
		[Address(RVA = "0x56E480", Offset = "0x56CA80", VA = "0x18056E480")]
		public Result LogEvent(ref LogEventOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x0000ADFC File Offset: 0x00008FFC
		[Token(Token = "0x6002B6E")]
		[Address(RVA = "0x56E590", Offset = "0x56CB90", VA = "0x18056E590")]
		public Result LogGameRoundEnd(ref LogGameRoundEndOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x0000AE14 File Offset: 0x00009014
		[Token(Token = "0x6002B6F")]
		[Address(RVA = "0x56E620", Offset = "0x56CC20", VA = "0x18056E620")]
		public Result LogGameRoundStart(ref LogGameRoundStartOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x0000AE2C File Offset: 0x0000902C
		[Token(Token = "0x6002B70")]
		[Address(RVA = "0x56E6D0", Offset = "0x56CCD0", VA = "0x18056E6D0")]
		public Result LogPlayerDespawn(ref LogPlayerDespawnOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x0000AE44 File Offset: 0x00009044
		[Token(Token = "0x6002B71")]
		[Address(RVA = "0x56E760", Offset = "0x56CD60", VA = "0x18056E760")]
		public Result LogPlayerRevive(ref LogPlayerReviveOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x0000AE5C File Offset: 0x0000905C
		[Token(Token = "0x6002B72")]
		[Address(RVA = "0x56E800", Offset = "0x56CE00", VA = "0x18056E800")]
		public Result LogPlayerSpawn(ref LogPlayerSpawnOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x0000AE74 File Offset: 0x00009074
		[Token(Token = "0x6002B73")]
		[Address(RVA = "0x56E8A0", Offset = "0x56CEA0", VA = "0x18056E8A0")]
		public Result LogPlayerTakeDamage(ref LogPlayerTakeDamageOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x0000AE8C File Offset: 0x0000908C
		[Token(Token = "0x6002B74")]
		[Address(RVA = "0x56E970", Offset = "0x56CF70", VA = "0x18056E970")]
		public Result LogPlayerTick(ref LogPlayerTickOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x0000AEA4 File Offset: 0x000090A4
		[Token(Token = "0x6002B75")]
		[Address(RVA = "0x56EA10", Offset = "0x56D010", VA = "0x18056EA10")]
		public Result LogPlayerUseAbility(ref LogPlayerUseAbilityOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x0000AEBC File Offset: 0x000090BC
		[Token(Token = "0x6002B76")]
		[Address(RVA = "0x56EAC0", Offset = "0x56D0C0", VA = "0x18056EAC0")]
		public Result LogPlayerUseWeapon(ref LogPlayerUseWeaponOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x0000AED4 File Offset: 0x000090D4
		[Token(Token = "0x6002B77")]
		[Address(RVA = "0x56EDB0", Offset = "0x56D3B0", VA = "0x18056EDB0")]
		public Result ProtectMessage(ref ProtectMessageOptions options, ArraySegment<byte> outBuffer, out uint outBytesWritten)
		{
			return Result.Success;
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x0000AEEC File Offset: 0x000090EC
		[Token(Token = "0x6002B78")]
		[Address(RVA = "0x56EF10", Offset = "0x56D510", VA = "0x18056EF10")]
		public Result ReceiveMessageFromClient(ref ReceiveMessageFromClientOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x0000AF04 File Offset: 0x00009104
		[Token(Token = "0x6002B79")]
		[Address(RVA = "0x56F010", Offset = "0x56D610", VA = "0x18056F010")]
		public Result RegisterClient(ref RegisterClientOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x0000AF1C File Offset: 0x0000911C
		[Token(Token = "0x6002B7A")]
		[Address(RVA = "0x56F0B0", Offset = "0x56D6B0", VA = "0x18056F0B0")]
		public Result RegisterEvent(ref RegisterEventOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B7B")]
		[Address(RVA = "0x56F210", Offset = "0x56D810", VA = "0x18056F210")]
		public void RemoveNotifyClientActionRequired(ulong notificationId)
		{
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B7C")]
		[Address(RVA = "0x56F280", Offset = "0x56D880", VA = "0x18056F280")]
		public void RemoveNotifyClientAuthStatusChanged(ulong notificationId)
		{
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B7D")]
		[Address(RVA = "0x56F2F0", Offset = "0x56D8F0", VA = "0x18056F2F0")]
		public void RemoveNotifyMessageToClient(ulong notificationId)
		{
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x0000AF34 File Offset: 0x00009134
		[Token(Token = "0x6002B7E")]
		[Address(RVA = "0x56F360", Offset = "0x56D960", VA = "0x18056F360")]
		public Result SetClientDetails(ref SetClientDetailsOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x0000AF4C File Offset: 0x0000914C
		[Token(Token = "0x6002B7F")]
		[Address(RVA = "0x56F400", Offset = "0x56DA00", VA = "0x18056F400")]
		public Result SetClientNetworkState(ref SetClientNetworkStateOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x0000AF64 File Offset: 0x00009164
		[Token(Token = "0x6002B80")]
		[Address(RVA = "0x56F4E0", Offset = "0x56DAE0", VA = "0x18056F4E0")]
		public Result SetGameSessionId(ref SetGameSessionIdOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x0000AF7C File Offset: 0x0000917C
		[Token(Token = "0x6002B81")]
		[Address(RVA = "0x56F5C0", Offset = "0x56DBC0", VA = "0x18056F5C0")]
		public Result UnprotectMessage(ref UnprotectMessageOptions options, ArraySegment<byte> outBuffer, out uint outBytesWritten)
		{
			return Result.Success;
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x0000AF94 File Offset: 0x00009194
		[Token(Token = "0x6002B82")]
		[Address(RVA = "0x56F720", Offset = "0x56DD20", VA = "0x18056F720")]
		public Result UnregisterClient(ref UnregisterClientOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B83")]
		[Address(RVA = "0x56EBD0", Offset = "0x56D1D0", VA = "0x18056EBD0")]
		[MonoPInvokeCallback(typeof(OnClientActionRequiredCallbackInternal))]
		internal static void OnClientActionRequiredCallbackInternalImplementation(ref OnClientActionRequiredCallbackInfoInternal data)
		{
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B84")]
		[Address(RVA = "0x56EC70", Offset = "0x56D270", VA = "0x18056EC70")]
		[MonoPInvokeCallback(typeof(OnClientAuthStatusChangedCallbackInternal))]
		internal static void OnClientAuthStatusChangedCallbackInternalImplementation(ref OnClientAuthStatusChangedCallbackInfoInternal data)
		{
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B85")]
		[Address(RVA = "0x56ED10", Offset = "0x56D310", VA = "0x18056ED10")]
		[MonoPInvokeCallback(typeof(OnMessageToClientCallbackInternal))]
		internal static void OnMessageToClientCallbackInternalImplementation(ref OnMessageToClientCallbackInfoInternal data)
		{
		}

		// Token: 0x040012D3 RID: 4819
		[Token(Token = "0x40012D3")]
		public const int AddnotifyclientactionrequiredApiLatest = 1;

		// Token: 0x040012D4 RID: 4820
		[Token(Token = "0x40012D4")]
		public const int AddnotifyclientauthstatuschangedApiLatest = 1;

		// Token: 0x040012D5 RID: 4821
		[Token(Token = "0x40012D5")]
		public const int AddnotifymessagetoclientApiLatest = 1;

		// Token: 0x040012D6 RID: 4822
		[Token(Token = "0x40012D6")]
		public const int BeginsessionApiLatest = 3;

		// Token: 0x040012D7 RID: 4823
		[Token(Token = "0x40012D7")]
		public const int BeginsessionMaxRegistertimeout = 120;

		// Token: 0x040012D8 RID: 4824
		[Token(Token = "0x40012D8")]
		public const int BeginsessionMinRegistertimeout = 10;

		// Token: 0x040012D9 RID: 4825
		[Token(Token = "0x40012D9")]
		public const int EndsessionApiLatest = 1;

		// Token: 0x040012DA RID: 4826
		[Token(Token = "0x40012DA")]
		public const int GetprotectmessageoutputlengthApiLatest = 1;

		// Token: 0x040012DB RID: 4827
		[Token(Token = "0x40012DB")]
		public const int ProtectmessageApiLatest = 1;

		// Token: 0x040012DC RID: 4828
		[Token(Token = "0x40012DC")]
		public const int ReceivemessagefromclientApiLatest = 1;

		// Token: 0x040012DD RID: 4829
		[Token(Token = "0x40012DD")]
		public const int RegisterclientApiLatest = 2;

		// Token: 0x040012DE RID: 4830
		[Token(Token = "0x40012DE")]
		public const int SetclientnetworkstateApiLatest = 1;

		// Token: 0x040012DF RID: 4831
		[Token(Token = "0x40012DF")]
		public const int UnprotectmessageApiLatest = 1;

		// Token: 0x040012E0 RID: 4832
		[Token(Token = "0x40012E0")]
		public const int UnregisterclientApiLatest = 1;
	}
}
