using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200040B RID: 1035
	[Token(Token = "0x200040B")]
	internal struct LobbyModificationAddMemberAttributeOptionsInternal : ISettable<LobbyModificationAddMemberAttributeOptions>, IDisposable
	{
		// Token: 0x170007DA RID: 2010
		// (set) Token: 0x06001B9E RID: 7070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007DA")]
		public AttributeData? Attribute
		{
			[Token(Token = "0x6001B9E")]
			[Address(RVA = "0x52A4E0", Offset = "0x528AE0", VA = "0x18052A4E0")]
			set
			{
			}
		}

		// Token: 0x170007DB RID: 2011
		// (set) Token: 0x06001B9F RID: 7071 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007DB")]
		public LobbyAttributeVisibility Visibility
		{
			[Token(Token = "0x6001B9F")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BA0")]
		[Address(RVA = "0x52A430", Offset = "0x528A30", VA = "0x18052A430", Slot = "4")]
		public void Set(ref LobbyModificationAddMemberAttributeOptions other)
		{
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BA1")]
		[Address(RVA = "0x52A300", Offset = "0x528900", VA = "0x18052A300", Slot = "5")]
		public void Set(ref LobbyModificationAddMemberAttributeOptions? other)
		{
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BA2")]
		[Address(RVA = "0x52A2B0", Offset = "0x5288B0", VA = "0x18052A2B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000C8E RID: 3214
		[Token(Token = "0x4000C8E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000C8F RID: 3215
		[Token(Token = "0x4000C8F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Attribute;

		// Token: 0x04000C90 RID: 3216
		[Token(Token = "0x4000C90")]
		[FieldOffset(Offset = "0x10")]
		private LobbyAttributeVisibility m_Visibility;
	}
}
