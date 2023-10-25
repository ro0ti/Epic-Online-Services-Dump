using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004D0 RID: 1232
	[Token(Token = "0x20004D0")]
	public struct RequestPermissionsCallbackInfo : ICallbackInfo
	{
		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001FBA RID: 8122 RVA: 0x000088F4 File Offset: 0x00006AF4
		// (set) Token: 0x06001FBB RID: 8123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008F8")]
		public Result ResultCode
		{
			[Token(Token = "0x6001FBA")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001FBB")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001FBD RID: 8125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008F9")]
		public object ClientData
		{
			[Token(Token = "0x6001FBC")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001FBD")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001FBF RID: 8127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008FA")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001FBE")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001FBF")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x0000890C File Offset: 0x00006B0C
		[Token(Token = "0x6001FC0")]
		[Address(RVA = "0x535E00", Offset = "0x534400", VA = "0x180535E00", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FC1")]
		[Address(RVA = "0x535E50", Offset = "0x534450", VA = "0x180535E50")]
		internal void Set(ref RequestPermissionsCallbackInfoInternal other)
		{
		}
	}
}
