using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x0200030A RID: 778
	[Token(Token = "0x200030A")]
	public struct ReadFileDataCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001504 RID: 5380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700058E")]
		public object ClientData
		{
			[Token(Token = "0x6001503")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001504")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001506 RID: 5382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700058F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001505")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001506")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001508 RID: 5384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000590")]
		public Utf8String Filename
		{
			[Token(Token = "0x6001507")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001508")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x00005F9C File Offset: 0x0000419C
		// (set) Token: 0x0600150A RID: 5386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000591")]
		public uint TotalFileSizeBytes
		{
			[Token(Token = "0x6001509")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x600150A")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x00005FB4 File Offset: 0x000041B4
		// (set) Token: 0x0600150C RID: 5388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000592")]
		public bool IsLastChunk
		{
			[Token(Token = "0x600150B")]
			[Address(RVA = "0x4C45B0", Offset = "0x4C2BB0", VA = "0x1804C45B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x600150C")]
			[Address(RVA = "0x4C45E0", Offset = "0x4C2BE0", VA = "0x1804C45E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x00005FCC File Offset: 0x000041CC
		// (set) Token: 0x0600150E RID: 5390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000593")]
		public ArraySegment<byte> DataChunk
		{
			[Token(Token = "0x600150D")]
			[Address(RVA = "0x4C45A0", Offset = "0x4C2BA0", VA = "0x1804C45A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(ArraySegment<byte>);
			}
			[Token(Token = "0x600150E")]
			[Address(RVA = "0x4C45C0", Offset = "0x4C2BC0", VA = "0x1804C45C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00005FE4 File Offset: 0x000041E4
		[Token(Token = "0x600150F")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001510")]
		[Address(RVA = "0x500CF0", Offset = "0x4FF2F0", VA = "0x180500CF0")]
		internal void Set(ref ReadFileDataCallbackInfoInternal other)
		{
		}
	}
}
