using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002D8 RID: 728
	[Token(Token = "0x20002D8")]
	public struct DeleteCacheCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x00005B34 File Offset: 0x00003D34
		// (set) Token: 0x060013BA RID: 5050 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000537")]
		public Result ResultCode
		{
			[Token(Token = "0x60013B9")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60013BA")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060013BC RID: 5052 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000538")]
		public object ClientData
		{
			[Token(Token = "0x60013BB")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60013BC")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060013BE RID: 5054 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000539")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60013BD")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60013BE")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00005B4C File Offset: 0x00003D4C
		[Token(Token = "0x60013BF")]
		[Address(RVA = "0x4EF4F0", Offset = "0x4EDAF0", VA = "0x1804EF4F0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013C0")]
		[Address(RVA = "0x4EF540", Offset = "0x4EDB40", VA = "0x1804EF540")]
		internal void Set(ref DeleteCacheCallbackInfoInternal other)
		{
		}
	}
}
