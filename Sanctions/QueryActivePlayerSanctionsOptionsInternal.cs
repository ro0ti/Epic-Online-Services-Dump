using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sanctions
{
	// Token: 0x020001AE RID: 430
	[Token(Token = "0x20001AE")]
	internal struct QueryActivePlayerSanctionsOptionsInternal : ISettable<QueryActivePlayerSanctionsOptions>, IDisposable
	{
		// Token: 0x170002DA RID: 730
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002DA")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000C53")]
			[Address(RVA = "0x4DF690", Offset = "0x4DDC90", VA = "0x1804DF690")]
			set
			{
			}
		}

		// Token: 0x170002DB RID: 731
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002DB")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000C54")]
			[Address(RVA = "0x4DF630", Offset = "0x4DDC30", VA = "0x1804DF630")]
			set
			{
			}
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x4DF570", Offset = "0x4DDB70", VA = "0x1804DF570", Slot = "4")]
		public void Set(ref QueryActivePlayerSanctionsOptions other)
		{
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x4DF460", Offset = "0x4DDA60", VA = "0x1804DF460", Slot = "5")]
		public void Set(ref QueryActivePlayerSanctionsOptions? other)
		{
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x4DF400", Offset = "0x4DDA00", VA = "0x1804DF400", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040005B5 RID: 1461
		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
