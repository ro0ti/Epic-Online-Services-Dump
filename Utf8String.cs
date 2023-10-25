using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[DebuggerDisplay("{ToString()}")]
	public sealed class Utf8String
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000236C File Offset: 0x0000056C
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000D")]
		public int Length
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000E")]
		public byte[] Bytes
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000F")]
		private string Utf16
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x4B7BF0", Offset = "0x4B61F0", VA = "0x1804B7BF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x4B80A0", Offset = "0x4B66A0", VA = "0x1804B80A0")]
			set
			{
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x4B7AB0", Offset = "0x4B60B0", VA = "0x1804B7AB0")]
		public Utf8String()
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x4B7990", Offset = "0x4B5F90", VA = "0x1804B7990")]
		public Utf8String(byte[] bytes)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x4B7AD0", Offset = "0x4B60D0", VA = "0x1804B7AD0")]
		public Utf8String(string value)
		{
		}

		// Token: 0x17000010 RID: 16
		[Token(Token = "0x17000010")]
		public byte this[int index]
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x4B7BC0", Offset = "0x4B61C0", VA = "0x1804B7BC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x4B8070", Offset = "0x4B6670", VA = "0x1804B8070")]
			set
			{
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x4B7E60", Offset = "0x4B6460", VA = "0x1804B7E60")]
		public static explicit operator Utf8String(byte[] bytes)
		{
			return null;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x4B7E40", Offset = "0x4B6440", VA = "0x1804B7E40")]
		public static explicit operator byte[](Utf8String u8str)
		{
			return null;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x4B7EC0", Offset = "0x4B64C0", VA = "0x1804B7EC0")]
		public static implicit operator Utf8String(string str)
		{
			return null;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x4B7FE0", Offset = "0x4B65E0", VA = "0x1804B7FE0")]
		public static implicit operator string(Utf8String u8str)
		{
			return null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x4B7D30", Offset = "0x4B6330", VA = "0x1804B7D30")]
		public static Utf8String operator +(Utf8String left, Utf8String right)
		{
			return null;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x4B7E20", Offset = "0x4B6420", VA = "0x1804B7E20")]
		public static bool operator ==(Utf8String left, Utf8String right)
		{
			return default(bool);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x4B8030", Offset = "0x4B6630", VA = "0x1804B8030")]
		public static bool operator !=(Utf8String left, Utf8String right)
		{
			return default(bool);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x4B7740", Offset = "0x4B5D40", VA = "0x1804B7740", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x4B7850", Offset = "0x4B5E50", VA = "0x1804B7850", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x4B7810", Offset = "0x4B5E10", VA = "0x1804B7810", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}
	}
}
