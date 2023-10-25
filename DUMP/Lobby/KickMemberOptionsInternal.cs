using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003D8 RID: 984
	[Token(Token = "0x20003D8")]
	internal struct KickMemberOptionsInternal : ISettable<KickMemberOptions>, IDisposable
	{
		// Token: 0x1700075E RID: 1886
		// (set) Token: 0x06001A01 RID: 6657 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700075E")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001A01")]
			[Address(RVA = "0x510210", Offset = "0x50E810", VA = "0x180510210")]
			set
			{
			}
		}

		// Token: 0x1700075F RID: 1887
		// (set) Token: 0x06001A02 RID: 6658 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700075F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001A02")]
			[Address(RVA = "0x510270", Offset = "0x50E870", VA = "0x180510270")]
			set
			{
			}
		}

		// Token: 0x17000760 RID: 1888
		// (set) Token: 0x06001A03 RID: 6659 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000760")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001A03")]
			[Address(RVA = "0x5102D0", Offset = "0x50E8D0", VA = "0x1805102D0")]
			set
			{
			}
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A04")]
		[Address(RVA = "0x510110", Offset = "0x50E710", VA = "0x180510110", Slot = "4")]
		public void Set(ref KickMemberOptions other)
		{
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A05")]
		[Address(RVA = "0x50FFB0", Offset = "0x50E5B0", VA = "0x18050FFB0", Slot = "5")]
		public void Set(ref KickMemberOptions? other)
		{
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A06")]
		[Address(RVA = "0x50FF40", Offset = "0x50E540", VA = "0x18050FF40", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000BB7 RID: 2999
		[Token(Token = "0x4000BB7")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000BB8 RID: 3000
		[Token(Token = "0x4000BB8")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LobbyId;

		// Token: 0x04000BB9 RID: 3001
		[Token(Token = "0x4000BB9")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000BBA RID: 3002
		[Token(Token = "0x4000BBA")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
