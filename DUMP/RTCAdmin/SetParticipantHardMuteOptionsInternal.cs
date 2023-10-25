using System;


namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x02000254 RID: 596
	[Token(Token = "0x2000254")]
	internal struct SetParticipantHardMuteOptionsInternal : ISettable<SetParticipantHardMuteOptions>, IDisposable
	{
		// Token: 0x17000425 RID: 1061
		// (set) Token: 0x06001077 RID: 4215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000425")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6001077")]
			[Address(RVA = "0x4E64A0", Offset = "0x4E4AA0", VA = "0x1804E64A0")]
			set
			{
			}
		}

		// Token: 0x17000426 RID: 1062
		// (set) Token: 0x06001078 RID: 4216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000426")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001078")]
			[Address(RVA = "0x4E6500", Offset = "0x4E4B00", VA = "0x1804E6500")]
			set
			{
			}
		}

		// Token: 0x17000427 RID: 1063
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000427")]
		public bool Mute
		{
			[Token(Token = "0x6001079")]
			[Address(RVA = "0x4E6440", Offset = "0x4E4A40", VA = "0x1804E6440")]
			set
			{
			}
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600107A")]
		[Address(RVA = "0x4E61E0", Offset = "0x4E47E0", VA = "0x1804E61E0", Slot = "4")]
		public void Set(ref SetParticipantHardMuteOptions other)
		{
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600107B")]
		[Address(RVA = "0x4E62E0", Offset = "0x4E48E0", VA = "0x1804E62E0", Slot = "5")]
		public void Set(ref SetParticipantHardMuteOptions? other)
		{
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600107C")]
		[Address(RVA = "0x4E6180", Offset = "0x4E4780", VA = "0x1804E6180", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000753 RID: 1875
		[Token(Token = "0x4000753")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000754 RID: 1876
		[Token(Token = "0x4000754")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_RoomName;

		// Token: 0x04000755 RID: 1877
		[Token(Token = "0x4000755")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;

		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x4000756")]
		[FieldOffset(Offset = "0x18")]
		private int m_Mute;
	}
}
