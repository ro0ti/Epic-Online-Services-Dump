using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x020000FC RID: 252
	[Token(Token = "0x20000FC")]
	public struct AttributeDataValue
	{
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x000036D4 File Offset: 0x000018D4
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A7")]
		public long? AsInt64
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x4BA430", Offset = "0x4B8A30", VA = "0x1804BA430")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x4BA970", Offset = "0x4B8F70", VA = "0x1804BA970")]
			set
			{
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x000036EC File Offset: 0x000018EC
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A8")]
		public double? AsDouble
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x4BA390", Offset = "0x4B8990", VA = "0x1804BA390")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x4BA8D0", Offset = "0x4B8ED0", VA = "0x1804BA8D0")]
			set
			{
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x00003704 File Offset: 0x00001904
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A9")]
		public bool? AsBool
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0x4BA300", Offset = "0x4B8900", VA = "0x1804BA300")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000851")]
			[Address(RVA = "0x4BA840", Offset = "0x4B8E40", VA = "0x1804BA840")]
			set
			{
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001AA")]
		public Utf8String AsUtf8
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0x4BA4D0", Offset = "0x4B8AD0", VA = "0x1804BA4D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000853")]
			[Address(RVA = "0x4BAA10", Offset = "0x4B9010", VA = "0x1804BAA10")]
			set
			{
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x0000371C File Offset: 0x0000191C
		// (set) Token: 0x06000855 RID: 2133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001AB")]
		public AttributeType ValueType
		{
			[Token(Token = "0x6000854")]
			[Address(RVA = "0x3D2E80", Offset = "0x3D1480", VA = "0x1803D2E80")]
			get
			{
				return AttributeType.Boolean;
			}
			[Token(Token = "0x6000855")]
			[Address(RVA = "0x3D2EB0", Offset = "0x3D14B0", VA = "0x1803D2EB0")]
			private set
			{
			}
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00003734 File Offset: 0x00001934
		[Token(Token = "0x6000856")]
		[Address(RVA = "0x4BA750", Offset = "0x4B8D50", VA = "0x1804BA750")]
		public static implicit operator AttributeDataValue(long value)
		{
			return default(AttributeDataValue);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0000374C File Offset: 0x0000194C
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x4BA560", Offset = "0x4B8B60", VA = "0x1804BA560")]
		public static implicit operator AttributeDataValue(double value)
		{
			return default(AttributeDataValue);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00003764 File Offset: 0x00001964
		[Token(Token = "0x6000858")]
		[Address(RVA = "0x4BA6D0", Offset = "0x4B8CD0", VA = "0x1804BA6D0")]
		public static implicit operator AttributeDataValue(bool value)
		{
			return default(AttributeDataValue);
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0000377C File Offset: 0x0000197C
		[Token(Token = "0x6000859")]
		[Address(RVA = "0x4BA650", Offset = "0x4B8C50", VA = "0x1804BA650")]
		public static implicit operator AttributeDataValue(Utf8String value)
		{
			return default(AttributeDataValue);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00003794 File Offset: 0x00001994
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x4BA680", Offset = "0x4B8C80", VA = "0x1804BA680")]
		public static implicit operator AttributeDataValue(string value)
		{
			return default(AttributeDataValue);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x4BA0D0", Offset = "0x4B86D0", VA = "0x1804BA0D0")]
		internal void Set(ref AttributeDataValueInternal other)
		{
		}

		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x0")]
		private long? m_AsInt64;

		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x10")]
		private double? m_AsDouble;

		// Token: 0x0400040C RID: 1036
		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x20")]
		private bool? m_AsBool;

		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x28")]
		private Utf8String m_AsUtf8;

		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x30")]
		private AttributeType m_ValueType;
	}
}
