using System;


namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x0200024F RID: 591
	[Token(Token = "0x200024F")]
	internal struct QueryJoinRoomTokenOptionsInternal : ISettable<QueryJoinRoomTokenOptions>, IDisposable
	{
		// Token: 0x17000419 RID: 1049
		// (set) Token: 0x06001051 RID: 4177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000419")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001051")]
			[Address(RVA = "0x4E01E0", Offset = "0x4DE7E0", VA = "0x1804E01E0")]
			set
			{
			}
		}

		// Token: 0x1700041A RID: 1050
		// (set) Token: 0x06001052 RID: 4178 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700041A")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6001052")]
			[Address(RVA = "0x4E0240", Offset = "0x4DE840", VA = "0x1804E0240")]
			set
			{
			}
		}

		// Token: 0x1700041B RID: 1051
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700041B")]
		public ProductUserId[] TargetUserIds
		{
			[Token(Token = "0x6001053")]
			[Address(RVA = "0x4E02A0", Offset = "0x4DE8A0", VA = "0x1804E02A0")]
			set
			{
			}
		}

		// Token: 0x1700041C RID: 1052
		// (set) Token: 0x06001054 RID: 4180 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700041C")]
		public Utf8String TargetUserIpAddresses
		{
			[Token(Token = "0x6001054")]
			[Address(RVA = "0x4E0320", Offset = "0x4DE920", VA = "0x1804E0320")]
			set
			{
			}
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001055")]
		[Address(RVA = "0x4E00D0", Offset = "0x4DE6D0", VA = "0x1804E00D0", Slot = "4")]
		public void Set(ref QueryJoinRoomTokenOptions other)
		{
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001056")]
		[Address(RVA = "0x4DFF40", Offset = "0x4DE540", VA = "0x1804DFF40", Slot = "5")]
		public void Set(ref QueryJoinRoomTokenOptions? other)
		{
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001057")]
		[Address(RVA = "0x4DFEC0", Offset = "0x4DE4C0", VA = "0x1804DFEC0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000740 RID: 1856
		[Token(Token = "0x4000740")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000741 RID: 1857
		[Token(Token = "0x4000741")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000742 RID: 1858
		[Token(Token = "0x4000742")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x04000743 RID: 1859
		[Token(Token = "0x4000743")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserIds;

		// Token: 0x04000744 RID: 1860
		[Token(Token = "0x4000744")]
		[FieldOffset(Offset = "0x20")]
		private uint m_TargetUserIdsCount;

		// Token: 0x04000745 RID: 1861
		[Token(Token = "0x4000745")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_TargetUserIpAddresses;
	}
}
