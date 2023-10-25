using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x020000FB RID: 251
	[Token(Token = "0x20000FB")]
	internal struct AttributeDataInternal : IGettable<AttributeData>, ISettable<AttributeData>, IDisposable
	{
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A5")]
		public Utf8String Key
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x4B94A0", Offset = "0x4B7AA0", VA = "0x1804B94A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x4B95A0", Offset = "0x4B7BA0", VA = "0x1804B95A0")]
			set
			{
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x000036BC File Offset: 0x000018BC
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A6")]
		public AttributeDataValue Value
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x4B9510", Offset = "0x4B7B10", VA = "0x1804B9510")]
			get
			{
				return default(AttributeDataValue);
			}
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x4B9600", Offset = "0x4B7C00", VA = "0x1804B9600")]
			set
			{
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x4B9240", Offset = "0x4B7840", VA = "0x1804B9240", Slot = "5")]
		public void Set(ref AttributeData other)
		{
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x4B9340", Offset = "0x4B7940", VA = "0x1804B9340", Slot = "6")]
		public void Set(ref AttributeData? other)
		{
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x4B91A0", Offset = "0x4B77A0", VA = "0x1804B91A0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x4B9210", Offset = "0x4B7810", VA = "0x1804B9210", Slot = "4")]
		public void Get(out AttributeData output)
		{
		}

		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000408 RID: 1032
		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Key;

		// Token: 0x04000409 RID: 1033
		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x10")]
		private AttributeDataValueInternal m_Value;
	}
}
