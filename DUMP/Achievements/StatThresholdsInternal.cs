using System;


namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200077A RID: 1914
	[Token(Token = "0x200077A")]
	internal struct StatThresholdsInternal : IGettable<StatThresholds>, ISettable<StatThresholds>, IDisposable
	{
		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06003143 RID: 12611 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06003144 RID: 12612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ED7")]
		public Utf8String Name
		{
			[Token(Token = "0x6003143")]
			[Address(RVA = "0x58C370", Offset = "0x58A970", VA = "0x18058C370")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003144")]
			[Address(RVA = "0x58C3E0", Offset = "0x58A9E0", VA = "0x18058C3E0")]
			set
			{
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06003145 RID: 12613 RVA: 0x0000CAC4 File Offset: 0x0000ACC4
		// (set) Token: 0x06003146 RID: 12614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ED8")]
		public int Threshold
		{
			[Token(Token = "0x6003145")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003146")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003147")]
		[Address(RVA = "0x58C220", Offset = "0x58A820", VA = "0x18058C220", Slot = "5")]
		public void Set(ref StatThresholds other)
		{
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003148")]
		[Address(RVA = "0x58C2A0", Offset = "0x58A8A0", VA = "0x18058C2A0", Slot = "6")]
		public void Set(ref StatThresholds? other)
		{
		}

		// Token: 0x06003149 RID: 12617 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003149")]
		[Address(RVA = "0x58C1B0", Offset = "0x58A7B0", VA = "0x18058C1B0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600314A")]
		[Address(RVA = "0x58C200", Offset = "0x58A800", VA = "0x18058C200", Slot = "4")]
		public void Get(out StatThresholds output)
		{
		}

		// Token: 0x04001621 RID: 5665
		[Token(Token = "0x4001621")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001622 RID: 5666
		[Token(Token = "0x4001622")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Name;

		// Token: 0x04001623 RID: 5667
		[Token(Token = "0x4001623")]
		[FieldOffset(Offset = "0x10")]
		private int m_Threshold;
	}
}
