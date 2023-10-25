using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200023D RID: 573
	[Token(Token = "0x200023D")]
	internal struct UpdateSendingVolumeOptionsInternal : ISettable<UpdateSendingVolumeOptions>, IDisposable
	{
		// Token: 0x170003F4 RID: 1012
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003F4")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000FE2")]
			[Address(RVA = "0x4EAF60", Offset = "0x4E9560", VA = "0x1804EAF60")]
			set
			{
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003F5")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000FE3")]
			[Address(RVA = "0x4EAFC0", Offset = "0x4E95C0", VA = "0x1804EAFC0")]
			set
			{
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003F6")]
		public float Volume
		{
			[Token(Token = "0x6000FE4")]
			[Address(RVA = "0x4AFB80", Offset = "0x4AE180", VA = "0x1804AFB80")]
			set
			{
			}
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FE5")]
		[Address(RVA = "0x4EAD60", Offset = "0x4E9360", VA = "0x1804EAD60", Slot = "4")]
		public void Set(ref UpdateSendingVolumeOptions other)
		{
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FE6")]
		[Address(RVA = "0x4EAE30", Offset = "0x4E9430", VA = "0x1804EAE30", Slot = "5")]
		public void Set(ref UpdateSendingVolumeOptions? other)
		{
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FE7")]
		[Address(RVA = "0x4EAD00", Offset = "0x4E9300", VA = "0x1804EAD00", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000719 RID: 1817
		[Token(Token = "0x4000719")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400071A RID: 1818
		[Token(Token = "0x400071A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400071B RID: 1819
		[Token(Token = "0x400071B")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x0400071C RID: 1820
		[Token(Token = "0x400071C")]
		[FieldOffset(Offset = "0x18")]
		private float m_Volume;
	}
}
