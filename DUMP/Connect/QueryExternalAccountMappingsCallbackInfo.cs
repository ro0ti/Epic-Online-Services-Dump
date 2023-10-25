using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000633 RID: 1587
	[Token(Token = "0x2000633")]
	public struct QueryExternalAccountMappingsCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06002884 RID: 10372 RVA: 0x0000A31C File Offset: 0x0000851C
		// (set) Token: 0x06002885 RID: 10373 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BB7")]
		public Result ResultCode
		{
			[Token(Token = "0x6002884")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002885")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06002886 RID: 10374 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002887 RID: 10375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BB8")]
		public object ClientData
		{
			[Token(Token = "0x6002886")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002887")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002888 RID: 10376 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002889 RID: 10377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BB9")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002888")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002889")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x0000A334 File Offset: 0x00008534
		[Token(Token = "0x600288A")]
		[Address(RVA = "0x5644E0", Offset = "0x562AE0", VA = "0x1805644E0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600288B")]
		[Address(RVA = "0x564530", Offset = "0x562B30", VA = "0x180564530")]
		internal void Set(ref QueryExternalAccountMappingsCallbackInfoInternal other)
		{
		}
	}
}
