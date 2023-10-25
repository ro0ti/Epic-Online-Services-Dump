using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000405 RID: 1029
	[Token(Token = "0x2000405")]
	public struct LobbyMemberUpdateReceivedCallbackInfo : ICallbackInfo
	{
		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B73 RID: 7027 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007CD")]
		public object ClientData
		{
			[Token(Token = "0x6001B72")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B73")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001B74 RID: 7028 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B75 RID: 7029 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007CE")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001B74")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B75")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B77 RID: 7031 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007CF")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001B76")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B77")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x00007B5C File Offset: 0x00005D5C
		[Token(Token = "0x6001B78")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B79")]
		[Address(RVA = "0x529F10", Offset = "0x528510", VA = "0x180529F10")]
		internal void Set(ref LobbyMemberUpdateReceivedCallbackInfoInternal other)
		{
		}
	}
}
