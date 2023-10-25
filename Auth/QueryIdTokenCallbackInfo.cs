using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200067F RID: 1663
	[Token(Token = "0x200067F")]
	public struct QueryIdTokenCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06002A8B RID: 10891 RVA: 0x0000AA0C File Offset: 0x00008C0C
		// (set) Token: 0x06002A8C RID: 10892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C5F")]
		public Result ResultCode
		{
			[Token(Token = "0x6002A8B")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002A8C")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06002A8D RID: 10893 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A8E RID: 10894 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C60")]
		public object ClientData
		{
			[Token(Token = "0x6002A8D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002A8E")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06002A8F RID: 10895 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A90 RID: 10896 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C61")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002A8F")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002A90")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06002A91 RID: 10897 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A92 RID: 10898 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C62")]
		public EpicAccountId TargetAccountId
		{
			[Token(Token = "0x6002A91")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002A92")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x0000AA24 File Offset: 0x00008C24
		[Token(Token = "0x6002A93")]
		[Address(RVA = "0x57CFD0", Offset = "0x57B5D0", VA = "0x18057CFD0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A94")]
		[Address(RVA = "0x57D020", Offset = "0x57B620", VA = "0x18057D020")]
		internal void Set(ref QueryIdTokenCallbackInfoInternal other)
		{
		}
	}
}
