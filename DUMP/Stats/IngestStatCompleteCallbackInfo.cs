using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	public struct IngestStatCompleteCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x00003434 File Offset: 0x00001634
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700016F")]
		public Result ResultCode
		{
			[Token(Token = "0x600078C")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x600078D")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000170")]
		public object ClientData
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000171")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000790")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000791")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000172")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000792")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0000344C File Offset: 0x0000164C
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x4BD8B0", Offset = "0x4BBEB0", VA = "0x1804BD8B0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x4BD900", Offset = "0x4BBF00", VA = "0x1804BD900")]
		internal void Set(ref IngestStatCompleteCallbackInfoInternal other)
		{
		}
	}
}
