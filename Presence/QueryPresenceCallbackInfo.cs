using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002C9 RID: 713
	[Token(Token = "0x20002C9")]
	public struct QueryPresenceCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x00005A5C File Offset: 0x00003C5C
		// (set) Token: 0x06001364 RID: 4964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000517")]
		public Result ResultCode
		{
			[Token(Token = "0x6001363")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001364")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001366 RID: 4966 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000518")]
		public object ClientData
		{
			[Token(Token = "0x6001365")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001366")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001368 RID: 4968 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000519")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6001367")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001368")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600136A RID: 4970 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700051A")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6001369")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600136A")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00005A74 File Offset: 0x00003C74
		[Token(Token = "0x600136B")]
		[Address(RVA = "0x4FE720", Offset = "0x4FCD20", VA = "0x1804FE720", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600136C")]
		[Address(RVA = "0x4FE770", Offset = "0x4FCD70", VA = "0x1804FE770")]
		internal void Set(ref QueryPresenceCallbackInfoInternal other)
		{
		}
	}
}
