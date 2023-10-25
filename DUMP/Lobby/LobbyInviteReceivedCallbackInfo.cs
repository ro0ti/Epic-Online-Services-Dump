using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003FE RID: 1022
	[Token(Token = "0x20003FE")]
	public struct LobbyInviteReceivedCallbackInfo : ICallbackInfo
	{
		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B2A RID: 6954 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007B0")]
		public object ClientData
		{
			[Token(Token = "0x6001B29")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B2A")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001B2B RID: 6955 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B2C RID: 6956 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007B1")]
		public Utf8String InviteId
		{
			[Token(Token = "0x6001B2B")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B2C")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B2E RID: 6958 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007B2")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001B2D")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B2E")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001B30 RID: 6960 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007B3")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001B2F")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001B30")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x00007A9C File Offset: 0x00005C9C
		[Token(Token = "0x6001B31")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B32")]
		[Address(RVA = "0x528810", Offset = "0x526E10", VA = "0x180528810")]
		internal void Set(ref LobbyInviteReceivedCallbackInfoInternal other)
		{
		}
	}
}
