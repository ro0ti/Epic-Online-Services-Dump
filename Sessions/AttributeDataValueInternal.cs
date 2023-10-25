using System;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x020000FD RID: 253
	[Token(Token = "0x20000FD")]
	[StructLayout(2)]
	internal struct AttributeDataValueInternal : IGettable<AttributeDataValue>, ISettable<AttributeDataValue>, IDisposable
	{
		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x000037AC File Offset: 0x000019AC
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001AC")]
		public long? AsInt64
		{
			[Token(Token = "0x600085C")]
			[Address(RVA = "0x4B9C80", Offset = "0x4B8280", VA = "0x1804B9C80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085D")]
			[Address(RVA = "0x4B9F40", Offset = "0x4B8540", VA = "0x1804B9F40")]
			set
			{
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x000037C4 File Offset: 0x000019C4
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001AD")]
		public double? AsDouble
		{
			[Token(Token = "0x600085E")]
			[Address(RVA = "0x4B9BE0", Offset = "0x4B81E0", VA = "0x1804B9BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085F")]
			[Address(RVA = "0x4B9E70", Offset = "0x4B8470", VA = "0x1804B9E70")]
			set
			{
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x000037DC File Offset: 0x000019DC
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001AE")]
		public bool? AsBool
		{
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x4B9B50", Offset = "0x4B8150", VA = "0x1804B9B50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000861")]
			[Address(RVA = "0x4B9DB0", Offset = "0x4B83B0", VA = "0x1804B9DB0")]
			set
			{
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001AF")]
		public Utf8String AsUtf8
		{
			[Token(Token = "0x6000862")]
			[Address(RVA = "0x4B9D20", Offset = "0x4B8320", VA = "0x1804B9D20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000863")]
			[Address(RVA = "0x4BA010", Offset = "0x4B8610", VA = "0x1804BA010")]
			set
			{
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x4B99D0", Offset = "0x4B7FD0", VA = "0x1804B99D0", Slot = "5")]
		public void Set(ref AttributeDataValue other)
		{
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x4B9710", Offset = "0x4B7D10", VA = "0x1804B9710", Slot = "6")]
		public void Set(ref AttributeDataValue? other)
		{
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x4B9670", Offset = "0x4B7C70", VA = "0x1804B9670", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x4B96E0", Offset = "0x4B7CE0", VA = "0x1804B96E0", Slot = "4")]
		public void Get(out AttributeDataValue output)
		{
		}

		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private long m_AsInt64;

		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double m_AsDouble;

		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_AsBool;

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr m_AsUtf8;

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private AttributeType m_ValueType;
	}
}
