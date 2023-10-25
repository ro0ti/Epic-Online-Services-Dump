using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003A8 RID: 936
	[Token(Token = "0x20003A8")]
	internal struct AttributeInternal : IGettable<Attribute>, ISettable<Attribute>, IDisposable
	{
		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x00006EB4 File Offset: 0x000050B4
		// (set) Token: 0x06001894 RID: 6292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006C1")]
		public AttributeData? Data
		{
			[Token(Token = "0x6001893")]
			[Address(RVA = "0x5073F0", Offset = "0x5059F0", VA = "0x1805073F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001894")]
			[Address(RVA = "0x507480", Offset = "0x505A80", VA = "0x180507480")]
			set
			{
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x00006ECC File Offset: 0x000050CC
		// (set) Token: 0x06001896 RID: 6294 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006C2")]
		public LobbyAttributeVisibility Visibility
		{
			[Token(Token = "0x6001895")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return LobbyAttributeVisibility.Public;
			}
			[Token(Token = "0x6001896")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001897")]
		[Address(RVA = "0x507210", Offset = "0x505810", VA = "0x180507210", Slot = "5")]
		public void Set(ref Attribute other)
		{
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001898")]
		[Address(RVA = "0x5072C0", Offset = "0x5058C0", VA = "0x1805072C0", Slot = "6")]
		public void Set(ref Attribute? other)
		{
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001899")]
		[Address(RVA = "0x507190", Offset = "0x505790", VA = "0x180507190", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600189A")]
		[Address(RVA = "0x5071E0", Offset = "0x5057E0", VA = "0x1805071E0", Slot = "4")]
		public void Get(out Attribute output)
		{
		}

		// Token: 0x04000B0F RID: 2831
		[Token(Token = "0x4000B0F")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000B10 RID: 2832
		[Token(Token = "0x4000B10")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Data;

		// Token: 0x04000B11 RID: 2833
		[Token(Token = "0x4000B11")]
		[FieldOffset(Offset = "0x10")]
		private LobbyAttributeVisibility m_Visibility;
	}
}
