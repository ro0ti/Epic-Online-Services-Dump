using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000403 RID: 1027
	[Token(Token = "0x2000403")]
	public struct LobbyMemberStatusReceivedCallbackInfo : ICallbackInfo
	{
		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B5C RID: 7004 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007C4")]
		public object ClientData
		{
			[Token(Token = "0x6001B5B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B5C")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B5E RID: 7006 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007C5")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001B5D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B5E")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B60 RID: 7008 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007C6")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001B5F")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B60")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x00007AFC File Offset: 0x00005CFC
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007C7")]
		public LobbyMemberStatus CurrentStatus
		{
			[Token(Token = "0x6001B61")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return LobbyMemberStatus.Joined;
			}
			[Token(Token = "0x6001B62")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x00007B14 File Offset: 0x00005D14
		[Token(Token = "0x6001B63")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B64")]
		[Address(RVA = "0x5298A0", Offset = "0x527EA0", VA = "0x1805298A0")]
		internal void Set(ref LobbyMemberStatusReceivedCallbackInfoInternal other)
		{
		}
	}
}
