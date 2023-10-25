using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000107 RID: 263
	[Token(Token = "0x2000107")]
	internal struct CreateSessionModificationOptionsInternal : ISettable<CreateSessionModificationOptions>, IDisposable
	{
		// Token: 0x170001C0 RID: 448
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001C0")]
		public Utf8String SessionName
		{
			[Token(Token = "0x6000890")]
			[Address(RVA = "0x4BBE00", Offset = "0x4BA400", VA = "0x1804BBE00")]
			set
			{
			}
		}

		// Token: 0x170001C1 RID: 449
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001C1")]
		public Utf8String BucketId
		{
			[Token(Token = "0x6000891")]
			[Address(RVA = "0x4BBC20", Offset = "0x4BA220", VA = "0x1804BBC20")]
			set
			{
			}
		}

		// Token: 0x170001C2 RID: 450
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001C2")]
		public uint MaxPlayers
		{
			[Token(Token = "0x6000892")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x170001C3 RID: 451
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001C3")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000893")]
			[Address(RVA = "0x4BBC80", Offset = "0x4BA280", VA = "0x1804BBC80")]
			set
			{
			}
		}

		// Token: 0x170001C4 RID: 452
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001C4")]
		public bool PresenceEnabled
		{
			[Token(Token = "0x6000894")]
			[Address(RVA = "0x4BBCE0", Offset = "0x4BA2E0", VA = "0x1804BBCE0")]
			set
			{
			}
		}

		// Token: 0x170001C5 RID: 453
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001C5")]
		public Utf8String SessionId
		{
			[Token(Token = "0x6000895")]
			[Address(RVA = "0x4BBDA0", Offset = "0x4BA3A0", VA = "0x1804BBDA0")]
			set
			{
			}
		}

		// Token: 0x170001C6 RID: 454
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001C6")]
		public bool SanctionsEnabled
		{
			[Token(Token = "0x6000896")]
			[Address(RVA = "0x4BBD40", Offset = "0x4BA340", VA = "0x1804BBD40")]
			set
			{
			}
		}

		// Token: 0x170001C7 RID: 455
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001C7")]
		public uint[] AllowedPlatformIds
		{
			[Token(Token = "0x6000897")]
			[Address(RVA = "0x4BBBA0", Offset = "0x4BA1A0", VA = "0x1804BBBA0")]
			set
			{
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000898")]
		[Address(RVA = "0x4BB9B0", Offset = "0x4B9FB0", VA = "0x1804BB9B0", Slot = "4")]
		public void Set(ref CreateSessionModificationOptions other)
		{
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000899")]
		[Address(RVA = "0x4BB710", Offset = "0x4B9D10", VA = "0x1804BB710", Slot = "5")]
		public void Set(ref CreateSessionModificationOptions? other)
		{
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089A")]
		[Address(RVA = "0x4BB690", Offset = "0x4B9C90", VA = "0x1804BB690", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionName;

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_BucketId;

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x18")]
		private uint m_MaxPlayers;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x28")]
		private int m_PresenceEnabled;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x30")]
		private IntPtr m_SessionId;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x38")]
		private int m_SanctionsEnabled;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x40")]
		private IntPtr m_AllowedPlatformIds;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x48")]
		private uint m_AllowedPlatformIdsCount;
	}
}
