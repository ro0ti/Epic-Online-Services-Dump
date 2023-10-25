using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003AC RID: 940
	[Token(Token = "0x20003AC")]
	[StructLayout(2)]
	internal struct AttributeDataValueInternal : IGettable<AttributeDataValue>, ISettable<AttributeDataValue>, IDisposable
	{
		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060018B8 RID: 6328 RVA: 0x00006FEC File Offset: 0x000051EC
		// (set) Token: 0x060018B9 RID: 6329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006CC")]
		public long? AsInt64
		{
			[Token(Token = "0x60018B8")]
			[Address(RVA = "0x506250", Offset = "0x504850", VA = "0x180506250")]
			get
			{
				return null;
			}
			[Token(Token = "0x60018B9")]
			[Address(RVA = "0x506510", Offset = "0x504B10", VA = "0x180506510")]
			set
			{
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x00007004 File Offset: 0x00005204
		// (set) Token: 0x060018BB RID: 6331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006CD")]
		public double? AsDouble
		{
			[Token(Token = "0x60018BA")]
			[Address(RVA = "0x5061B0", Offset = "0x5047B0", VA = "0x1805061B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60018BB")]
			[Address(RVA = "0x506440", Offset = "0x504A40", VA = "0x180506440")]
			set
			{
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x0000701C File Offset: 0x0000521C
		// (set) Token: 0x060018BD RID: 6333 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006CE")]
		public bool? AsBool
		{
			[Token(Token = "0x60018BC")]
			[Address(RVA = "0x506120", Offset = "0x504720", VA = "0x180506120")]
			get
			{
				return null;
			}
			[Token(Token = "0x60018BD")]
			[Address(RVA = "0x506380", Offset = "0x504980", VA = "0x180506380")]
			set
			{
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060018BE RID: 6334 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060018BF RID: 6335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006CF")]
		public Utf8String AsUtf8
		{
			[Token(Token = "0x60018BE")]
			[Address(RVA = "0x5062F0", Offset = "0x5048F0", VA = "0x1805062F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60018BF")]
			[Address(RVA = "0x5065E0", Offset = "0x504BE0", VA = "0x1805065E0")]
			set
			{
			}
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018C0")]
		[Address(RVA = "0x505CE0", Offset = "0x5042E0", VA = "0x180505CE0", Slot = "5")]
		public void Set(ref AttributeDataValue other)
		{
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018C1")]
		[Address(RVA = "0x505E60", Offset = "0x504460", VA = "0x180505E60", Slot = "6")]
		public void Set(ref AttributeDataValue? other)
		{
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018C2")]
		[Address(RVA = "0x505C40", Offset = "0x504240", VA = "0x180505C40", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018C3")]
		[Address(RVA = "0x505CB0", Offset = "0x5042B0", VA = "0x180505CB0", Slot = "4")]
		public void Get(out AttributeDataValue output)
		{
		}

		// Token: 0x04000B1C RID: 2844
		[Token(Token = "0x4000B1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private long m_AsInt64;

		// Token: 0x04000B1D RID: 2845
		[Token(Token = "0x4000B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double m_AsDouble;

		// Token: 0x04000B1E RID: 2846
		[Token(Token = "0x4000B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_AsBool;

		// Token: 0x04000B1F RID: 2847
		[Token(Token = "0x4000B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr m_AsUtf8;

		// Token: 0x04000B20 RID: 2848
		[Token(Token = "0x4000B20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private AttributeType m_ValueType;
	}
}
