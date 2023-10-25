using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003AA RID: 938
	[Token(Token = "0x20003AA")]
	internal struct AttributeDataInternal : IGettable<AttributeData>, ISettable<AttributeData>, IDisposable
	{
		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060018A0 RID: 6304 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060018A1 RID: 6305 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006C5")]
		public Utf8String Key
		{
			[Token(Token = "0x60018A0")]
			[Address(RVA = "0x505A70", Offset = "0x504070", VA = "0x180505A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60018A1")]
			[Address(RVA = "0x505B70", Offset = "0x504170", VA = "0x180505B70")]
			set
			{
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060018A2 RID: 6306 RVA: 0x00006EFC File Offset: 0x000050FC
		// (set) Token: 0x060018A3 RID: 6307 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006C6")]
		public AttributeDataValue Value
		{
			[Token(Token = "0x60018A2")]
			[Address(RVA = "0x505AE0", Offset = "0x5040E0", VA = "0x180505AE0")]
			get
			{
				return default(AttributeDataValue);
			}
			[Token(Token = "0x60018A3")]
			[Address(RVA = "0x505BD0", Offset = "0x5041D0", VA = "0x180505BD0")]
			set
			{
			}
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018A4")]
		[Address(RVA = "0x505970", Offset = "0x503F70", VA = "0x180505970", Slot = "5")]
		public void Set(ref AttributeData other)
		{
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018A5")]
		[Address(RVA = "0x505810", Offset = "0x503E10", VA = "0x180505810", Slot = "6")]
		public void Set(ref AttributeData? other)
		{
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018A6")]
		[Address(RVA = "0x505770", Offset = "0x503D70", VA = "0x180505770", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018A7")]
		[Address(RVA = "0x5057E0", Offset = "0x503DE0", VA = "0x1805057E0", Slot = "4")]
		public void Get(out AttributeData output)
		{
		}

		// Token: 0x04000B14 RID: 2836
		[Token(Token = "0x4000B14")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000B15 RID: 2837
		[Token(Token = "0x4000B15")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Key;

		// Token: 0x04000B16 RID: 2838
		[Token(Token = "0x4000B16")]
		[FieldOffset(Offset = "0x10")]
		private AttributeDataValueInternal m_Value;
	}
}
