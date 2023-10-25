using System;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000565 RID: 1381
	[Token(Token = "0x2000565")]
	internal struct KeyImageInfoInternal : IGettable<KeyImageInfo>, ISettable<KeyImageInfo>, IDisposable
	{
		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060023A1 RID: 9121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A59")]
		public Utf8String Type
		{
			[Token(Token = "0x60023A0")]
			[Address(RVA = "0x548C10", Offset = "0x547210", VA = "0x180548C10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60023A1")]
			[Address(RVA = "0x548CF0", Offset = "0x5472F0", VA = "0x180548CF0")]
			set
			{
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x060023A2 RID: 9122 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060023A3 RID: 9123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A5A")]
		public Utf8String Url
		{
			[Token(Token = "0x60023A2")]
			[Address(RVA = "0x548C80", Offset = "0x547280", VA = "0x180548C80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60023A3")]
			[Address(RVA = "0x548D50", Offset = "0x547350", VA = "0x180548D50")]
			set
			{
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x00009674 File Offset: 0x00007874
		// (set) Token: 0x060023A5 RID: 9125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A5B")]
		public uint Width
		{
			[Token(Token = "0x60023A4")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60023A5")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x060023A6 RID: 9126 RVA: 0x0000968C File Offset: 0x0000788C
		// (set) Token: 0x060023A7 RID: 9127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A5C")]
		public uint Height
		{
			[Token(Token = "0x60023A6")]
			[Address(RVA = "0x4A5AF0", Offset = "0x4A40F0", VA = "0x1804A5AF0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60023A7")]
			[Address(RVA = "0x4A5CB0", Offset = "0x4A42B0", VA = "0x1804A5CB0")]
			set
			{
			}
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60023A8")]
		[Address(RVA = "0x548B40", Offset = "0x547140", VA = "0x180548B40", Slot = "5")]
		public void Set(ref KeyImageInfo other)
		{
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60023A9")]
		[Address(RVA = "0x5489F0", Offset = "0x546FF0", VA = "0x1805489F0", Slot = "6")]
		public void Set(ref KeyImageInfo? other)
		{
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60023AA")]
		[Address(RVA = "0x548970", Offset = "0x546F70", VA = "0x180548970", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60023AB")]
		[Address(RVA = "0x5489D0", Offset = "0x546FD0", VA = "0x1805489D0", Slot = "4")]
		public void Get(out KeyImageInfo output)
		{
		}

		// Token: 0x04000FEB RID: 4075
		[Token(Token = "0x4000FEB")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000FEC RID: 4076
		[Token(Token = "0x4000FEC")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Type;

		// Token: 0x04000FED RID: 4077
		[Token(Token = "0x4000FED")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Url;

		// Token: 0x04000FEE RID: 4078
		[Token(Token = "0x4000FEE")]
		[FieldOffset(Offset = "0x18")]
		private uint m_Width;

		// Token: 0x04000FEF RID: 4079
		[Token(Token = "0x4000FEF")]
		[FieldOffset(Offset = "0x1C")]
		private uint m_Height;
	}
}
